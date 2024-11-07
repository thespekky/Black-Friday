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
            this.Akcio_BTN = new System.Windows.Forms.Button();
            this.termeket_DGV = new System.Windows.Forms.DataGridView();
            this.Név = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gyártó = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ár = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.termeket_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Akcio_BTN
            // 
            this.Akcio_BTN.Location = new System.Drawing.Point(336, 28);
            this.Akcio_BTN.Name = "Akcio_BTN";
            this.Akcio_BTN.Size = new System.Drawing.Size(109, 42);
            this.Akcio_BTN.TabIndex = 0;
            this.Akcio_BTN.Text = "Akciós ár";
            this.Akcio_BTN.UseVisualStyleBackColor = true;
            // 
            // termeket_DGV
            // 
            this.termeket_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termeket_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Név,
            this.Gyártó,
            this.Ár});
            this.termeket_DGV.Location = new System.Drawing.Point(212, 85);
            this.termeket_DGV.Name = "termeket_DGV";
            this.termeket_DGV.Size = new System.Drawing.Size(348, 262);
            this.termeket_DGV.TabIndex = 1;
            // 
            // Név
            // 
            this.Név.HeaderText = "Név";
            this.Név.Name = "Név";
            // 
            // Gyártó
            // 
            this.Gyártó.HeaderText = "Gyártó";
            this.Gyártó.Name = "Gyártó";
            // 
            // Ár
            // 
            this.Ár.HeaderText = "Ár";
            this.Ár.Name = "Ár";
            // 
            // BlackFriday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.termeket_DGV);
            this.Controls.Add(this.Akcio_BTN);
            this.Name = "BlackFriday";
            this.Text = "Black friday";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.termeket_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Akcio_BTN;
        private System.Windows.Forms.DataGridView termeket_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Név;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gyártó;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ár;
    }
}

