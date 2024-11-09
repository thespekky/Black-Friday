namespace Black_Friday.View
{
    partial class Modositas
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
            this.label1 = new System.Windows.Forms.Label();
            this.nev_TXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gyarto_TXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ar_NUM = new System.Windows.Forms.NumericUpDown();
            this.Szorzo_NUM = new System.Windows.Forms.NumericUpDown();
            this.Modosit_BTN = new System.Windows.Forms.Button();
            this.Megse_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ar_NUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szorzo_NUM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nev_TXB
            // 
            this.nev_TXB.Location = new System.Drawing.Point(85, 31);
            this.nev_TXB.Name = "nev_TXB";
            this.nev_TXB.Size = new System.Drawing.Size(100, 20);
            this.nev_TXB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gyártó";
            // 
            // gyarto_TXB
            // 
            this.gyarto_TXB.Location = new System.Drawing.Point(85, 60);
            this.gyarto_TXB.Name = "gyarto_TXB";
            this.gyarto_TXB.Size = new System.Drawing.Size(100, 20);
            this.gyarto_TXB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Szorzó";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Ar_NUM
            // 
            this.Ar_NUM.Location = new System.Drawing.Point(85, 93);
            this.Ar_NUM.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Ar_NUM.Name = "Ar_NUM";
            this.Ar_NUM.Size = new System.Drawing.Size(120, 20);
            this.Ar_NUM.TabIndex = 8;
            // 
            // Szorzo_NUM
            // 
            this.Szorzo_NUM.Location = new System.Drawing.Point(85, 122);
            this.Szorzo_NUM.Name = "Szorzo_NUM";
            this.Szorzo_NUM.Size = new System.Drawing.Size(120, 20);
            this.Szorzo_NUM.TabIndex = 9;
            // 
            // Modosit_BTN
            // 
            this.Modosit_BTN.Location = new System.Drawing.Point(43, 157);
            this.Modosit_BTN.Name = "Modosit_BTN";
            this.Modosit_BTN.Size = new System.Drawing.Size(79, 31);
            this.Modosit_BTN.TabIndex = 10;
            this.Modosit_BTN.Text = "Módosít";
            this.Modosit_BTN.UseVisualStyleBackColor = true;
            this.Modosit_BTN.Click += new System.EventHandler(this.Modosit_BTN_Click);
            // 
            // Megse_BTN
            // 
            this.Megse_BTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Megse_BTN.Location = new System.Drawing.Point(129, 157);
            this.Megse_BTN.Name = "Megse_BTN";
            this.Megse_BTN.Size = new System.Drawing.Size(76, 30);
            this.Megse_BTN.TabIndex = 11;
            this.Megse_BTN.Text = "Mégse";
            this.Megse_BTN.UseVisualStyleBackColor = true;
            this.Megse_BTN.Click += new System.EventHandler(this.Megse_BTN_Click);
            // 
            // Modositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(277, 219);
            this.ControlBox = false;
            this.Controls.Add(this.Megse_BTN);
            this.Controls.Add(this.Modosit_BTN);
            this.Controls.Add(this.Szorzo_NUM);
            this.Controls.Add(this.Ar_NUM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gyarto_TXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nev_TXB);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(293, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(293, 258);
            this.Name = "Modositas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módosítás";
            this.Load += new System.EventHandler(this.Modositas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ar_NUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szorzo_NUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nev_TXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gyarto_TXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Ar_NUM;
        private System.Windows.Forms.NumericUpDown Szorzo_NUM;
        private System.Windows.Forms.Button Modosit_BTN;
        private System.Windows.Forms.Button Megse_BTN;
    }
}