namespace MapleShark.GUI
{
    partial class ConverterScriptForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.InTb = new Alsing.Windows.Forms.SyntaxBoxControl();
            this.OutTb = new Alsing.Windows.Forms.SyntaxBoxControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-1, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.InTb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OutTb);
            this.splitContainer1.Size = new System.Drawing.Size(906, 485);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 0;
            // 
            // InTb
            // 
            this.InTb.ActiveView = Alsing.Windows.Forms.ActiveView.BottomRight;
            this.InTb.AutoListPosition = null;
            this.InTb.AutoListSelectedText = "a123";
            this.InTb.AutoListVisible = false;
            this.InTb.BackColor = System.Drawing.Color.White;
            this.InTb.BorderStyle = Alsing.Windows.Forms.BorderStyle.None;
            this.InTb.CopyAsRTF = false;
            this.InTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InTb.FontName = "Courier new";
            this.InTb.HighLightActiveLine = true;
            this.InTb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InTb.Indent = Alsing.Windows.Forms.SyntaxBox.IndentStyle.Scope;
            this.InTb.InfoTipCount = 1;
            this.InTb.InfoTipPosition = null;
            this.InTb.InfoTipSelectedIndex = 1;
            this.InTb.InfoTipVisible = false;
            this.InTb.Location = new System.Drawing.Point(0, 0);
            this.InTb.LockCursorUpdate = false;
            this.InTb.Name = "InTb";
            this.InTb.ParseOnPaste = true;
            this.InTb.ShowScopeIndicator = false;
            this.InTb.Size = new System.Drawing.Size(457, 485);
            this.InTb.SmoothScroll = true;
            this.InTb.SmoothScrollSpeed = 1;
            this.InTb.SplitviewH = -4;
            this.InTb.SplitviewV = -4;
            this.InTb.TabGuideColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.InTb.TabIndex = 1;
            this.InTb.TabsToSpaces = true;
            this.InTb.VirtualWhitespace = true;
            this.InTb.WhitespaceColor = System.Drawing.SystemColors.ControlDark;
            // 
            // OutTb
            // 
            this.OutTb.ActiveView = Alsing.Windows.Forms.ActiveView.BottomRight;
            this.OutTb.AutoListPosition = null;
            this.OutTb.AutoListSelectedText = "a123";
            this.OutTb.AutoListVisible = false;
            this.OutTb.BackColor = System.Drawing.Color.White;
            this.OutTb.BorderStyle = Alsing.Windows.Forms.BorderStyle.None;
            this.OutTb.CopyAsRTF = false;
            this.OutTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutTb.FontName = "Courier new";
            this.OutTb.HighLightActiveLine = true;
            this.OutTb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OutTb.Indent = Alsing.Windows.Forms.SyntaxBox.IndentStyle.Scope;
            this.OutTb.InfoTipCount = 1;
            this.OutTb.InfoTipPosition = null;
            this.OutTb.InfoTipSelectedIndex = 1;
            this.OutTb.InfoTipVisible = false;
            this.OutTb.Location = new System.Drawing.Point(0, 0);
            this.OutTb.LockCursorUpdate = false;
            this.OutTb.Name = "OutTb";
            this.OutTb.ParseOnPaste = true;
            this.OutTb.ShowScopeIndicator = false;
            this.OutTb.Size = new System.Drawing.Size(445, 485);
            this.OutTb.SmoothScroll = true;
            this.OutTb.SplitviewH = -4;
            this.OutTb.SplitviewV = -4;
            this.OutTb.TabGuideColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.OutTb.TabIndex = 1;
            this.OutTb.TabsToSpaces = true;
            this.OutTb.Text = "\tScriptAPI.AddShort(\"Packet Size\");";
            this.OutTb.VirtualWhitespace = true;
            this.OutTb.WhitespaceColor = System.Drawing.SystemColors.ControlDark;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConverterScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 513);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConverterScriptForm";
            this.Text = "ConverterScriptForm";
            this.Load += new System.EventHandler(this.ConverterScriptForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Alsing.Windows.Forms.SyntaxBoxControl InTb;
        private Alsing.Windows.Forms.SyntaxBoxControl OutTb;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}