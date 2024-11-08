﻿namespace Black_Friday
{
    partial class BlackFriday
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.termeket_DGV = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_BTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.akciósÁrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hozzáadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Modosit_BTN = new System.Windows.Forms.Button();
            this.akcio_CheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.termeket_DGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // termeket_DGV
            // 
            this.termeket_DGV.AllowUserToAddRows = false;
            this.termeket_DGV.AllowUserToDeleteRows = false;
            this.termeket_DGV.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.termeket_DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.termeket_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termeket_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.gyarto,
            this.ar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.termeket_DGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.termeket_DGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.termeket_DGV.Location = new System.Drawing.Point(191, 98);
            this.termeket_DGV.Name = "termeket_DGV";
            this.termeket_DGV.ReadOnly = true;
            this.termeket_DGV.Size = new System.Drawing.Size(466, 262);
            this.termeket_DGV.TabIndex = 1;
            this.termeket_DGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.termeket_DGV_RowEnter);
            this.termeket_DGV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.termeket_DGV_RowHeaderMouseDoubleClick);
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // gyarto
            // 
            this.gyarto.HeaderText = "Gyártó";
            this.gyarto.Name = "gyarto";
            this.gyarto.ReadOnly = true;
            // 
            // ar
            // 
            this.ar.HeaderText = "Ár";
            this.ar.Name = "ar";
            this.ar.ReadOnly = true;
            // 
            // Add_BTN
            // 
            this.Add_BTN.Location = new System.Drawing.Point(395, 27);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(98, 42);
            this.Add_BTN.TabIndex = 2;
            this.Add_BTN.Text = "Hozzáadás";
            this.Add_BTN.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akciósÁrToolStripMenuItem,
            this.hozzáadásToolStripMenuItem,
            this.keresésToolStripMenuItem,
            this.módosításToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // akciósÁrToolStripMenuItem
            // 
            this.akciósÁrToolStripMenuItem.Name = "akciósÁrToolStripMenuItem";
            this.akciósÁrToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.akciósÁrToolStripMenuItem.Text = "Akciós ár";
            // 
            // hozzáadásToolStripMenuItem
            // 
            this.hozzáadásToolStripMenuItem.Name = "hozzáadásToolStripMenuItem";
            this.hozzáadásToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.hozzáadásToolStripMenuItem.Text = "Hozzáadás";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.keresésToolStripMenuItem.Text = "Keresés";
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            // 
            // Modosit_BTN
            // 
            this.Modosit_BTN.Location = new System.Drawing.Point(314, 27);
            this.Modosit_BTN.Name = "Modosit_BTN";
            this.Modosit_BTN.Size = new System.Drawing.Size(75, 42);
            this.Modosit_BTN.TabIndex = 4;
            this.Modosit_BTN.Text = "Módosítás";
            this.Modosit_BTN.UseVisualStyleBackColor = true;
            this.Modosit_BTN.Click += new System.EventHandler(this.Modosit_BTN_Click);
            // 
            // akcio_CheckBox
            // 
            this.akcio_CheckBox.AutoSize = true;
            this.akcio_CheckBox.Location = new System.Drawing.Point(354, 75);
            this.akcio_CheckBox.Name = "akcio_CheckBox";
            this.akcio_CheckBox.Size = new System.Drawing.Size(70, 17);
            this.akcio_CheckBox.TabIndex = 5;
            this.akcio_CheckBox.Text = "Akciós ár";
            this.akcio_CheckBox.UseVisualStyleBackColor = true;
            this.akcio_CheckBox.CheckedChanged += new System.EventHandler(this.akcio_CheckBox_CheckedChanged);
            // 
            // BlackFriday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.akcio_CheckBox);
            this.Controls.Add(this.Modosit_BTN);
            this.Controls.Add(this.Add_BTN);
            this.Controls.Add(this.termeket_DGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BlackFriday";
            this.Text = "Black friday";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.termeket_DGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView termeket_DGV;
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akciósÁrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hozzáadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.Button Modosit_BTN;
        private System.Windows.Forms.CheckBox akcio_CheckBox;
    }
}

