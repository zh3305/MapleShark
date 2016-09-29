using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleShark.GUI
{
    public partial class frmAddPacket : Form
    {
        private List<MaplePacket> mPackets;
        ushort Build;
        byte Locale;
        public frmAddPacket(List<MaplePacket> pcs, ushort mBuild, byte mLocale)
        {
            InitializeComponent();
            mPackets = pcs;
            Build = mBuild;
            Locale = mLocale;
            tbBuild.Text = mBuild.ToString();
            tbLocal.Text = ((int)mLocale).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tbPacketOpcode.Text.Replace("0x", "") == ""))
                return;
            var Opcode = UInt16.Parse(tbPacketOpcode.Text.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);
            Definition definition = Config.Instance.GetDefinition(Build, Locale, !radsend.Checked, Opcode );
            var buffer = tools.HexTool.getByteArrayFromHexString(tb_Packets.Text);
            MaplePacket packet = new MaplePacket(DateTime.Now, !radsend.Checked, Build, Locale, Opcode, definition == null ? "" : definition.Name, buffer, 0, 0);
            mPackets.Add(packet);
            this.Close();
        }

        private void tbPacketOpcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labOpcodeName.Text = Config.Instance.GetDefinition(Build, Locale, !radsend.Checked, UInt16.Parse(tbPacketOpcode.Text.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber)).Name;
            }
            catch {
            }
        }
        private void convet()
        {
            int b = Int32.Parse("266", System.Globalization.NumberStyles.HexNumber);
        }
        private void frmAddPacket_Load(object sender, EventArgs e)
        {

        }
    }
}
