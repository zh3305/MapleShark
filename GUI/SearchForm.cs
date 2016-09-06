using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MapleShark
{
    /// <summary>
    /// 搜索类型
    /// </summary>
    public enum SearchType
    {
        [Description("包头带数值")]
        OpcodeAndHex = 1,

    };
    public partial class SearchForm : DockContent
    {

        public SearchForm()
        {
            InitializeComponent();
            mSequenceHex.ByteProvider = new DynamicByteProvider(new ByteCollection());
            (mSequenceHex.ByteProvider as DynamicByteProvider).Changed += mSequenceHex_ByteProviderChanged;
            comboBox1.DataSource = Enum.GetValues(typeof(SearchType)).Cast<Enum>()
    .Select(value => new
    {
        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
        value
    })
    .OrderBy(item => item.value)
    .ToList();
            comboBox1.DisplayMember = "Description";
            comboBox1.ValueMember = "Value";
        }

        public MainForm MainForm { get { return ParentForm as MainForm; } }
        public ComboBox ComboBox { get { return mOpcodeCombo; } }
        public HexBox HexBox { get { return mSequenceHex; } }

        public void RefreshOpcodes(bool pReselect)
        {
            SessionForm session = DockPanel.ActiveDocument as SessionForm;
            Opcode selected = pReselect && session != null && mOpcodeCombo.SelectedIndex >= 0 && session.Opcodes.Count > mOpcodeCombo.SelectedIndex ? session.Opcodes[mOpcodeCombo.SelectedIndex] : null;
            mOpcodeCombo.Items.Clear();
            if (session == null) return;
            session.UpdateOpcodeList();
            foreach (Opcode op in session.Opcodes)
            {
                Definition definition = Config.Instance.GetDefinition(session.Build, session.Locale, op.Outbound, op.Header);
                int addedIndex = mOpcodeCombo.Items.Add(string.Format("{0} 0x{1:X4} {2}", (op.Outbound ? "Outbound  " : "Inbound   "), op.Header, definition == null || string.IsNullOrEmpty(definition.Name) ? "" : definition.Name));

                if (selected != null && selected.Outbound == op.Outbound && selected.Header == op.Header)
                {
                    mOpcodeCombo.SelectedIndex = addedIndex;
                }
            }
        }

        private void mOpcodeCombo_SelectedIndexChanged(object pSender, EventArgs pArgs)
        {
            mNextOpcodeButton.Enabled = mPrevOpcodeButton.Enabled = mOpcodeCombo.SelectedIndex >= 0;
        }

        private void mNextOpcodeButton_Click(object pSender, EventArgs pArgs)
        {
            SessionForm session = DockPanel.ActiveDocument as SessionForm;
            if (session == null || mOpcodeCombo.SelectedIndex == -1)
                return;
            Opcode search = (DockPanel.ActiveDocument as SessionForm).Opcodes[mOpcodeCombo.SelectedIndex];
            int initialIndex = session.ListView.SelectedIndices.Count == 0 ? 0 : session.ListView.SelectedIndices[0] + 1;
            for (int index = initialIndex; index < session.ListView.Items.Count; ++index)
            {
                MaplePacket packet = session.ListView.Items[index] as MaplePacket;
                if (packet.Outbound == search.Outbound && packet.Opcode == search.Header)
                {
                    session.ListView.SelectedIndices.Clear();
                    session.ListView.SelectedIndices.Add(index);
                    packet.EnsureVisible();
                    session.ListView.Focus();
                    return;
                }
            }
            MessageBox.Show("No further packets found with the selected opcode.", "End Of Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            session.ListView.Focus();
        }

        private void mSequenceHex_ByteProviderChanged(object pSender, EventArgs pArgs)
        {
            mNextSequenceButton.Enabled/* = mPrevSequenceButton.Enabled*/ = mSequenceHex.ByteProvider.Length > 0;
        }

        private void mSequenceHex_KeyPress(object pSender, KeyPressEventArgs pArgs)
        {
            if (pArgs.KeyChar == (char)Keys.Enter)
            {
                pArgs.Handled = true;
                NextSequence();
            }
        }

        private void mNextSequenceButton_Click(object pSender, EventArgs pArgs)
        {
            NextSequence();
        }

        private void NextSequence()
        {
            SessionForm session = DockPanel.ActiveDocument as SessionForm;
            if (session == null) return;
            int initialIndex = session.ListView.SelectedIndices.Count == 0 ? 0 : session.ListView.SelectedIndices[0];
            byte[] pattern = (mSequenceHex.ByteProvider as DynamicByteProvider).Bytes.ToArray();
            long startIndex = MainForm.DataForm.HexBox.SelectionLength > 0 ? MainForm.DataForm.HexBox.SelectionStart : -1;
            for (int index = initialIndex; index < session.ListView.Items.Count; ++index)//循环选择列表
            {
                MaplePacket packet = session.ListView.Items[index] as MaplePacket;
                long searchIndex = startIndex + 1;
                bool found = false;
                while (searchIndex <= packet.Buffer.Length - pattern.Length)
                {
                    found = true;
                    for (int patternIndex = 0; found && patternIndex < pattern.Length; ++patternIndex) found = packet.Buffer[searchIndex + patternIndex] == pattern[patternIndex];
                    if (found) break;
                    ++searchIndex;
                }
                if (found)
                {
                    session.ListView.SelectedIndices.Clear();
                    session.ListView.SelectedIndices.Add(index);
                    packet.EnsureVisible();
                    MainForm.DataForm.HexBox.SelectionStart = searchIndex;
                    MainForm.DataForm.HexBox.SelectionLength = pattern.Length;
                    MainForm.DataForm.HexBox.ScrollByteIntoView();
                    session.ListView.Focus();
                    return;
                }
                startIndex = -1;
            }
            MessageBox.Show("No further sequences found.", "End Of Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            session.ListView.Focus();
        }

        private void mPrevOpcodeButton_Click(object sender, EventArgs e)
        {
            SessionForm session = DockPanel.ActiveDocument as SessionForm;
            if (session == null || mOpcodeCombo.SelectedIndex == -1)
                return;
            Opcode search = (DockPanel.ActiveDocument as SessionForm).Opcodes[mOpcodeCombo.SelectedIndex];
            int initialIndex = session.ListView.SelectedIndices.Count == 0 ? 0 : session.ListView.SelectedIndices[0];
            for (int index = initialIndex - 1; index > 0; --index)
            {
                MaplePacket packet = session.ListView.Items[index] as MaplePacket;
                if (packet.Outbound == search.Outbound && packet.Opcode == search.Header)
                {
                    session.ListView.SelectedIndices.Clear();
                    session.ListView.SelectedIndices.Add(index);
                    packet.EnsureVisible();
                    session.ListView.Focus();
                    return;
                }
            }
            MessageBox.Show("No further packets found with the selected opcode.", "End Of Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            session.ListView.Focus();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SessionForm session = DockPanel.ActiveDocument as SessionForm;
            if (session == null || (checkBox1.Checked && (mOpcodeCombo.SelectedIndex == -1))||Tb_Regx.Text.Trim()==String.Empty)
            {
                return;
            }
            int initialIndex = session.ListView.SelectedIndices.Count == 0 ? 0 : session.ListView.SelectedIndices[0];
            long startIndex = MainForm.DataForm.HexBox.SelectionLength > 0 ? MainForm.DataForm.HexBox.SelectionStart : -1;
        GoTopS:
            Opcode search=null;
            if (checkBox1.Checked) { 
                search = (DockPanel.ActiveDocument as SessionForm).Opcodes[mOpcodeCombo.SelectedIndex];
            }
            //int initialIndex = session.ListView.SelectedIndices.Count == 0 ? 0 : session.ListView.SelectedIndices[0] + 1;
            //long searchIndex = startIndex ++;
            //startIndex = MainForm.DataForm.HexBox.SelectionLength;
            var selectlen = 0;
            String StrEmpty = " ";
            if (Cb_NoEmpty.Checked)
            {
                StrEmpty = string.Empty;
            }
            for (int index = initialIndex; index < session.ListView.Items.Count; ++index)
            {
                MaplePacket packet = session.ListView.Items[index] as MaplePacket;
                if (!checkBox1.Checked || (packet.Outbound == search.Outbound && packet.Opcode == search.Header))
                {
                    String SerTex;
                    long searchIndex = startIndex + 1;
                    if (searchIndex != 0)
                    {
                        SerTex = BitConverter.ToString(packet.Buffer.Skip((int)searchIndex).ToArray()).Replace("-", StrEmpty);
                    }
                    else
                    {
                        SerTex = BitConverter.ToString(packet.Buffer).Replace("-", StrEmpty);
                        searchIndex = 0;
                    }

                    Match match = Regex.Match(SerTex, Tb_Regx.Text);
                    if (match.Success)
                    {
                        //Console.WriteLine(SerTex);
                        //Console.WriteLine(match.Groups[0].Value);
                        if (Cb_NoEmpty.Checked)
                        {
                            searchIndex += match.Groups[0].Index / 2;
                        }
                        else
                        {
                            searchIndex += match.Groups[0].Index / 3;
                        }
                        selectlen = tools.HexTool.getByteArrayFromHexString(match.Groups[0].Value).Length;
                        Console.WriteLine("字符串索引 [{0}] 计算索引 [{1}]  取模 [{2}] 选着索引 [{3}]", match.Groups[0].Index, searchIndex, match.Groups[0].Index % 3, startIndex);
                      
                        session.ListView.SelectedIndices.Clear();
                        session.ListView.SelectedIndices.Add(index);
                        packet.EnsureVisible();
                        MainForm.DataForm.HexBox.SelectionStart =  searchIndex;
                        MainForm.DataForm.HexBox.SelectionLength = selectlen;//pattern.Length;
                        MainForm.DataForm.HexBox.ScrollByteIntoView();
                        session.ListView.Focus();
                        return;
                    }
                    startIndex = -1;

                }
            }
            //MessageBox.Show("No further packets found with the selected opcode.", "End Of Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (MessageBox.Show("已达到终点位置,是否从起始位置开始搜索?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                initialIndex = 0;
                startIndex = -1;
                goto GoTopS;
            }
            session.ListView.Focus();
            //SessionForm session = DockPanel.ActiveDocument as SessionForm;
            //if (session == null || mOpcodeCombo.SelectedIndex == -1)
            //    return;
            //switch ((SearchType)comboBox1.SelectedValue)
            //{
            //    case SearchType.OpcodeAndHex:
            //        if (session == null) return;
            //        int initialIndex = session.ListView.SelectedIndices.Count == 0 ? 0 : session.ListView.SelectedIndices[0];
            //        byte[] pattern = (mSequenceHex.ByteProvider as DynamicByteProvider).Bytes.ToArray();
            //        long startIndex = MainForm.DataForm.HexBox.SelectionLength > 0 ? MainForm.DataForm.HexBox.SelectionStart : -1;
            //        Opcode search = (DockPanel.ActiveDocument as SessionForm).Opcodes[mOpcodeCombo.SelectedIndex];
            //        //int initialIndex = session.ListView.SelectedIndices.Count == 0 ? 0 : session.ListView.SelectedIndices[0] + 1;
            //        for (int index = initialIndex; index < session.ListView.Items.Count; ++index)
            //        {
            //            MaplePacket packet = session.ListView.Items[index] as MaplePacket;
            //            long searchIndex = startIndex + 1;
            //            bool found = false;
            //            if (packet.Outbound == search.Outbound && packet.Opcode == search.Header)
            //            {
            //                while (searchIndex <= packet.Buffer.Length - pattern.Length)
            //                {
            //                    found = true;
            //                    for (int patternIndex = 0; found && patternIndex < pattern.Length; ++patternIndex) found = packet.Buffer[searchIndex + patternIndex] == pattern[patternIndex];
            //                    if (found) break;
            //                    ++searchIndex;
            //                }
            //                if (found)
            //                {
            //                    session.ListView.SelectedIndices.Clear();
            //                    session.ListView.SelectedIndices.Add(index);
            //                    packet.EnsureVisible();
            //                    MainForm.DataForm.HexBox.SelectionStart = searchIndex;
            //                    MainForm.DataForm.HexBox.SelectionLength = pattern.Length;
            //                    MainForm.DataForm.HexBox.ScrollByteIntoView();
            //                    session.ListView.Focus();
            //                    return;
            //                }
            //                startIndex = -1;

            //                //MaplePacket packet = session.ListView.Items[index] as MaplePacket;
            //                //if (packet.Outbound == search.Outbound && packet.Opcode == search.Header)
            //                //{
            //                //    session.ListView.SelectedIndices.Clear();
            //                //    session.ListView.SelectedIndices.Add(index);
            //                //    packet.EnsureVisible();
            //                //    session.ListView.Focus();
            //                //    return;
            //                //}
            //            }
            //        }
            //        MessageBox.Show("No further packets found with the selected opcode.", "End Of Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        session.ListView.Focus();
            //        break;
            //    default:
            //        MessageBox.Show("未知的搜索选项", "End Of Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        session.ListView.Focus();
            //        break;
            //}

        }
    }
}
