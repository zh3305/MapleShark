using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleShark.GUI
{
    public partial class ConverterScriptForm : Form
    {
        public ConverterScriptForm()
        {
            InitializeComponent();
        }

        String path = @"ConvertScript\";
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ConverterScriptForm_Load(object sender, EventArgs e)
        {


            if (!Directory.Exists(path))
            {
                MessageBox.Show("Erro : No Fond Directory ConvertScript");
                this.Close();
            }
            DirectoryInfo folder = new DirectoryInfo(path);

            foreach (FileInfo file in folder.GetFiles("*.js"))
            {
                AddContextMenu(file.Name.Substring(0, file.Name.Length - 3), menuStrip1.Items, MenuClicked);
            }

        }
        /// <summary>
        /// 添加子菜单
        /// </summary>
        /// <param name="text">要显示的文字，如果为 - 则显示为分割线</param>
        /// <param name="cms">要添加到的子菜单集合</param>
        /// <param name="callback">点击时触发的事件</param>
        /// <returns>生成的子菜单，如果为分隔条则返回null</returns>
        ToolStripMenuItem AddContextMenu(string text, ToolStripItemCollection cms, EventHandler callback)
        {
            if (text == "-")
            {
                ToolStripSeparator tsp = new ToolStripSeparator();
                cms.Add(tsp);
                return null;
            }
            else if (!string.IsNullOrEmpty(text))
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(text);
                tsmi.Tag = text + "TAG";
                if (callback != null) tsmi.Click += callback;
                cms.Add(tsmi);
                return tsmi;
            }
            return null;
        }
        void MenuClicked(object sender, EventArgs e)
        {
            //System.Runtime.Remoting.ObjectHandle t = Activator.CreateInstance("WinForms", "WinForms.Form2");
            //Form f = (Form)t.Unwrap();
            //f.ShowDialog();
            //MessageBox.Show(( (ToolStripMenuItem)sender).Text);

            var de = (ToolStripMenuItem)sender;
            DirectoryInfo folder = new DirectoryInfo(path);
            var Filepath = string.Empty;
            foreach (FileInfo file in folder.GetFiles("*.js"))
            {
                if (file.Name.Substring(0, file.Name.Length - 3) == de.Text)
                {
                    Filepath = file.FullName;
                    break;
                }
            }
            if (Filepath == string.Empty)
            {
                //No Find File
                return;
            }
            StringBuilder scriptCode = new StringBuilder();
            scriptCode.Append(File.ReadAllText(Filepath));
            var context = new NiL.JS.Core.Context();
            try
            {
                //var engine = new Jint.Engine(cfg => cfg.AllowClr());
                //engine.SetValue("intb", InTb);
                //engine.SetValue("outtb", OutTb);
                ////engine.SetValue("Console",new Jint.Native.JsValue Console);
                //engine.Execute(@"var Console={};Console.WriteLine=System.Console.WriteLine");
                //context.DefineVariable("").Assign(NiL.JS.Core.JSValue.GetConstructor(typeof( Console)));
                //engine.Execute(scriptCode.ToString());
                //context.DefineVariable("intb").Assign(NiL.JS.Core.JSValue.Marshal(InTb));
                //context.DefineVariable("outtb").Assign(NiL.JS.Core.JSValue.Marshal(OutTb));
                //context.DefineVariable("Console").Assign(NiL.JS.Core.JSValue.GetConstructor(typeof(Console)));
                //context.DefineVariable("window").Assign(NiL.JS.Core.JSValue.GetConstructor(typeof(Tools.window)));

                //context.Eval(scriptCode.ToString());


                 //Microsoft.ClearScript 
                 //循环变量必须先声明 : 不声明如下情况只会执行一次 
                 //for ( i = 0; i < 4; i++ ) {  
                 // for (var  i = 0; i < 4; i++ ) {  没问题
                var engine = new Microsoft.ClearScript.V8.V8ScriptEngine();
                engine.AddHostObject("intb", InTb);
                engine.AddHostObject("outtb", OutTb);
                engine.AddHostType("Console", typeof(Console));
                engine.AddHostType("window", typeof(Tools.window));
                engine.Execute(scriptCode.ToString());
            }
            catch (Microsoft.ClearScript.ScriptEngineException ex)
            {
                MainForm.mDummyOutputWindow.Append(ex.ErrorDetails);
                MainForm.mDummyOutputWindow.Activate();
            }
            catch (Exception exc)
            {
                //OutputForm output = new OutputForm("Script Error");
                //output.Append(exc.ToString());
                //output.Show(this);

                MainForm.mDummyOutputWindow.Append(exc.ToString()); ;
                MainForm.mDummyOutputWindow.Activate();
            }

        }
    }
}
