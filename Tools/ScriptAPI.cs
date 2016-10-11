//using ScriptNET.Runtime;

//using Scripting.SSharp.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using tools;

namespace MapleShark
{
    public  class ScriptAPI
    {
        public StructureForm mStructure = null;

        [Bindable(false)]
        internal ScriptAPI(StructureForm pStructure) { mStructure = pStructure; }
        public long AddByte(string pName) { return mStructure.APIAddByte(pName); }
        public long DAddByte() { return mStructure.APIDAddByte(); }
        public long AddSByte(string pName) { return mStructure.APIAddSByte(pName); }
        public long AddUShort(string pName) { return mStructure.APIAddUShort(pName); }
        public long AddShort(string pName) { return mStructure.APIAddShort(pName); }
        public long AddUInt(string pName) { return mStructure.APIAddUInt(pName); }
        public long AddInt(string pName) { return mStructure.APIAddInt(pName); }
        public long DAddInt() { return mStructure.APIDAddInt(); }
        public long AddLong(string pName) { return mStructure.APIAddLong(pName); }
        public double AddFloat(string pName) { return mStructure.APIAddFloat(pName); }
        public double AddDouble(string pName) { return mStructure.APIAddDouble(pName); }
        public bool AddBool(string pName) { return mStructure.APIAddBool(pName); }
        public string AddString(string pName) { return mStructure.APIAddString(pName); }
        public string AddPaddedString(string pName, int pLength) { return mStructure.APIAddPaddedString(pName, pLength); }
        public void AddField(string pName, int pLength) { mStructure.APIAddField(pName, pLength); }
        public void AddComment(string pComment) { mStructure.APIAddComment(pComment); }
        public void StartNode(string pName) { mStructure.APIStartNode(pName); }
        public void EndNode(bool pExpand) { mStructure.APIEndNode(pExpand); }
        public string GetFiletime() { return mStructure.APIGetFiletime(); }
        public void CWrite(string count)
        {
            Console.WriteLine(count);
        }
        public void WriteFile(string pPath, string pLine) {
			pLine = pLine.Replace("\r\n", "\\r\\n");
			using (StreamWriter writer = File.AppendText(pPath)) {
				writer.WriteLine(pLine);
			}
        }
        public long Remaining() { return mStructure.APIRemaining(); }
    }
    public sealed class mplew : ScriptAPI
    {
        public void LogMessage(string Text)
        {
            MainForm.mDummyOutputWindow.LogMessage(Text);
            MainForm.mDummyOutputWindow.Activate();
        }
        public void LogWarning(string Text)
        {
            MainForm.mDummyOutputWindow.LogWarning(Text);
            MainForm.mDummyOutputWindow.Activate();
        }
        public void LogError(string Text)
        {
            MainForm.mDummyOutputWindow.LogError(Text);
            MainForm.mDummyOutputWindow.Activate();
        }
        public void LogAppend( string Text)
        {
            LogAppend(Color.Black, Text);
        }
        public void LogAppend(int FromArgb, string Text)
        {
            Color color = Color.FromArgb(FromArgb);
            LogAppend(color, Text);
        }
        public void LogAppend(Color color, string Text)
        {
            MainForm.mDummyOutputWindow.LogAppend(color, Text);
            MainForm.mDummyOutputWindow.Activate();
        }
        public mplew(StructureForm pStructure) : base(pStructure) { }
   
        /**
         * Write the number of zero bytes
         *
         * @param i
         */
        public void writeZeroBytes(string Name,  int i)
        {
            base.StartNode(Name + " Zero "+i);
            for (int x = 0; x < i; x++)
            {
                base.mStructure.APIAddByte("", 0);
            }
            base.EndNode(false);
        }

        /**
         * Write the number of zero bytes
         *
         * @param i
         */
        public  void writeZeroBytes(int i)
        {
            base.StartNode("writeZeroBytes " + i);
            for (int x = 0; x < i; x++)
            {
                base.mStructure.APIAddByte("", 0);
            }
            base.EndNode(false);
        }
        //public  void write( byte[] b)//不确定长度
        //{
        //    for (int x = 0; x < b.Length; x++)
        //    {
        //        baosWrite(b[x]);
        //    }
        //}
        public byte write(params byte[] b)
        {
            return write("", b);
        }
        public byte write(string Name,params byte[] b)
        {
           return base.mStructure.APIAddByte(Name, b);
        }
        public int writeShort( params int[] b)
        {
            return writeShort("", b);
        }
        public int writeShort(string Name, params int[] b)
        {
         return   base.mStructure.APIAddShort(Name, b);
        }
        public int writeInt( params int[] b)
        {
            return writeInt("", b);
        }
        public int writeInt(string Name, params int[] b)
        {
            return base.mStructure.APIAddInt(Name, b);
        }
        public String writeAsciiString( int length, params String[] b)
        {
            return writeAsciiString("", length, b);
        }
        public String writeAsciiString(String Name,int length, params String[] b)
        {
            return base.mStructure.APIAddPaddedString(Name, length, b);
        }


