using Black_Friday.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Friday.View
{
    public partial class Modositas : Form
    {
        public string nev { get; set; }
        public string gyarto { get; set; }
        public double ar { get; set; }
        public double szorzo { get; set; }
        private int index { get; set; }



        public Modositas(string nev, string gyarto,double ar,double szorzo,int index)
        {
            this.nev = nev;
            this.gyarto = gyarto;
            this.ar = ar;
            this.szorzo = szorzo;
            this.index = index;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Modositas_Load(object sender, EventArgs e)
        {
            nev_TXB.Text = nev;
            gyarto_TXB.Text = gyarto;
            Ar_NUM.Value = Convert.ToInt32(ar);
            Szorzo_NUM.Value = Convert.ToInt32(szorzo);

        }

        private void Modosit_BTN_Click(object sender, EventArgs e)
        {
            if (nev_TXB.Text == "" || gyarto_TXB.Text == "" || Ar_NUM.Value == 0 || Szorzo_NUM.Value == 0)
            {
                MessageBox.Show("Nincs minden adat megadva", "Figyelem");
                return;
            }
            ItemController.getInstance().changeItem(nev_TXB.Text, gyarto_TXB.Text, Convert.ToInt32(Ar_NUM.Value), Convert.ToInt32(Szorzo_NUM.Value), index);
            this.DialogResult = DialogResult.Yes;
            Close();   
        }

        private void Megse_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
