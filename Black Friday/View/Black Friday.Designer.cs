namespace Black_Friday
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.termeket_DGV = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_BTN = new System.Windows.Forms.Button();
            this.Tudnivalok_BTN = new System.Windows.Forms.Button();
            this.akcio_CheckBox = new System.Windows.Forms.CheckBox();
            this.Keres_BTN = new System.Windows.Forms.Button();
            this.Keres_TXB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.termeket_DGV)).BeginInit();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.termeket_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.termeket_DGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.termeket_DGV.Location = new System.Drawing.Point(191, 163);
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
            this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
            // 
            // Tudnivalok_BTN
            // 
            this.Tudnivalok_BTN.Location = new System.Drawing.Point(314, 27);
            this.Tudnivalok_BTN.Name = "Tudnivalok_BTN";
            this.Tudnivalok_BTN.Size = new System.Drawing.Size(75, 42);
            this.Tudnivalok_BTN.TabIndex = 4;
            this.Tudnivalok_BTN.Text = "Tudni valók";
            this.Tudnivalok_BTN.UseVisualStyleBackColor = true;
            this.Tudnivalok_BTN.Click += new System.EventHandler(this.Modosit_BTN_Click);
            // 
            // akcio_CheckBox
            // 
            this.akcio_CheckBox.AutoSize = true;
            this.akcio_CheckBox.Location = new System.Drawing.Point(354, 140);
            this.akcio_CheckBox.Name = "akcio_CheckBox";
            this.akcio_CheckBox.Size = new System.Drawing.Size(70, 17);
            this.akcio_CheckBox.TabIndex = 5;
            this.akcio_CheckBox.Text = "Akciós ár";
            this.akcio_CheckBox.UseVisualStyleBackColor = true;
            this.akcio_CheckBox.CheckedChanged += new System.EventHandler(this.akcio_CheckBox_CheckedChanged);
            // 
            // Keres_BTN
            // 
            this.Keres_BTN.Location = new System.Drawing.Point(434, 100);
            this.Keres_BTN.Name = "Keres_BTN";
            this.Keres_BTN.Size = new System.Drawing.Size(59, 20);
            this.Keres_BTN.TabIndex = 6;
            this.Keres_BTN.Text = "Keresés";
            this.Keres_BTN.UseVisualStyleBackColor = true;
            this.Keres_BTN.Click += new System.EventHandler(this.Keres_BTN_Click);
            // 
            // Keres_TXB
            // 
            this.Keres_TXB.BackColor = System.Drawing.Color.White;
            this.Keres_TXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Keres_TXB.Location = new System.Drawing.Point(314, 100);
            this.Keres_TXB.Name = "Keres_TXB";
            this.Keres_TXB.Size = new System.Drawing.Size(114, 20);
            this.Keres_TXB.TabIndex = 7;
            this.Keres_TXB.Text = "Keresés....";
            this.Keres_TXB.Enter += new System.EventHandler(this.Keres_TXB_Enter);
            this.Keres_TXB.Leave += new System.EventHandler(this.Keres_TXB_Leave);
            // 
            // BlackFriday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Keres_TXB);
            this.Controls.Add(this.Keres_BTN);
            this.Controls.Add(this.akcio_CheckBox);
            this.Controls.Add(this.Tudnivalok_BTN);
            this.Controls.Add(this.Add_BTN);
            this.Controls.Add(this.termeket_DGV);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "BlackFriday";
            this.Text = "Black friday";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.termeket_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView termeket_DGV;
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
        private System.Windows.Forms.Button Tudnivalok_BTN;
        private System.Windows.Forms.CheckBox akcio_CheckBox;
        private System.Windows.Forms.Button Keres_BTN;
        private System.Windows.Forms.TextBox Keres_TXB;
    }
}

