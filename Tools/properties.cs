using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.IO;

namespace MapleShark.Tools
{
    /// <summary>
    ///ReadProperties 的摘要说明
    /// </summary>
    public class ReadProperties : Dictionary<String, String>
    {
        public static System.Text.Encoding Encoding = System.Text.Encoding.UTF8;
        private ArrayList list = new ArrayList();
        public ArrayList List
        {
            get { return list; }
            set { list = value; }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fileName">要读写的properties文件名</param>
        public ReadProperties(string fileName)
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
            GetText(fileName);
            Load(fileName);
        }
        public string getkey(String Value)
        {
            //return this.SelectMany(m => m).Where(kvp => kvp.Key == "valueTitle").Select(k => k.Value).ToList(); (t => t.Value == Value).First().Key;
            if (this.ContainsValue(Value))
                return this.First(kvp => kvp.Value == Value).Key;
            else
                return string.Empty;
        }
        private static string GetText(string file)
        {

            if (!File.Exists(file))
            {
                return "";
            }
            string content = File.ReadAllText(file);
            if (content.Contains("�"))
            {
                Encoding = System.Text.Encoding.GetEncoding("GBK");
                content = File.ReadAllText(file, System.Text.Encoding.GetEncoding("GBK"));
            }
            return content;
        }
        ///// <summary>
        ///// 重写父类的方法
        ///// </summary>
        ///// <param name="key">键</param>
        ///// <param name="value">值</param>
        //public override void Add(object key, object value)
        //{
        //    base.Add(key, value);
        //    list.Add(key);
        ////}
        //public override ICollection Keys
        //{
        //    get
        //    {
        //        return list;
        //    }
        //}
        /// <summary>
        /// 加载文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public void Load(string filePath)
        {

            if (!File.Exists(filePath))
            {
                return;
            }
            char[] convertBuf = new char[1024];
            int limit;
            int keyLen;
            int valueStart;
            char c;
            string bufLine = string.Empty;
            bool hasSep;
            bool precedingBackslash;
            using (StreamReader sr = new StreamReader(filePath,Encoding))
            {
                while (sr.Peek() >= 0)
                {
                    bufLine = sr.ReadLine();
                    limit = bufLine.Length;
                    keyLen = 0;
                    valueStart = limit;
                    hasSep = false;
                    precedingBackslash = false;
                    if (bufLine.StartsWith("#")) { 
                        keyLen = bufLine.Length;
                        continue;
                    }

                    if (bufLine.StartsWith("//"))
                    {
                        keyLen = bufLine.Length;
                        continue;
                    }
                    while (keyLen < limit)
                    {
                        c = bufLine[keyLen];
                        if ((c == '=' || c == ':') & !precedingBackslash)
                        {
                            valueStart = keyLen + 1;
                            hasSep = true;
                            break;
                        }
                        else if ((c == ' ' || c == '\t' || c == '\f') & !precedingBackslash)
                        {
                            valueStart = keyLen + 1;
                            break;
                        }
                        if (c == '\\')
                        {
                            precedingBackslash = !precedingBackslash;
                        }
                        else
                        {
                            precedingBackslash = false;
                        }
                        keyLen++;
                    }
                    while (valueStart < limit)
                    {
                        c = bufLine[valueStart];
                        if (c != ' ' && c != '\t' && c != '\f')
                        {
                            if (!hasSep && (c == '=' || c == ':'))
                            {
                                hasSep = true;
                            }
                            else
                            {
                                break;
                            }
                        }
                        valueStart++;
                    }
                    string key = bufLine.Substring(0, keyLen);
                    string values = bufLine.Substring(valueStart, limit - valueStart);
                    if (key == "")
                        key += "#";
                    while (key.StartsWith("#") & this.ContainsKey(key))
                    {
                        key += "#";
                    }
                    this.Add(key, values);
                }
            }
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="filePath">要保存的文件的路径</param>
        public void save(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            FileStream fileStream = File.Create(filePath);
            StreamWriter sw = new StreamWriter(fileStream);
            foreach (object item in list)
            {
                String key = (String)item;
                String val = (String)this[key];
                if (key.StartsWith("#"))
                {
                    if (val == "")
                    {
                        sw.WriteLine(key);
                    }
                    else
                    {
                        sw.WriteLine(val);
                    }
                }
                else
                {
                    sw.WriteLine(key + "=" + val);
                }
            }
            sw.Close();
            fileStream.Close();
        }
    }
}
