namespace MapleShark.GUI
{
    partial class frmIgnoreOp
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxFilterSimple = new System.Windows.Forms.TextBox();
            this.olvSimple = new BrightIdeasSoftware.ObjectListView();
            this.Ignore = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Outbound = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Opcode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Build = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Locale = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeader11 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeader12 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSimpleCookingColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeader14 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeader15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnHeaderSalaryRate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn34 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvSimple)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.textBoxFilterSimple);
            this.groupBox9.Location = new System.Drawing.Point(544, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(117, 41);
            this.groupBox9.TabIndex = 37;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "过滤器";
            // 
            // textBoxFilterSimple
            // 
            this.textBoxFilterSimple.Location = new System.Drawing.Point(7, 18);
            this.textBoxFilterSimple.Name = "textBoxFilterSimple";
            this.textBoxFilterSimple.Size = new System.Drawing.Size(100, 21);
            this.textBoxFilterSimple.TabIndex = 0;
            this.textBoxFilterSimple.TextChanged += new System.EventHandler(this.textBoxFilterSimple_TextChanged);
            // 
            // olvSimple
            // 
            this.olvSimple.AllColumns.Add(this.Ignore);
            this.olvSimple.AllColumns.Add(this.Outbound);
            this.olvSimple.AllColumns.Add(this.Opcode);
            this.olvSimple.AllColumns.Add(this.pName);
            this.olvSimple.AllColumns.Add(this.Build);
            this.olvSimple.AllColumns.Add(this.Locale);
            this.olvSimple.AllowColumnReorder = true;
            this.olvSimple.AllowDrop = true;
            this.olvSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvSimple.CellEditUseWholeCell = false;
            this.olvSimple.CheckBoxes = true;
            this.olvSimple.CheckedAspectName = "Ignore";
            this.olvSimple.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ignore,
            this.Outbound,
            this.Opcode,
            this.pName,
            this.Build,
            this.Locale});
            this.olvSimple.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSimple.FullRowSelect = true;
            this.olvSimple.HeaderWordWrap = true;
            this.olvSimple.HideSelection = false;
            this.olvSimple.IncludeColumnHeadersInCopy = true;
            this.olvSimple.Location = new System.Drawing.Point(3, 59);
            this.olvSimple.Name = "olvSimple";
            this.olvSimple.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvSimple.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvSimple.OverlayText.BorderWidth = 2F;
            this.olvSimple.OverlayText.Rotation = -20;
            this.olvSimple.OverlayText.Text = "";
            this.olvSimple.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvSimple.ShowCommandMenuOnRightClick = true;
            this.olvSimple.ShowGroups = false;
            this.olvSimple.ShowHeaderInAllViews = false;
            this.olvSimple.ShowItemToolTips = true;
            this.olvSimple.Size = new System.Drawing.Size(666, 288);
            this.olvSimple.SortGroupItemsByPrimaryColumn = false;
            this.olvSimple.TabIndex = 36;
            this.olvSimple.TriStateCheckBoxes = true;
            this.olvSimple.UseAlternatingBackColors = true;
            this.olvSimple.UseCellFormatEvents = true;
            this.olvSimple.UseCompatibleStateImageBehavior = false;
            this.olvSimple.UseFilterIndicator = true;
            this.olvSimple.UseFiltering = true;
            this.olvSimple.UseHotItem = true;
            this.olvSimple.View = System.Windows.Forms.View.Details;
            // 
            // Ignore
            // 
            this.Ignore.AspectName = "Ignore";
            this.Ignore.CheckBoxes = true;
            this.Ignore.Text = "忽略";
            this.Ignore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Outbound
            // 
            this.Outbound.AspectName = "Outbound";
            this.Outbound.AspectToStringFormat = "";
            this.Outbound.Text = "OutIn";
            this.Outbound.Width = 80;
            // 
            // Opcode
            // 
            this.Opcode.AspectName = "Opcode";
            this.Opcode.AspectToStringFormat = "0x{0:X4}";
            this.Opcode.Text = "封包头";
            // 
            // pName
            // 
            this.pName.AspectName = "Name";
            this.pName.Text = "封包类型名称";
            this.pName.Width = 255;
            // 
            // Build
            // 
            this.Build.AspectName = "Build";
            this.Build.Text = "构建";
            // 
            // Locale
            // 
            this.Locale.AspectName = "Locale";
            this.Locale.Text = "地区";
            // 
            // columnHeader11
            // 
            this.columnHeader11.AspectName = "Name";
            this.columnHeader11.DisplayIndex = 0;
            this.columnHeader11.HeaderCheckBox = true;
            this.columnHeader11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.MaximumWidth = 200;
            this.columnHeader11.MinimumWidth = 100;
            this.columnHeader11.Text = "个人";
            this.columnHeader11.ToolTipText = "This is a long tooltip text that should appear when the mouse is over this column" +
    " header but contains absolutely no useful information :)";
            this.columnHeader11.UseInitialLetterForGroup = true;
            this.columnHeader11.Width = 140;
            // 
            // columnHeader12
            // 
            this.columnHeader12.AspectName = "Occupation";
            this.columnHeader12.DisplayIndex = 1;
            this.columnHeader12.Hyperlink = true;
            this.columnHeader12.MaximumWidth = 180;
            this.columnHeader12.MinimumWidth = 50;
            this.columnHeader12.Text = "Occupation";
            this.columnHeader12.Width = 112;
            // 
            // olvSimpleCookingColumn
            // 
            this.olvSimpleCookingColumn.AspectName = "CulinaryRating";
            this.olvSimpleCookingColumn.DisplayIndex = 2;
            this.olvSimpleCookingColumn.HeaderForeColor = System.Drawing.Color.Green;
            this.olvSimpleCookingColumn.Text = "Cooking Skill";
            this.olvSimpleCookingColumn.Width = 74;
            // 
            // columnHeader14
            // 
            this.columnHeader14.AspectName = "YearOfBirth";
            this.columnHeader14.DisplayIndex = 3;
            this.columnHeader14.HeaderForeColor = System.Drawing.Color.Black;
            this.columnHeader14.MaximumWidth = 81;
            this.columnHeader14.MinimumWidth = 81;
            this.columnHeader14.Text = "Year of birth";
            this.columnHeader14.Width = 81;
            // 
            // columnHeader15
            // 
            this.columnHeader15.AspectName = "BirthDate";
            this.columnHeader15.AspectToStringFormat = "{0:d}";
            this.columnHeader15.DisplayIndex = 4;
            this.columnHeader15.Text = "Birthday";
            this.columnHeader15.Width = 121;
            // 
            // columnHeaderSalaryRate
            // 
            this.columnHeaderSalaryRate.AspectName = "GetRate";
            this.columnHeaderSalaryRate.AspectToStringFormat = "{0:C}";
            this.columnHeaderSalaryRate.DisplayIndex = 5;
            this.columnHeaderSalaryRate.IsEditable = false;
            this.columnHeaderSalaryRate.Text = "Hourly Rate";
            this.columnHeaderSalaryRate.Width = 93;
            // 
            // olvColumn34
            // 
            this.olvColumn34.AspectName = "Comments";
            this.olvColumn34.DisplayIndex = 6;
            this.olvColumn34.FillsFreeSpace = true;
            this.olvColumn34.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvColumn34.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.olvColumn34.IsTileViewColumn = true;
            this.olvColumn34.MinimumWidth = 30;
            this.olvColumn34.Text = "Comments";
            this.olvColumn34.ToolTipText = "This is the tool tip for the Comments column. This is configured through the Tool" +
    "TipText property.";
            this.olvColumn34.UseInitialLetterForGroup = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "接收";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "全部";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmIgnoreOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 358);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.olvSimple);
            this.Name = "frmIgnoreOp";
            this.Text = "封包头列表";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvSimple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBoxFilterSimple;
        private BrightIdeasSoftware.ObjectListView olvSimple;
        private BrightIdeasSoftware.OLVColumn columnHeader11;
        private BrightIdeasSoftware.OLVColumn columnHeader12;
        private BrightIdeasSoftware.OLVColumn olvSimpleCookingColumn;
        private BrightIdeasSoftware.OLVColumn columnHeader14;
        private BrightIdeasSoftware.OLVColumn columnHeader15;
        private BrightIdeasSoftware.OLVColumn columnHeaderSalaryRate;
        private BrightIdeasSoftware.OLVColumn olvColumn34;
        private BrightIdeasSoftware.OLVColumn Outbound;
        private BrightIdeasSoftware.OLVColumn Opcode;
        private BrightIdeasSoftware.OLVColumn pName;
        private BrightIdeasSoftware.OLVColumn Build;
        private BrightIdeasSoftware.OLVColumn Locale;
        private BrightIdeasSoftware.OLVColumn Ignore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
