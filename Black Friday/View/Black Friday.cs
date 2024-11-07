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

namespace Black_Friday
{
    public partial class BlackFriday : Form
    {
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
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Akcio_BTN.Location = new Point((BlackFriday.ActiveForm.Width/2)-Akcio_BTN.Width/2, Akcio_BTN.Height);
            termeket_DGV.Location = new Point(((BlackFriday.ActiveForm.Width/2)-termeket_DGV.Width/2), termeket_DGV.Height/2);
        }
    }
}
