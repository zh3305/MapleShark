﻿using MapleShark.Tools;

namespace MapleShark
{
    partial class SearchForm
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
            this.mOpcodeCombo = new System.Windows.Forms.ComboBox();
            this.mNextOpcodeButton = new System.Windows.Forms.Button();
            this.mPrevOpcodeButton = new System.Windows.Forms.Button();
            this.mPrevSequenceButton = new System.Windows.Forms.Button();
            this.mNextSequenceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Cb_NoEmpty = new System.Windows.Forms.CheckBox();
            this.Tb_Regx = new MapleShark.Tools.PlaceHolderTextBox();
            this.mSequenceHex = new System.Windows.Forms.HexBox();
            this.SuspendLayout();
            // 
            // mOpcodeCombo
            // 
            this.mOpcodeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mOpcodeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mOpcodeCombo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mOpcodeCombo.FormattingEnabled = true;
            this.mOpcodeCombo.Location = new System.Drawing.Point(3, 3);
            this.mOpcodeCombo.Name = "mOpcodeCombo";
            this.mOpcodeCombo.Size = new System.Drawing.Size(532, 23);
            this.mOpcodeCombo.TabIndex = 4;
            this.mOpcodeCombo.SelectedIndexChanged += new System.EventHandler(this.mOpcodeCombo_SelectedIndexChanged);
            // 
            // mNextOpcodeButton
            // 
            this.mNextOpcodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mNextOpcodeButton.Enabled = false;
            this.mNextOpcodeButton.Location = new System.Drawing.Point(612, 2);
            this.mNextOpcodeButton.Name = "mNextOpcodeButton";
            this.mNextOpcodeButton.Size = new System.Drawing.Size(65, 25);
            this.mNextOpcodeButton.TabIndex = 5;
            this.mNextOpcodeButton.Text = "Next";
            this.mNextOpcodeButton.UseVisualStyleBackColor = true;
            this.mNextOpcodeButton.Click += new System.EventHandler(this.mNextOpcodeButton_Click);
            // 
            // mPrevOpcodeButton
            // 
            this.mPrevOpcodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mPrevOpcodeButton.Enabled = false;
            this.mPrevOpcodeButton.Location = new System.Drawing.Point(541, 2);
            this.mPrevOpcodeButton.Name = "mPrevOpcodeButton";
            this.mPrevOpcodeButton.Size = new System.Drawing.Size(65, 25);
            this.mPrevOpcodeButton.TabIndex = 9;
            this.mPrevOpcodeButton.Text = "Prev";
            this.mPrevOpcodeButton.UseVisualStyleBackColor = true;
            this.mPrevOpcodeButton.Click += new System.EventHandler(this.mPrevOpcodeButton_Click);
            // 
            // mPrevSequenceButton
            // 
            this.mPrevSequenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mPrevSequenceButton.Enabled = false;
            this.mPrevSequenceButton.Location = new System.Drawing.Point(215, 27);
            this.mPrevSequenceButton.Name = "mPrevSequenceButton";
            this.mPrevSequenceButton.Size = new System.Drawing.Size(65, 25);
            this.mPrevSequenceButton.TabIndex = 8;
            this.mPrevSequenceButton.Text = "Prev";
            this.mPrevSequenceButton.UseVisualStyleBackColor = true;
            // 
            // mNextSequenceButton
            // 
            this.mNextSequenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mNextSequenceButton.Enabled = false;
            this.mNextSequenceButton.Location = new System.Drawing.Point(286, 27);
            this.mNextSequenceButton.Name = "mNextSequenceButton";
            this.mNextSequenceButton.Size = new System.Drawing.Size(65, 25);
            this.mNextSequenceButton.TabIndex = 7;
            this.mNextSequenceButton.Text = "Next";
            this.mNextSequenceButton.UseVisualStyleBackColor = true;
            this.mNextSequenceButton.Click += new System.EventHandler(this.mNextSequenceButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(612, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 22);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(545, 26);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 18);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "OnOp";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Cb_NoEmpty
            // 
            this.Cb_NoEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_NoEmpty.AutoSize = true;
            this.Cb_NoEmpty.Location = new System.Drawing.Point(545, 41);
            this.Cb_NoEmpty.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_NoEmpty.Name = "Cb_NoEmpty";
            this.Cb_NoEmpty.Size = new System.Drawing.Size(61, 18);
            this.Cb_NoEmpty.TabIndex = 13;
            this.Cb_NoEmpty.Text = "NoEmy";
            this.Cb_NoEmpty.UseVisualStyleBackColor = true;
            // 
            // Tb_Regx
            // 
            this.Tb_Regx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_Regx.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic);
            this.Tb_Regx.ForeColor = System.Drawing.Color.Gray;
            this.Tb_Regx.Location = new System.Drawing.Point(360, 30);
            this.Tb_Regx.Name = "Tb_Regx";
            this.Tb_Regx.PlaceHolderText = "Regex Search";
            this.Tb_Regx.Size = new System.Drawing.Size(175, 20);
            this.Tb_Regx.TabIndex = 12;
            this.Tb_Regx.Text = "Regex Search";
            // 
            // mSequenceHex
            // 
            this.mSequenceHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mSequenceHex.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSequenceHex.LineInfoForeColor = System.Drawing.Color.Empty;
            this.mSequenceHex.Location = new System.Drawing.Point(3, 30);
            this.mSequenceHex.Name = "mSequenceHex";
            this.mSequenceHex.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.mSequenceHex.Size = new System.Drawing.Size(206, 20);
            this.mSequenceHex.TabIndex = 6;
            this.mSequenceHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mSequenceHex_KeyPress);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 88);
            this.Controls.Add(this.Cb_NoEmpty);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Tb_Regx);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mNextSequenceButton);
            this.Controls.Add(this.mPrevSequenceButton);
            this.Controls.Add(this.mSequenceHex);
            this.Controls.Add(this.mOpcodeCombo);
            this.Controls.Add(this.mPrevOpcodeButton);
            this.Controls.Add(this.mNextOpcodeButton);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HideOnClose = true;
            this.MinimumSize = new System.Drawing.Size(300, 60);
            this.Name = "SearchForm";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockTop;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mOpcodeCombo;
        private System.Windows.Forms.Button mNextOpcodeButton;
        private System.Windows.Forms.HexBox mSequenceHex;
        private System.Windows.Forms.Button mNextSequenceButton;
        private System.Windows.Forms.Button mPrevOpcodeButton;
        private System.Windows.Forms.Button mPrevSequenceButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private PlaceHolderTextBox Tb_Regx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox Cb_NoEmpty;
    }
}