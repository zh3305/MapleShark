﻿namespace MapleShark
{
    partial class SessionForm
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
            this.mPacketContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mPacketContextNameLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.mPacketContextNameBox = new System.Windows.Forms.ToolStripTextBox();
            this.mPacketContextSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mPacketContextIgnoreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removePacketFromSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisPacketOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.allBeforeThisOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAfterThisOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyVisibleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.mMainFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSeparatorMenu = new System.Windows.Forms.ToolStripSeparator();
            this.mFileSaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileExportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewCommonScriptMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewSeparator1Menu = new System.Windows.Forms.ToolStripSeparator();
            this.mViewRefreshMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewSeparator2Menu = new System.Windows.Forms.ToolStripSeparator();
            this.mViewOutboundMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewInboundMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewIgnoredMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewSeparator3Menu = new System.Windows.Forms.ToolStripSeparator();
            this.sessionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendpropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recvpropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLoggedPacketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPacketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.忽略列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.mExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.mPacketList = new MapleShark.DoubleBufferedListView();
            this.mTimestampColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mDirectionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mLengthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mOpcodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.复制数据到剪贴板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mPacketContextMenu.SuspendLayout();
            this.mMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mPacketContextMenu
            // 
            this.mPacketContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPacketContextNameLabel,
            this.mPacketContextNameBox,
            this.mPacketContextSeparator,
            this.mPacketContextIgnoreMenu,
            this.removePacketFromSessionToolStripMenuItem});
            this.mPacketContextMenu.Name = "mPacketContextMenu";
            this.mPacketContextMenu.Size = new System.Drawing.Size(246, 101);
            this.mPacketContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.mPacketContextMenu_Opening);
            this.mPacketContextMenu.Opened += new System.EventHandler(this.mPacketContextMenu_Opened);
            // 
            // mPacketContextNameLabel
            // 
            this.mPacketContextNameLabel.Enabled = false;
            this.mPacketContextNameLabel.Name = "mPacketContextNameLabel";
            this.mPacketContextNameLabel.Size = new System.Drawing.Size(245, 22);
            this.mPacketContextNameLabel.Text = "封包类型名称:";
            // 
            // mPacketContextNameBox
            // 
            this.mPacketContextNameBox.AcceptsReturn = true;
            this.mPacketContextNameBox.Name = "mPacketContextNameBox";
            this.mPacketContextNameBox.Size = new System.Drawing.Size(150, 23);
            this.mPacketContextNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mPacketContextNameBox_KeyDown);
            // 
            // mPacketContextSeparator
            // 
            this.mPacketContextSeparator.Name = "mPacketContextSeparator";
            this.mPacketContextSeparator.Size = new System.Drawing.Size(242, 6);
            // 
            // mPacketContextIgnoreMenu
            // 
            this.mPacketContextIgnoreMenu.CheckOnClick = true;
            this.mPacketContextIgnoreMenu.Name = "mPacketContextIgnoreMenu";
            this.mPacketContextIgnoreMenu.Size = new System.Drawing.Size(245, 22);
            this.mPacketContextIgnoreMenu.Text = "忽略该类封包";
            this.mPacketContextIgnoreMenu.CheckedChanged += new System.EventHandler(this.mPacketContextIgnoreMenu_CheckedChanged);
            // 
            // removePacketFromSessionToolStripMenuItem
            // 
            this.removePacketFromSessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisPacketOnlyToolStripMenuItem,
            this.toolStripSeparator2,
            this.allBeforeThisOneToolStripMenuItem,
            this.allAfterThisOneToolStripMenuItem});
            this.removePacketFromSessionToolStripMenuItem.Name = "removePacketFromSessionToolStripMenuItem";
            this.removePacketFromSessionToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.removePacketFromSessionToolStripMenuItem.Text = "从会话中移除封包";
            // 
            // thisPacketOnlyToolStripMenuItem
            // 
            this.thisPacketOnlyToolStripMenuItem.Name = "thisPacketOnlyToolStripMenuItem";
            this.thisPacketOnlyToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.thisPacketOnlyToolStripMenuItem.Text = "仅该封包;
            this.thisPacketOnlyToolStripMenuItem.Click += new System.EventHandler(this.thisPacketOnlyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(240, 6);
            // 
            // allBeforeThisOneToolStripMenuItem
            // 
            this.allBeforeThisOneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlyVisibleToolStripMenuItem,
            this.allToolStripMenuItem});
            this.allBeforeThisOneToolStripMenuItem.Name = "allBeforeThisOneToolStripMenuItem";
            this.allBeforeThisOneToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.allBeforeThisOneToolStripMenuItem.Text = "之前所有封包";
            this.allBeforeThisOneToolStripMenuItem.Click += new System.EventHandler(this.allBeforeThisOneToolStripMenuItem_Click);
            // 
            // onlyVisibleToolStripMenuItem
            // 
            this.onlyVisibleToolStripMenuItem.Name = "onlyVisibleToolStripMenuItem";
            this.onlyVisibleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.onlyVisibleToolStripMenuItem.Text = "仅列出可见";
            this.onlyVisibleToolStripMenuItem.Click += new System.EventHandler(this.onlyVisibleToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.allToolStripMenuItem.Text = "所有";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // allAfterThisOneToolStripMenuItem
            // 
            this.allAfterThisOneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlyVisibleToolStripMenuItem1,
            this.allToolStripMenuItem1});
            this.allAfterThisOneToolStripMenuItem.Name = "allAfterThisOneToolStripMenuItem";
            this.allAfterThisOneToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.allAfterThisOneToolStripMenuItem.Text = "之后所有封包";
            // 
            // onlyVisibleToolStripMenuItem1
            // 
            this.onlyVisibleToolStripMenuItem1.Name = "onlyVisibleToolStripMenuItem1";
            this.onlyVisibleToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.onlyVisibleToolStripMenuItem1.Text = "仅列出可见";
            this.onlyVisibleToolStripMenuItem1.Click += new System.EventHandler(this.onlyVisibleToolStripMenuItem1_Click);
            // 
            // allToolStripMenuItem1
            // 
            this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
            this.allToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.allToolStripMenuItem1.Text = "所有";
            this.allToolStripMenuItem1.Click += new System.EventHandler(this.allToolStripMenuItem1_Click);
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMainFileMenu,
            this.mViewMenu,
            this.dataToolStripMenuItem,
            this.addPacketsToolStripMenuItem,
            this.忽略列表ToolStripMenuItem,
            this.复制数据到剪贴板ToolStripMenuItem});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(752, 25);
            this.mMenu.TabIndex = 6;
            this.mMenu.Visible = false;
            this.mMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mMenu_ItemClicked);
            // 
            // mMainFileMenu
            // 
            this.mMainFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileSeparatorMenu,
            this.mFileSaveMenu,
            this.mFileExportMenu});
            this.mMainFileMenu.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mMainFileMenu.Name = "mMainFileMenu";
            this.mMainFileMenu.Size = new System.Drawing.Size(39, 21);
            this.mMainFileMenu.Text = "文件";
            // 
            // mFileSeparatorMenu
            // 
            this.mFileSeparatorMenu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mFileSeparatorMenu.MergeIndex = 2;
            this.mFileSeparatorMenu.Name = "mFileSeparatorMenu";
            this.mFileSeparatorMenu.Size = new System.Drawing.Size(155, 6);
            this.mFileSeparatorMenu.Click += new System.EventHandler(this.mFileSeparatorMenu_Click);
            // 
            // mFileSaveMenu
            // 
            this.mFileSaveMenu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mFileSaveMenu.MergeIndex = 3;
            this.mFileSaveMenu.Name = "mFileSaveMenu";
            this.mFileSaveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mFileSaveMenu.Size = new System.Drawing.Size(158, 22);
            this.mFileSaveMenu.Text = "保存";
            this.mFileSaveMenu.Click += new System.EventHandler(this.MFileSaveMenu_Click);
            // 
            // mFileExportMenu
            // 
            this.mFileExportMenu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mFileExportMenu.MergeIndex = 4;
            this.mFileExportMenu.Name = "mFileExportMenu";
            this.mFileExportMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mFileExportMenu.Size = new System.Drawing.Size(158, 22);
            this.mFileExportMenu.Text = "导出";
            this.mFileExportMenu.Click += new System.EventHandler(this.mFileExportMenu_Click);
            // 
            // mViewMenu
            // 
            this.mViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewCommonScriptMenu,
            this.mViewSeparator1Menu,
            this.mViewRefreshMenu,
            this.mViewSeparator2Menu,
            this.mViewOutboundMenu,
            this.mViewInboundMenu,
            this.mViewIgnoredMenu,
            this.mViewSeparator3Menu,
            this.sessionInformationToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendpropertiesToolStripMenuItem,
            this.recvpropertiesToolStripMenuItem});
            this.mViewMenu.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mViewMenu.Name = "mViewMenu";
            this.mViewMenu.Size = new System.Drawing.Size(47, 21);
            this.mViewMenu.Text = "视图";
            // 
            // mViewCommonScriptMenu
            // 
            this.mViewCommonScriptMenu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mViewCommonScriptMenu.MergeIndex = 0;
            this.mViewCommonScriptMenu.Name = "mViewCommonScriptMenu";
            this.mViewCommonScriptMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mViewCommonScriptMenu.Size = new System.Drawing.Size(243, 22);
            this.mViewCommonScriptMenu.Text = "通用脚本";
            this.mViewCommonScriptMenu.Click += new System.EventHandler(this.mViewCommonScriptMenu_Click);
            // 
            // mViewSeparator1Menu
            // 
            this.mViewSeparator1Menu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mViewSeparator1Menu.MergeIndex = 1;
            this.mViewSeparator1Menu.Name = "mViewSeparator1Menu";
            this.mViewSeparator1Menu.Size = new System.Drawing.Size(240, 6);
            // 
            // mViewRefreshMenu
            // 
            this.mViewRefreshMenu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mViewRefreshMenu.MergeIndex = 2;
            this.mViewRefreshMenu.Name = "mViewRefreshMenu";
            this.mViewRefreshMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mViewRefreshMenu.Size = new System.Drawing.Size(243, 22);
            this.mViewRefreshMenu.Text = "刷新";
            this.mViewRefreshMenu.Click += new System.EventHandler(this.mViewRefreshMenu_Click);
            // 
            // mViewSeparator2Menu
            // 
            this.mViewSeparator2Menu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mViewSeparator2Menu.MergeIndex = 3;
            this.mViewSeparator2Menu.Name = "mViewSeparator2Menu";
            this.mViewSeparator2Menu.Size = new System.Drawing.Size(240, 6);
            // 
            // mViewOutboundMenu
            // 
            this.mViewOutboundMenu.Checked = true;
            this.mViewOutboundMenu.CheckOnClick = true;
            this.mViewOutboundMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewOutboundMenu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mViewOutboundMenu.MergeIndex = 4;
            this.mViewOutboundMenu.Name = "mViewOutboundMenu";
            this.mViewOutboundMenu.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mViewOutboundMenu.Size = new System.Drawing.Size(243, 22);
            this.mViewOutboundMenu.Text = "发送";
            this.mViewOutboundMenu.CheckedChanged += new System.EventHandler(this.mViewOutboundMenu_CheckedChanged);
            // 
            // mViewInboundMenu
            // 
            this.mViewInboundMenu.Checked = true;
            this.mViewInboundMenu.CheckOnClick = true;
            this.mViewInboundMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewInboundMenu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mViewInboundMenu.MergeIndex = 5;
            this.mViewInboundMenu.Name = "mViewInboundMenu";
            this.mViewInboundMenu.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.mViewInboundMenu.Size = new System.Drawing.Size(243, 22);
            this.mViewInboundMenu.Text = "接收";
            this.mViewInboundMenu.CheckedChanged += new System.EventHandler(this.mViewInboundMenu_CheckedChanged);
            // 
            // mViewIgnoredMenu
            // 
            this.mViewIgnoredMenu.CheckOnClick = true;
            this.mViewIgnoredMenu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mViewIgnoredMenu.MergeIndex = 6;
            this.mViewIgnoredMenu.Name = "mViewIgnoredMenu";
            this.mViewIgnoredMenu.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.mViewIgnoredMenu.Size = new System.Drawing.Size(243, 22);
            this.mViewIgnoredMenu.Text = "已忽略封包";
            this.mViewIgnoredMenu.CheckedChanged += new System.EventHandler(this.mViewIgnoredMenu_CheckedChanged);
            // 
            // mViewSeparator3Menu
            // 
            this.mViewSeparator3Menu.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mViewSeparator3Menu.MergeIndex = 7;
            this.mViewSeparator3Menu.Name = "mViewSeparator3Menu";
            this.mViewSeparator3Menu.Size = new System.Drawing.Size(240, 6);
            // 
            // sessionInformationToolStripMenuItem
            // 
            this.sessionInformationToolStripMenuItem.Name = "sessionInformationToolStripMenuItem";
            this.sessionInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.sessionInformationToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.sessionInformationToolStripMenuItem.Text = "会话信息";
            this.sessionInformationToolStripMenuItem.Click += new System.EventHandler(this.sessionInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // sendpropertiesToolStripMenuItem
            // 
            this.sendpropertiesToolStripMenuItem.Name = "sendpropertiesToolStripMenuItem";
            this.sendpropertiesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.sendpropertiesToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.sendpropertiesToolStripMenuItem.Text = "打开 send.properties";
            this.sendpropertiesToolStripMenuItem.Click += new System.EventHandler(this.sendpropertiesToolStripMenuItem_Click);
            // 
            // recvpropertiesToolStripMenuItem
            // 
            this.recvpropertiesToolStripMenuItem.Name = "recvpropertiesToolStripMenuItem";
            this.recvpropertiesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.recvpropertiesToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.recvpropertiesToolStripMenuItem.Text = "打开 recv.properties";
            this.recvpropertiesToolStripMenuItem.Click += new System.EventHandler(this.recvpropertiesToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeLoggedPacketsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.dataToolStripMenuItem.Text = "数据";
            // 
            // removeLoggedPacketsToolStripMenuItem
            // 
            this.removeLoggedPacketsToolStripMenuItem.Name = "removeLoggedPacketsToolStripMenuItem";
            this.removeLoggedPacketsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.removeLoggedPacketsToolStripMenuItem.Text = "移除已记录封包";
            this.removeLoggedPacketsToolStripMenuItem.Click += new System.EventHandler(this.removeLoggedPacketsToolStripMenuItem_Click);
            // 
            // addPacketsToolStripMenuItem
            // 
            this.addPacketsToolStripMenuItem.Name = "addPacketsToolStripMenuItem";
            this.addPacketsToolStripMenuItem.Size = new System.Drawing.Size(93, 21);
            this.addPacketsToolStripMenuItem.Text = "添加封包";
            this.addPacketsToolStripMenuItem.Click += new System.EventHandler(this.addPacketsToolStripMenuItem_Click_1);
            // 
            // 忽略列表ToolStripMenuItem
            // 
            this.忽略列表ToolStripMenuItem.Name = "忽略列表ToolStripMenuItem";
            this.忽略列表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.忽略列表ToolStripMenuItem.Text = "忽略列表";
            this.忽略列表ToolStripMenuItem.Click += new System.EventHandler(this.忽略列表ToolStripMenuItem_Click);
            // 
            // mSaveDialog
            // 
            this.mSaveDialog.Filter = "MapleShark Binary Files|*.msb";
            this.mSaveDialog.RestoreDirectory = true;
            this.mSaveDialog.Title = "保存";
            // 
            // mExportDialog
            // 
            this.mExportDialog.Filter = "Text Files|*.txt";
            this.mExportDialog.RestoreDirectory = true;
            this.mExportDialog.Title = "导出";
            // 
            // mPacketList
            // 
            this.mPacketList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mTimestampColumn,
            this.mDirectionColumn,
            this.mLengthColumn,
            this.mOpcodeColumn,
            this.mNameColumn});
            this.mPacketList.ContextMenuStrip = this.mPacketContextMenu;
            this.mPacketList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPacketList.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPacketList.FullRowSelect = true;
            this.mPacketList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mPacketList.HideSelection = false;
            this.mPacketList.Location = new System.Drawing.Point(0, 25);
            this.mPacketList.MultiSelect = false;
            this.mPacketList.Name = "mPacketList";
            this.mPacketList.Size = new System.Drawing.Size(752, 426);
            this.mPacketList.TabIndex = 0;
            this.mPacketList.UseCompatibleStateImageBehavior = false;
            this.mPacketList.View = System.Windows.Forms.View.Details;
            this.mPacketList.ItemActivate += new System.EventHandler(this.mPacketList_ItemActivate);
            this.mPacketList.SelectedIndexChanged += new System.EventHandler(this.mPacketList_SelectedIndexChanged);
            // 
            // mTimestampColumn
            // 
            this.mTimestampColumn.Text = "时间戳";
            this.mTimestampColumn.Width = 120;
            // 
            // mDirectionColumn
            // 
            this.mDirectionColumn.Text = "方向";
            this.mDirectionColumn.Width = 75;
            // 
            // mLengthColumn
            // 
            this.mLengthColumn.Text = "长度";
            this.mLengthColumn.Width = 64;
            // 
            // mOpcodeColumn
            // 
            this.mOpcodeColumn.Text = "封包头";
            // 
            // mNameColumn
            // 
            this.mNameColumn.Text = "封包类型名称";
            this.mNameColumn.Width = 175;
            // 
            // 复制数据到剪贴板ToolStripMenuItem
            // 
            this.复制数据到剪贴板ToolStripMenuItem.Name = "复制数据到剪贴板ToolStripMenuItem";
            this.复制数据到剪贴板ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.复制数据到剪贴板ToolStripMenuItem.Text = "复制数据到剪贴板";
            this.复制数据到剪贴板ToolStripMenuItem.Click += new System.EventHandler(this.复制数据到剪贴板ToolStripMenuItem_Click_1);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 451);
            this.ControlBox = false;
            this.Controls.Add(this.mPacketList);
            this.Controls.Add(this.mMenu);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SessionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "会话表格";
            this.Load += new System.EventHandler(this.SessionForm_Load);
            this.mPacketContextMenu.ResumeLayout(false);
            this.mPacketContextMenu.PerformLayout();
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader mTimestampColumn;
        private System.Windows.Forms.ColumnHeader mDirectionColumn;
        private System.Windows.Forms.ColumnHeader mLengthColumn;
        private System.Windows.Forms.ColumnHeader mOpcodeColumn;
        private System.Windows.Forms.ColumnHeader mNameColumn;
        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mMainFileMenu;
        private System.Windows.Forms.ToolStripMenuItem mFileSaveMenu;
        private System.Windows.Forms.ToolStripMenuItem mViewMenu;
        private System.Windows.Forms.ToolStripMenuItem mViewOutboundMenu;
        private System.Windows.Forms.ToolStripMenuItem mViewInboundMenu;
        private System.Windows.Forms.ToolStripMenuItem mViewIgnoredMenu;
        private System.Windows.Forms.ToolStripSeparator mViewSeparator1Menu;
        private System.Windows.Forms.ToolStripMenuItem mViewRefreshMenu;
        private System.Windows.Forms.SaveFileDialog mSaveDialog;
        private System.Windows.Forms.ContextMenuStrip mPacketContextMenu;
        private System.Windows.Forms.ToolStripTextBox mPacketContextNameBox;
        private System.Windows.Forms.ToolStripMenuItem mPacketContextIgnoreMenu;
        private System.Windows.Forms.ToolStripMenuItem mPacketContextNameLabel;
        private System.Windows.Forms.ToolStripSeparator mPacketContextSeparator;
        private System.Windows.Forms.ToolStripMenuItem mViewCommonScriptMenu;
        private System.Windows.Forms.ToolStripSeparator mViewSeparator2Menu;
        private System.Windows.Forms.ToolStripMenuItem mFileExportMenu;
        private System.Windows.Forms.SaveFileDialog mExportDialog;
        private System.Windows.Forms.ToolStripSeparator mViewSeparator3Menu;
        private System.Windows.Forms.ToolStripSeparator mFileSeparatorMenu;
		private System.Windows.Forms.ToolStripMenuItem sessionInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendpropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recvpropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLoggedPacketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePacketFromSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisPacketOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem allBeforeThisOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAfterThisOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyVisibleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem1;
        private DoubleBufferedListView mPacketList;
        private System.Windows.Forms.ToolStripMenuItem addPacketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 忽略列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制数据到剪贴板ToolStripMenuItem;
        //private BrightIdeasSoftware.OLVColumn mTimestampColumn;
        //private BrightIdeasSoftware.OLVColumn mDirectionColumn;
        //private BrightIdeasSoftware.OLVColumn mLengthColumn;
        //private BrightIdeasSoftware.OLVColumn mOpcodeColumn;
        //private BrightIdeasSoftware.OLVColumn mNameColumn;
        //private BrightIdeasSoftware.OLVColumn Index;
    }
}
