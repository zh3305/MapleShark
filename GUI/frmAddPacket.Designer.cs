namespace MapleShark.GUI
{
    partial class frmAddPacket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radsend = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labOpcodeName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Packets = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBuild = new System.Windows.Forms.TextBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPacketOpcode = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radsend
            // 
            this.radsend.AutoSize = true;
            this.radsend.Checked = true;
            this.radsend.Location = new System.Drawing.Point(17, 18);
            this.radsend.Name = "radsend";
            this.radsend.Size = new System.Drawing.Size(83, 16);
            this.radsend.TabIndex = 1;
            this.radsend.TabStop = true;
            this.radsend.Text = "发送封包";
            this.radsend.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "接收封包";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radsend);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择封包头类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(166, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "封包头";
            // 
            // labOpcodeName
            // 
            this.labOpcodeName.AutoSize = true;
            this.labOpcodeName.ForeColor = System.Drawing.Color.OrangeRed;
            this.labOpcodeName.Location = new System.Drawing.Point(390, 59);
            this.labOpcodeName.Name = "labOpcodeName";
            this.labOpcodeName.Size = new System.Drawing.Size(0, 12);
            this.labOpcodeName.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Packets);
            this.groupBox2.Location = new System.Drawing.Point(13, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 188);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "封包";
            // 
            // tb_Packets
            // 
            this.tb_Packets.Location = new System.Drawing.Point(6, 20);
            this.tb_Packets.Multiline = true;
            this.tb_Packets.Name = "tb_Packets";
            this.tb_Packets.Size = new System.Drawing.Size(629, 162);
            this.tb_Packets.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(530, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(166, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "构建:";
            // 
            // tbBuild
            // 
            this.tbBuild.ForeColor = System.Drawing.Color.Teal;
            this.tbBuild.Location = new System.Drawing.Point(214, 29);
            this.tbBuild.Name = "tbBuild";
            this.tbBuild.Size = new System.Drawing.Size(68, 21);
            this.tbBuild.TabIndex = 9;
            // 
            // tbLocal
            // 
            this.tbLocal.ForeColor = System.Drawing.Color.Teal;
            this.tbLocal.Location = new System.Drawing.Point(340, 27);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(68, 21);
            this.tbLocal.TabIndex = 11;
            this.tbLocal.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(292, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "地区:";
            // 
            // tbPacketOpcode
            // 
            this.tbPacketOpcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPacketOpcode.ForeColor = System.Drawing.Color.Teal;
            this.tbPacketOpcode.Location = new System.Drawing.Point(249, 54);
            this.tbPacketOpcode.Name = "tbPacketOpcode";
            this.tbPacketOpcode.Size = new System.Drawing.Size(100, 21);
            this.tbPacketOpcode.TabIndex = 12;
            this.tbPacketOpcode.TextChanged += new System.EventHandler(this.tbPacketOpcode_TextChanged);
            // 
            // frmAddPacket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 269);
            this.Controls.Add(this.tbPacketOpcode);
            this.Controls.Add(this.tbLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBuild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labOpcodeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddPacket";
            this.Text = "frmAddPacket";
            this.Load += new System.EventHandler(this.frmAddPacket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radsend;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labOpcodeName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Packets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBuild;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPacketOpcode;
    }
}
