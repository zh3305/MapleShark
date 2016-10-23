//using Scripting.SSharp;
//using ScriptNET;
//using Scripting.SSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MapleShark
{
    public partial class StructureForm : DockContent
    {
        private MaplePacket mParsing = null;
        private Stack<StructureNode> mSubNodes = new Stack<StructureNode>();
        /// <summary>
        /// 包头与默认值不匹配
        /// </summary>
        private Color cl_bpp = Color.FromArgb(0xFF0033);
        /// <summary>
        /// 未检查包头
        /// </summary>
        private Color cl_dm = Color.FromArgb(0x0099CC);
        /// <summary>
        /// 包头与默认值相同
        /// </summary>
        private Color cl_tg = Color.FromArgb(0x009933);
        /// <summary>
        /// 同名称标签值不同
        /// </summary>
        private Color cl_btz = Color.FromArgb(0xFF6666);
        public Dictionary<String, Object> NodeKeys = new Dictionary<string, object>();

        public StructureForm()
        {
            InitializeComponent();
            VroomJs.AssemblyLoader.EnsureLoaded();
        }

        public MainForm MainForm { get { return ParentForm as MainForm; } }
        public TreeView Tree { get { return mTree; } }

        public void ParseMaplePacket(MaplePacket pPacket)
        {
            mTree.Nodes.Clear();
            mSubNodes.Clear();
            pPacket.Rewind();
            NodeKeys.Clear();

            string scriptPath = Application.StartupPath + Path.DirectorySeparatorChar + "Scripts" + Path.DirectorySeparatorChar + pPacket.Locale.ToString() + Path.DirectorySeparatorChar + pPacket.Build.ToString() + Path.DirectorySeparatorChar + (pPacket.Outbound ? "发送" : "接收") + Path.DirectorySeparatorChar + "0x" + pPacket.Opcode.ToString("X4") + ".txt";
            string commonPath = Application.StartupPath + Path.DirectorySeparatorChar + "Scripts" + Path.DirectorySeparatorChar + pPacket.Locale.ToString() + Path.DirectorySeparatorChar + pPacket.Build.ToString() + Path.DirectorySeparatorChar + "Common.js";
            if (File.Exists(scriptPath))
            {
                mParsing = pPacket;

                try
                {
                    StringBuilder scriptCode = new StringBuilder();
                    StringBuilder commonCode = new StringBuilder();
                    scriptCode.Append(File.ReadAllText(scriptPath));
                    if (File.Exists(commonPath)) commonCode.Append(File.ReadAllText(commonPath));
                    // SSharp
                    // Script script = Script.Compile(scriptCode.ToString());
                    // script.Context.SetItem("ScriptAPI", new ScriptAPI(this));
                    // script.Execute();

                    //Jint 语法支持不好
                    //var engine = new Jint.Engine();
                    //engine.SetValue("ScriptAPI", new ScriptAPI(this));
                    //engine.SetValue("mplew", new mplew(this));
                    //engine.Execute(commonCode.ToString());
                    //engine.Execute(scriptCode.ToString());

                    //NiL.JS 不支持抛出异常行号
                    //var context = new NiL.JS.Core.Context();
                    //context.DefineVariable("ScriptAPI").Assign(NiL.JS.Core.JSValue.Marshal(new ScriptAPI(this)));
                    //context.DefineVariable("mplew").Assign(NiL.JS.Core.JSValue.Marshal(new mplew(this)));
                    //context.Eval(commonCode.ToString());
                    //context.Eval(scriptCode.ToString());

                    //VroomJs 
                    //var engine = new VroomJs.JsEngine(4, 32);
                    //using (VroomJs.JsContext context = engine.CreateContext())
                    //{
                    //    context.SetVariable("ScriptAPI", new ScriptAPI(this));
                    //    context.SetVariable("mplew", new mplew(this));
                    //    context.Execute(commonCode.ToString());
                    //    context.Execute(scriptCode.ToString());
                    //}

                    // Microsoft.ClearScript 
                    // 循环变量必须先声明 : 不声明如下情况只会执行一次 
                    // for ( i = 0; i < 4; i++ ) {  
                    //  for (var  i = 0; i < 4; i++ ) {  没问题
                    var engine = new Microsoft.ClearScript.V8.V8ScriptEngine();
                    engine.AddHostObject("ScriptAPI", new ScriptAPI(this));
                    engine.AddHostObject("mplew", new mplew(this));
                    engine.Execute(commonCode.ToString());
                    engine.Execute(scriptCode.ToString());

                }
                catch (Microsoft.ClearScript.ScriptEngineException ex)
                {
                    MainForm.mDummyOutputWindow.Append( ex.ErrorDetails);
                    MainForm.mDummyOutputWindow.Activate();
                }
                catch (Jint.Parser.ParserException exc)
                {
                    //OutputForm output = new OutputForm("Script Error");
                    //output.Append(exc.Message);
                    //output.Show(DockPanel, new Rectangle(MainForm.Location, new Size(400, 400)));
                    MainForm.mDummyOutputWindow.Append(exc.Message);
                    MainForm.mDummyOutputWindow.Activate();
                }
                catch (Jint.Runtime.JavaScriptException exc)
                {
                    MainForm.mDummyOutputWindow.Append(" LineNumber:" + exc.LineNumber + " : " + exc.Message); ;
                    MainForm.mDummyOutputWindow.Activate();
                    //OutputForm output = new OutputForm("Script Error");
                    //output.Append(exc.LineNumber + " : " + exc.Message);
                    //output.Show(DockPanel, new Rectangle(MainForm.Location, new Size(400, 400)));
                }
                catch (NiL.JS.Core.JSException ex)
                {
                    MainForm.mDummyOutputWindow.Append(ex.Error.Value.ToString());
                    MainForm.mDummyOutputWindow.Activate();
                }
                catch (VroomJs.JsException ex)
                {
                    MainForm.mDummyOutputWindow.Append(" LineNumber:" + ex.Line + " : " + ex.Message); ;
                    MainForm.mDummyOutputWindow.Activate();
                }
                catch (Exception exc)
                {
                    MainForm.mDummyOutputWindow.Append(exc.ToString());
                    MainForm.mDummyOutputWindow.Activate();
                    //OutputForm output = new OutputForm("Script Error");
                    //output.Append(exc.ToString());
                    //output.Show(DockPanel, new Rectangle(MainForm.Location, new Size(400, 400)));
                }

                mParsing = null;
            }
            if (pPacket.Remaining > 0) mTree.Nodes.Add(new StructureNode("Undefined", pPacket.Buffer, pPacket.Cursor, pPacket.Remaining));
        }

        private TreeNodeCollection CurrentNodes { get { return mSubNodes.Count > 0 ? mSubNodes.Peek().Nodes : mTree.Nodes; } }
        internal string APIGetFiletime()
        {
            return  DateTime.Now.ToFileTime().ToString().Substring(12); 
        }
        internal byte APIAddByte(string pName)
        {
            byte value;
            if (!mParsing.ReadByte(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 1, 1));
            return value;
        }
        internal byte APIAddByte(string pName, params Byte[] compare)
        {
            byte value;
            if (!mParsing.ReadByte(out value)) throw new Exception("Insufficient packet data");
            Color color = Ck<Byte>(ref pName, value, compare);
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 1, 1, color));
            return value;
        }
        internal int APIAddInt(string pName, params int[] compare)
        {
            int value;
            if (!mParsing.ReadInt(out value)) throw new Exception("Insufficient packet data");
            Color color = Ck<int>(ref pName, value, compare);
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 4, 4, color));
            return value;
        }
        internal long APIAddLong(string pName, params long[] compare)
        {
            long value;
            if (!mParsing.ReadLong(out value)) throw new Exception("Insufficient packet data");
            Color color = Ck<long>(ref pName, value, compare);
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 8, 8, color));
            return value;
        }
        internal string APIAddPaddedString(string pName, int pLength ,params string[] compare)
        {
            string value;
            if (!mParsing.ReadPaddedString(out value, pLength)) throw new Exception("Insufficient packet data");
            Color color = Ck<string>(ref pName, value, compare);
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - pLength, pLength, color));
            return value;
        }
        public Color Ck<T>(ref string pName,T value, params T[] compare) where T : IComparable //struct,
        {
            Color color = cl_dm;
            //var Defaults = false;
            if (pName.Trim() == string.Empty)
            {
                //Defaults = true;
                pName += "fixed ";
            }
            else
            {
                if (NodeKeys.ContainsKey(pName))
                {
                    if (value.GetType() == NodeKeys[pName].GetType())
                    {
                        if (0 != value.CompareTo(NodeKeys[pName]))
                        {
                            color = cl_btz;
                        }
                    }
                    else
                    {
                        if (value.ToString().Trim() != NodeKeys[pName].ToString().Trim())
                        {
                            color = cl_btz;
                        }
                    }
                }
                else
                {
                    NodeKeys.Add(pName, value);
                }
            }
            if (compare != null && compare.Length > 0)
            {
                color = cl_bpp;
                foreach (var a in compare)
                {
                    //if (Defaults)
                    //{
                    //    pName += a.ToString() + "  0x" + Convert.ToString(int.Parse(a.ToString()), 16).ToUpper();
                    //}
                    if (value.CompareTo(a)  == 0)
                    {
                        color = cl_tg;
                    }
                }
            }
            int outin ;
            if (int.TryParse(value.ToString(), out outin))
            { 
            pName += "  0x" + Convert.ToString(outin, 16).ToUpper();
            }
            return color;
        }
        internal short APIAddShort(string pName, params int[] compare)
        {
            short value;
            if (!mParsing.ReadShort(out value)) throw new Exception("Insufficient packet data");
            Color color = Ck<int>(ref pName, value, compare);
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 2, 2, color));
            return value;
        }
        internal sbyte APIAddSByte(string pName)
        {
            sbyte value;
            if (!mParsing.ReadSByte(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 1, 1));
            return value;
        }
        internal ushort APIAddUShort(string pName)
        {
            ushort value;
            if (!mParsing.ReadUShort(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 2, 2));
            return value;
        }
        internal short APIAddShort(string pName)
        {
            short value;
            if (!mParsing.ReadShort(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 2, 2));
            return value;
        }
        internal uint APIAddUInt(string pName)
        {
            uint value;
            if (!mParsing.ReadUInt(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 4, 4));
            return value;
        }
        internal int APIDAddInt()
        {
            int value;
            if (!mParsing.DReadInt(out value)) throw new Exception("Insufficient packet data");
            return value;
        }
        internal byte APIDAddByte()
        {
            byte value;
            if (!mParsing.DReadByte(out value)) throw new Exception("Insufficient packet data");
            return value;
        }
        internal int APIAddInt(string pName)
        {
            int value;
            if (!mParsing.ReadInt(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 4, 4));
            return value;
        }
        internal float APIAddFloat(string pName)
        {
            float value;
            if (!mParsing.ReadFloat(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 4, 4));
            return value;
        }
        internal bool APIAddBool(string pName)
        {
            byte value;
            if (!mParsing.ReadByte(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 1, 1));
            return Convert.ToBoolean(value);
        }
        internal long APIAddLong(string pName)
        {
            long value;
            if (!mParsing.ReadLong(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 8, 8));
            return value;
        }
        internal long APIAddFlippedLong(string pName)
        {
            long value;
            if (!mParsing.ReadFlippedLong(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 8, 8));
            return value;
        }
        internal double APIAddDouble(string pName)
        {
            double value;
            if (!mParsing.ReadDouble(out value)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - 8, 8));
            return value;
        }
        internal string APIAddString(string pName)
        {
            if (pName == "")
            {
                pName = "String";
            }
           APIStartNode(pName);
            short size = APIAddShort("Size");
            string value = APIAddPaddedString("String", size);
            APIEndNode(false);
            return value;
        }
        internal string APIAddString(string pName, params string[] compare)
        {
            if (pName == "")
            {
                pName = "String";
            }
            APIStartNode(pName);
            short size = APIAddShort("Size");
            string value = APIAddPaddedString(pName, size, compare);
            APIEndNode(false);
            return value;
        }
        internal string APIAddPaddedString(string pName, int pLength)
        {
            string value;
            if (!mParsing.ReadPaddedString(out value, pLength)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - pLength, pLength));
            return value;
        }
        internal void APIAddField(string pName, int pLength)
        {
            byte[] buffer = new byte[pLength];
            if (!mParsing.ReadBytes(buffer)) throw new Exception("Insufficient packet data");
            CurrentNodes.Add(new StructureNode(pName, mParsing.Buffer, mParsing.Cursor - pLength, pLength));
        }
        internal void APIAddComment(string pComment)
        {
            CurrentNodes.Add(new StructureNode(pComment, mParsing.Buffer, mParsing.Cursor, 0));
        }
        internal void APIStartNode(string pName)
        {
            StructureNode node = new StructureNode(pName, mParsing.Buffer, mParsing.Cursor, 0);
            if (mSubNodes.Count > 0)
            {
                mSubNodes.Peek().Nodes.Add(node);
            }
            else
            {
                mTree.Nodes.Add(node);
            }
            mSubNodes.Push(node);
        }
        internal void SetNode(string pName)
        {
            if (mSubNodes.Count > 0)
            {
                StructureNode node = mSubNodes.Pop();
                node.Name = pName;
                //node.Length = mParsing.Cursor - node.Cursor;
                //   if (pExpand) node.Expand();
            }
        }
        internal void APIEndNode(bool pExpand)
        {
            if (mSubNodes.Count > 0)
            {
                StructureNode node = mSubNodes.Pop();
                node.Length = mParsing.Cursor - node.Cursor;
                if (pExpand) node.Expand();
            }
        }
        internal int APIRemaining() { return mParsing.Remaining; }


        private void mTree_AfterSelect(object pSender, TreeViewEventArgs pArgs)
        {
            StructureNode node = pArgs.Node as StructureNode;
            if (node == null) { MainForm.DataForm.HexBox.SelectionLength = 0; MainForm.PropertyForm.Properties.SelectedObject = null; return; }
            MainForm.DataForm.HexBox.SelectionStart = node.Cursor;
            MainForm.DataForm.HexBox.SelectionLength = node.Length;
            MainForm.PropertyForm.Properties.SelectedObject = new StructureSegment(node.Buffer, node.Cursor, node.Length, MainForm.Locale);
        }

        private void mTree_KeyDown(object pSender, KeyEventArgs pArgs)
        {
            MainForm.CopyPacketHex(pArgs);
        }
    }
}
