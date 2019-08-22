namespace MapleShark
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.mFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileImportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.importJavapropertiesFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMSnifferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSeparatorMenu = new System.Windows.Forms.ToolStripSeparator();
            this.mFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewSearchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewDataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewStructureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewPropertiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converScripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mTimer = new System.Windows.Forms.Timer(this.components);
            this.mImportDialog = new System.Windows.Forms.OpenFileDialog();
            this.mOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mStopStartButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.mDockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.mMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileMenu,
            this.mViewMenu,
            this.converScripToolStripMenuItem});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(857, 25);
            this.mMenu.TabIndex = 1;
            // 
            // mFileMenu
            // 
            this.mFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileOpenMenu,
            this.mFileImportMenu,
            this.importJavapropertiesFileToolStripMenuItem,
            this.importMSnifferToolStripMenuItem,
            this.toolStripSeparator4,
            this.setupToolStripMenuItem,
            this.mFileSeparatorMenu,
            this.mFileQuit});
            this.mFileMenu.Name = "mFileMenu";
            this.mFileMenu.Size = new System.Drawing.Size(39, 21);
            this.mFileMenu.Text = "文件";
            // 
            // mFileOpenMenu
            // 
            this.mFileOpenMenu.Name = "mFileOpenMenu";
            this.mFileOpenMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mFileOpenMenu.Size = new System.Drawing.Size(239, 22);
            this.mFileOpenMenu.Text = "打开 .sb 文件";
            this.mFileOpenMenu.Click += new System.EventHandler(this.mFileOpenMenu_Click);
            // 
            // mFileImportMenu
            // 
            this.mFileImportMenu.Name = "mFileImportMenu";
            this.mFileImportMenu.Size = new System.Drawing.Size(239, 22);
            this.mFileImportMenu.Text = "导入 .pcap 文件";
            this.mFileImportMenu.Click += new System.EventHandler(this.mFileImportMenu_Click);
            // 
            // importJavapropertiesFileToolStripMenuItem
            // 
            this.importJavapropertiesFileToolStripMenuItem.Name = "importJavapropertiesFileToolStripMenuItem";
            this.importJavapropertiesFileToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.importJavapropertiesFileToolStripMenuItem.Text = "导入 Java *.properties 文件";
            this.importJavapropertiesFileToolStripMenuItem.Click += new System.EventHandler(this.importJavapropertiesFileToolStripMenuItem_Click);
            // 
            // importMSnifferToolStripMenuItem
            // 
            this.importMSnifferToolStripMenuItem.Name = "importMSnifferToolStripMenuItem";
            this.importMSnifferToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.importMSnifferToolStripMenuItem.Text = "导入 MSniffer 日志文件";
            this.importMSnifferToolStripMenuItem.Click += new System.EventHandler(this.importMSnifferToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(236, 6);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.setupToolStripMenuItem.Text = "MapleShark 配置";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // mFileSeparatorMenu
            // 
            this.mFileSeparatorMenu.Name = "mFileSeparatorMenu";
            this.mFileSeparatorMenu.Size = new System.Drawing.Size(236, 6);
            // 
            // mFileQuit
            // 
            this.mFileQuit.Name = "mFileQuit";
            this.mFileQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mFileQuit.Size = new System.Drawing.Size(239, 22);
            this.mFileQuit.Text = "退出";
            this.mFileQuit.Click += new System.EventHandler(this.mFileQuit_Click);
            // 
            // mViewMenu
            // 
            this.mViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewSearchMenu,
            this.mViewDataMenu,
            this.mViewStructureMenu,
            this.mViewPropertiesMenu,
            this.outToolStripMenuItem});
            this.mViewMenu.Name = "mViewMenu";
            this.mViewMenu.Size = new System.Drawing.Size(47, 21);
            this.mViewMenu.Text = "视图";
            this.mViewMenu.DropDownOpening += new System.EventHandler(this.mViewMenu_DropDownOpening);
            // 
            // mViewSearchMenu
            // 
            this.mViewSearchMenu.Checked = true;
            this.mViewSearchMenu.CheckOnClick = true;
            this.mViewSearchMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewSearchMenu.Name = "mViewSearchMenu";
            this.mViewSearchMenu.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.mViewSearchMenu.Size = new System.Drawing.Size(164, 22);
            this.mViewSearchMenu.Text = "搜索";
            this.mViewSearchMenu.CheckedChanged += new System.EventHandler(this.mViewSearchMenu_CheckedChanged);
            // 
            // mViewDataMenu
            // 
            this.mViewDataMenu.Checked = true;
            this.mViewDataMenu.CheckOnClick = true;
            this.mViewDataMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewDataMenu.Name = "mViewDataMenu";
            this.mViewDataMenu.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.mViewDataMenu.Size = new System.Drawing.Size(164, 22);
            this.mViewDataMenu.Text = "数据";
            this.mViewDataMenu.CheckedChanged += new System.EventHandler(this.mViewDataMenu_CheckedChanged);
            // 
            // mViewStructureMenu
            // 
            this.mViewStructureMenu.Checked = true;
            this.mViewStructureMenu.CheckOnClick = true;
            this.mViewStructureMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewStructureMenu.Name = "mViewStructureMenu";
            this.mViewStructureMenu.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mViewStructureMenu.Size = new System.Drawing.Size(164, 22);
            this.mViewStructureMenu.Text = "结构";
            this.mViewStructureMenu.CheckedChanged += new System.EventHandler(this.mViewStructureMenu_CheckedChanged);
            // 
            // mViewPropertiesMenu
            // 
            this.mViewPropertiesMenu.Checked = true;
            this.mViewPropertiesMenu.CheckOnClick = true;
            this.mViewPropertiesMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewPropertiesMenu.Name = "mViewPropertiesMenu";
            this.mViewPropertiesMenu.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.mViewPropertiesMenu.Size = new System.Drawing.Size(164, 22);
            this.mViewPropertiesMenu.Text = "属性";
            this.mViewPropertiesMenu.CheckedChanged += new System.EventHandler(this.mViewPropertiesMenu_CheckedChanged);
            this.mViewPropertiesMenu.Click += new System.EventHandler(this.mViewPropertiesMenu_Click);
            // 
            // outToolStripMenuItem
            // 
            this.outToolStripMenuItem.Checked = true;
            this.outToolStripMenuItem.CheckOnClick = true;
            this.outToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outToolStripMenuItem.Name = "outToolStripMenuItem";
            this.outToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.outToolStripMenuItem.Text = "输出";
            this.outToolStripMenuItem.Click += new System.EventHandler(this.outToolStripMenuItem_Click);
            // 
            // converScripToolStripMenuItem
            // 
            this.converScripToolStripMenuItem.Name = "converScripToolStripMenuItem";
            this.converScripToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.converScripToolStripMenuItem.Text = "ConverScrip";
            this.converScripToolStripMenuItem.Click += new System.EventHandler(this.converScripToolStripMenuItem_Click);
            // 
            // mTimer
            // 
            this.mTimer.Interval = 300;
            this.mTimer.Tick += new System.EventHandler(this.mTimer_Tick);
            // 
            // mImportDialog
            // 
            this.mImportDialog.Filter = "PCap Files|*.pcap";
            this.mImportDialog.ReadOnlyChecked = true;
            this.mImportDialog.RestoreDirectory = true;
            this.mImportDialog.Title = "Import";
            // 
            // mOpenDialog
            // 
            this.mOpenDialog.Filter = "MapleShark Binary Files|*.msb";
            this.mOpenDialog.Multiselect = true;
            this.mOpenDialog.ReadOnlyChecked = true;
            this.mOpenDialog.RestoreDirectory = true;
            this.mOpenDialog.Title = "Open";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.mStopStartButton,
            this.toolStripSeparator2,
            this.helpToolStripButton,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripTextBox1});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(857, 25);
            this.toolStrip.TabIndex = 11;
            this.toolStrip.Text = "ToolStrip";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "打开";
            this.openToolStripButton.Click += new System.EventHandler(this.mFileOpenMenu_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "保存";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mStopStartButton
            // 
            this.mStopStartButton.Image = global::MapleShark.Properties.Resources.Button_Blank_Red_icon;
            this.mStopStartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mStopStartButton.Name = "mStopStartButton";
            this.mStopStartButton.Size = new System.Drawing.Size(101, 22);
            this.mStopStartButton.Text = "停止嗅探";
            this.mStopStartButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "帮助";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "封包转换";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 25);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // mDockPanel
            // 
            this.mDockPanel.AutoSize = true;
            this.mDockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDockPanel.DockBackColor = System.Drawing.Color.FloralWhite;
            this.mDockPanel.DockBottomPortion = 0.3D;
            this.mDockPanel.DockLeftPortion = 0.3D;
            this.mDockPanel.DockRightPortion = 0.3D;
            this.mDockPanel.DockTopPortion = 75D;
            this.mDockPanel.Location = new System.Drawing.Point(0, 50);
            this.mDockPanel.Name = "mDockPanel";
            this.mDockPanel.Size = new System.Drawing.Size(857, 481);
            this.mDockPanel.TabIndex = 4;
            this.mDockPanel.ActiveDocumentChanged += new System.EventHandler(this.mDockPanel_ActiveDocumentChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 531);
            this.Controls.Add(this.mDockPanel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.mMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapleShark 冒险岛封包工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mFileMenu;
        private System.Windows.Forms.ToolStripMenuItem mFileImportMenu;
        private System.Windows.Forms.ToolStripMenuItem mFileOpenMenu;
        private System.Windows.Forms.Timer mTimer;
        private System.Windows.Forms.OpenFileDialog mImportDialog;
        private System.Windows.Forms.OpenFileDialog mOpenDialog;
        private System.Windows.Forms.ToolStripMenuItem mViewMenu;
        private System.Windows.Forms.ToolStripMenuItem mViewPropertiesMenu;
        private System.Windows.Forms.ToolStripMenuItem mViewStructureMenu;
        private System.Windows.Forms.ToolStripSeparator mFileSeparatorMenu;
        private System.Windows.Forms.ToolStripMenuItem mFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mViewDataMenu;
        private System.Windows.Forms.ToolStripMenuItem mViewSearchMenu;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mStopStartButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem importJavapropertiesFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem importMSnifferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converScripToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem;
        public WeifenLuo.WinFormsUI.Docking.DockPanel mDockPanel;
    }
}

