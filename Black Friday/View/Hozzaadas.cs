using Black_Friday.Controller;
using Black_Friday.Model;
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
    public partial class Hozzaadas : Form
    {
        public Hozzaadas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Hozzaad_BTN_Click(object sender, EventArgs e)
        {
            
            if(Nev_TXB.Text==""||Gyarto_TXB.Text==""||Ar_NUM.Value==0||Szorzo_TXB.Value==0)
            {
                MessageBox.Show("Nincs minden adat megadva", "Figyelem");
                return;
            }
            if (ItemController.getInstance().HasItem(Nev_TXB.Text))
            {
                MessageBox.Show("Ilyen nevű tárgy létezik már", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ItemController.getInstance().addItem(new Item(Nev_TXB.Text, Gyarto_TXB.Text, Convert.ToInt32(Ar_NUM.Value), Convert.ToInt32(Szorzo_TXB.Value)));
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
