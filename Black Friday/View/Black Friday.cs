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
        private bool akcios = false;
        private int segedtavolsag;
        //kell még a adatbázis
        List<Item> items = new List<Item> ();
        
        public BlackFriday()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Form form2 = new Form();
            List<Item> items = new List<Item> { new Item(),new Item("nev2","gyarto012",100,20)};
            form2.Text = "Valami";
            Button b = new Button();
            Item elem1=null;
            foreach (var item in items)
            {
                if(item.Nev=="nev2")
                {
                    elem1 = item;
                }
               
            }
            MessageBox.Show($"{elem1.Nev}");
            b.BackColor = Color.Red;
            b.Text = "Új gomb";
            b.Width = 100;
            b.Height = 100;
            b.Location = new Point(100, 100);
            b.Show();
            this.Controls.Add(b);
           
            form2.ShowDialog();*/
            segedtavolsag = Modosit_BTN.Location.X - Add_BTN.Location.X;
            items = ItemController.getInstance().GetItems();
           /* items.Add(new Item() );
            items.Add(new Item("nev2", "gyarto012", 100, 20));*/
            
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
            akcio_CheckBox.Location= new Point((BlackFriday.ActiveForm.Width / 2) - akcio_CheckBox.Width / 2, 105); 
            Modosit_BTN.Location= new Point(((BlackFriday.ActiveForm.Width / 2) - (Add_BTN.Width / 2)) + segedtavolsag+45, Add_BTN.Height);
            Add_BTN.Location = new Point(((BlackFriday.ActiveForm.Width / 2) - (Add_BTN.Width / 2))- segedtavolsag-30, Add_BTN.Height);
            termeket_DGV.Location = new Point(((BlackFriday.ActiveForm.Width/2)-termeket_DGV.Width/2), termeket_DGV.Height/2);
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
            MessageBox.Show("Kétszer kell kapcsolni a sor header re", "Felhívás",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);

        }

        private void akcio_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            akcios = !akcios;
            termeket_DGV.Rows.Clear();
            DGVColumnChange();
            LoadData();
        }
    }
}
