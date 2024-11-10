using Black_Friday.Controller;
using Black_Friday.Model;
using Black_Friday.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Friday
{
    public partial class BlackFriday : Form
    {
        private bool akcios { get; set; }
        private int segedTavolsag { get; set; }
        private int keresesTavolsag { get; set; }
        //kell még a adatbázis
        List<Item> items = new List<Item> ();
        
        public BlackFriday()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            akcios=false;
            keresesTavolsag=Keres_TXB.Location.X-Keres_BTN.Location.X;
            segedTavolsag = Tudnivalok_BTN.Location.X - Add_BTN.Location.X;
            items = ItemController.getInstance().GetItems();
            
            LoadData();
           
        }
        private void LoadData()
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (akcios)
                {
                    termeket_DGV.Rows.Add(items[i].getDiscountedDatas());
                }
                else
                {
                    termeket_DGV.Rows.Add(items[i].getDatas());

                }

            }
        }
        private void DGVColumnChange()
        {
            if (akcios)
            {
                termeket_DGV.Columns.Clear();
                termeket_DGV.Columns.Add("nev", "Név");
                termeket_DGV.Columns.Add("gyarto", "Gyártó");
                termeket_DGV.Columns.Add("ar", "Ár");
                termeket_DGV.Columns.Add("ar", "Akciós ár");
            }
            else
            {
                termeket_DGV.Columns.Clear();
                termeket_DGV.Columns.Add("nev", "Név");
                termeket_DGV.Columns.Add("gyarto", "Gyártó");
                termeket_DGV.Columns.Add("ar", "Ár");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            akcio_CheckBox.Location= new Point((BlackFriday.ActiveForm.Width / 2) - akcio_CheckBox.Width / 2, akcio_CheckBox.Location.Y); 
            Tudnivalok_BTN.Location= new Point(((BlackFriday.ActiveForm.Width / 2) - (Add_BTN.Width / 2)) + segedTavolsag+45, Add_BTN.Location.Y);
            Add_BTN.Location = new Point(((BlackFriday.ActiveForm.Width / 2) - (Add_BTN.Width / 2))- segedTavolsag-30, Add_BTN.Location.Y);
            termeket_DGV.Location = new Point(((BlackFriday.ActiveForm.Width/2)-termeket_DGV.Width/2), termeket_DGV.Location.Y);
            Keres_TXB.Location = new Point((BlackFriday.ActiveForm.Width / 2) - (Keres_TXB.Width / 2)+ keresesTavolsag+94, Keres_TXB.Location.Y);
            Keres_BTN.Location = new Point((BlackFriday.ActiveForm.Width / 2) - (Keres_BTN.Width / 2) - keresesTavolsag - 50, Keres_BTN.Location.Y);
        }

        private void Akcio_BTN_Click(object sender, EventArgs e)
        {
            
        }

        private void termeket_DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void termeket_DGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Modositas ModositasFrom = new Modositas(items[e.RowIndex].Nev, items[e.RowIndex].Gyarto, items[e.RowIndex].Ar, items[e.RowIndex].Szorzo,e.RowIndex);
            DialogResult result= ModositasFrom.ShowDialog();
            if(result==DialogResult.Yes)
            {
                termeket_DGV.Rows.Clear();
                LoadData();
            }
            
        }

        private void Modosit_BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kétszer kell kapcsolni a sor header re ha módosítani szeretne.\n\n A szűrőt úgy lehet kitörölni hogy rákapcsol a keresés gombra még egyszer.", "Felhívás",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

        }

        private void akcio_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            akcios = !akcios;
            termeket_DGV.Rows.Clear();
            DGVColumnChange();
            LoadData();
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            Hozzaadas HozzaadasForm = new Hozzaadas();
            DialogResult result = HozzaadasForm.ShowDialog();
            if(result==DialogResult.OK)
            {
                termeket_DGV.Rows.Clear();
                LoadData();
            }

        }

        private void Keres_BTN_Click(object sender, EventArgs e)
        {
            if(Keres_TXB.Text=="Keresés....")
            {
                items = ItemController.getInstance().GetItems();
                termeket_DGV.Rows.Clear();
                LoadData();
            }
            else
            {
                items = ItemController.getInstance().SearchItem(Keres_TXB.Text);
                termeket_DGV.Rows.Clear();
                LoadData();
            }
            Keres_TXB.Text = "Keresés....";
        }

        private void Keres_TXB_Enter(object sender, EventArgs e)
        {
            Keres_TXB.Text = "";
        }

        private void Keres_TXB_Leave(object sender, EventArgs e)
        {
            
        }

        private void Tudnivalok_BTN_Click(object sender, EventArgs e)
        {

        }
    }
}
