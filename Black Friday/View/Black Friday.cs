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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.Text = "Valami";
            Button b = new Button();
            b.BackColor = Color.Red;
            b.Location = new Point(100, 100);
            b.Show();
           
            form2.ShowDialog();
        }
    }
}