        public  String writeMapleAsciiString( String Name, params String[] b)
        {
           return base.mStructure.APIAddString(Name, b);
        }

        //public  void writeNullTerminatedCharString(String s)//未使用过
        //{
        //    byte[] strBytes = s.getBytes(ASCII);
        //    for (byte b : strBytes)
        //    {
        //        baosWrite(b);
        //        baosWrite((byte)0);
        //    }
        //    log("\r\n");
        //}

        public  bool writeBoolean(string Name)
        {
            //baosWrite((byte)(b ? 1 : 0));
            //log("\r\n");
          return  Convert.ToBoolean(  base.mStructure.APIAddByte(Name,0,1));
        }

        public  void writePos(string Name)//Point s
        {
            base.StartNode("Point "+ Name);
            writeShort(Name+" .X");
            writeShort(Name + " .Y");
            base.EndNode(false);
            //log("\r\n");
        }

        public  void writeRect(string Name)//Rectangle s
        {
            base.StartNode("Rectangle " + Name);
            writeInt(Name + " .X");
            writeInt(Name + " .Y");
            writeInt(Name + " .width");
            writeInt(Name + " .height");
            base.EndNode(false);
            //log("\r\n");
        }

        public long writeLong( params long[] b)
        {
            return writeLong("", b);
        }
        /**
         * Write a long integer to the stream.
         *
         * @param l The long integer to write.
         */
        public long writeLong(String Name, params long[] b)
        {
            return base.mStructure.APIAddLong(Name, b);
        }
        public long writeReversedLong( params long[] b)//未实现
        {
            return writeReversedLong("", b);
        }
        public long writeReversedLong(String Name, params long[] b)//未实现
        {
            return base.mStructure.APIAddLong(Name, b);
            //baosWrite((byte)((l >>> 32) & 0xFF));
            //baosWrite((byte)((l >>> 40) & 0xFF));
            //baosWrite((byte)((l >>> 48) & 0xFF));
            //baosWrite((byte)((l >>> 56) & 0xFF));
            //baosWrite((byte)(l & 0xFF));
            //baosWrite((byte)((l >>> 8) & 0xFF));
            //baosWrite((byte)((l >>> 16) & 0xFF));
            //baosWrite((byte)((l >>> 24) & 0xFF));
            //log("\r\n");
        }
        public long writeReversedInt(params int[] b)//未实现
        {
            return writeReversedInt("", b);
        }
        public long writeReversedInt(String Name, params int[] b)//未实现
        {
            return writeInt(Name, b);
            //baosWrite((byte)(int)(a >>> 32 & 255L));
            //baosWrite((byte)(int)(a >>> 40 & 255L));
            //baosWrite((byte)(int)(a >>> 48 & 255L));
            //baosWrite((byte)(int)(a >>> 56 & 255L));

        }
        public void skip(int length)
        {
            base.AddField("skip " + length, length);
        }
        public byte[] writeBuffer( int length)
        {
            return writeBuffer("",  length);
        }
        public byte[] writeBuffer(String Name, int length)
        {
            StartNode("Buffer " + Name);
            byte[] rtb = new byte[length];
            for (var i = 0; i < length; i++)
            {
                rtb[i] = write("Buffer " + i);
            }
            EndNode(false);
            return rtb;
        }
        public byte[] writeBuffer( string HexString)
        {
            return writeBuffer("", HexString);
        }
        public byte[] writeBuffer(String Name, string HexString)
        {
            var hex = HexTool.getByteArrayFromHexString(HexString);
            StartNode("BufferFromHexString" + Name);
            //byte[] rtb = new byte[length];
            for (var i = 0; i < hex.Length; i++)
            {
                hex[i] = write("", hex[i]);
            }
            EndNode(false);
            return hex;
        }
        //public  void writeFile( File file)
        //{
        //try
        //{
        //    byte[] bytes;
        //    InputStream is = new FileInputStream(file);
        //    long length = file.length();
        //    if (length > Integer.MAX_VALUE)
        //    {
        //        System.err.println("档案太大");
        //        return;
        //    }
        //    bytes = new byte[(int)length];
        //    int offset = 0;
        //    int numRead = 0;
        //    while ((offset < bytes.length) && ((numRead = is.read(bytes, offset, bytes.length - offset)) >= 0)) {
        //        offset += numRead;
        //    }
        //    if (offset < bytes.length)
        //    {
        //        System.err.println("无法完整读取档案:" + file.getName());
        //        return;
        //    }
        //    writeInt(bytes.length);
        //    write(bytes);
        //}
        //catch (IOException e)
        //{
        //    System.err.println("读取档案失败:" + e);
        //}
        //}
    }
}
