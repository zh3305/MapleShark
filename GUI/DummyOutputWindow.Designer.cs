
namespace MapleShark
{
    partial class DummyOutputWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DummyOutputWindow));
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.mTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Items.AddRange(new object[] {
            "Build"});
            this.comboBox.Location = new System.Drawing.Point(0, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(674, 20);
            this.comboBox.TabIndex = 1;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // mTextBox
            // 
            this.mTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTextBox.Location = new System.Drawing.Point(0, 22);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(674, 217);
            this.mTextBox.TabIndex = 2;
            this.mTextBox.Text = "\n---------------------- Done ----------------------\n";
            this.mTextBox.WordWrap = false;
            // 
            // DummyOutputWindow
            // 
            this.ClientSize = new System.Drawing.Size(674, 241);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.comboBox);
            this.Font = new System.Drawing.Font("ËÎÌו", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DummyOutputWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockBottomAutoHide;
            this.TabText = "Output";
            this.Text = "Output";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DummyOutputWindow_FormClosing);
            this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.RichTextBox mTextBox;
    }
}