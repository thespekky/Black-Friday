namespace Black_Friday.View
{
    partial class Hozzaadas
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
            this.Hozzaad_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nev_TXB = new System.Windows.Forms.TextBox();
            this.Gyarto_TXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ar_NUM = new System.Windows.Forms.NumericUpDown();
            this.Szorzo_TXB = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Ar_NUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szorzo_TXB)).BeginInit();
            this.SuspendLayout();
            // 
            // Hozzaad_BTN
            // 
            this.Hozzaad_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hozzaad_BTN.Location = new System.Drawing.Point(153, 205);
            this.Hozzaad_BTN.Name = "Hozzaad_BTN";
            this.Hozzaad_BTN.Size = new System.Drawing.Size(95, 30);
            this.Hozzaad_BTN.TabIndex = 0;
            this.Hozzaad_BTN.Text = "Hozzáadás";
            this.Hozzaad_BTN.UseVisualStyleBackColor = true;
            this.Hozzaad_BTN.Click += new System.EventHandler(this.Hozzaad_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(97, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(97, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gyártó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(97, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ár";
            // 
            // Nev_TXB
            // 
            this.Nev_TXB.Location = new System.Drawing.Point(178, 40);
            this.Nev_TXB.Name = "Nev_TXB";
            this.Nev_TXB.Size = new System.Drawing.Size(100, 26);
            this.Nev_TXB.TabIndex = 4;
            // 
            // Gyarto_TXB
            // 
            this.Gyarto_TXB.Location = new System.Drawing.Point(178, 72);
            this.Gyarto_TXB.Name = "Gyarto_TXB";
            this.Gyarto_TXB.Size = new System.Drawing.Size(100, 26);
            this.Gyarto_TXB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Szorzó";
            // 
            // Ar_NUM
            // 
            this.Ar_NUM.Location = new System.Drawing.Point(178, 102);
            this.Ar_NUM.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Ar_NUM.Name = "Ar_NUM";
            this.Ar_NUM.Size = new System.Drawing.Size(120, 26);
            this.Ar_NUM.TabIndex = 9;
            // 
            // Szorzo_TXB
            // 
            this.Szorzo_TXB.Location = new System.Drawing.Point(178, 134);
            this.Szorzo_TXB.Name = "Szorzo_TXB";
            this.Szorzo_TXB.Size = new System.Drawing.Size(120, 26);
            this.Szorzo_TXB.TabIndex = 10;
            // 
            // Hozzaadas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.Szorzo_TXB);
            this.Controls.Add(this.Ar_NUM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Gyarto_TXB);
            this.Controls.Add(this.Nev_TXB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hozzaad_BTN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Hozzaadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hozzáadás";
            ((System.ComponentModel.ISupportInitialize)(this.Ar_NUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szorzo_TXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hozzaad_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nev_TXB;
        private System.Windows.Forms.TextBox Gyarto_TXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Ar_NUM;
        private System.Windows.Forms.NumericUpDown Szorzo_TXB;
    }
}