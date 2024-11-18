using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Friday.Model
{
    internal class Item
    {
        public string Nev { get; set; }
        public string Gyarto { get; set; }
        public double Ar { get; set; }
        public double Szorzo { get; set; }
        public double Akcios_ar { get; set; }

        public Item(string nev,string gyaroto,int ar,int szorzo)
        {
            this.Nev = nev;
            this.Gyarto = gyaroto;
            this.Ar = ar;
            if (szorzo <= 100 && szorzo >= 1)
            { 
                this.Szorzo = szorzo;
                this.Akcios_ar = this.Ar - (this.Ar*(this.Szorzo / 100));
            }
        }
        public Item()
        {
            this.Nev = "ures";
            this.Gyarto = "ures";
            this.Ar = 0;
            this.Szorzo = 0;
            this.Akcios_ar = 0;
        }
        public object[] getDatas()
        {
            return new object[]{
                this.Nev,
                this.Gyarto,
                this.Ar
            };
        }
        public object[] getDiscountedDatas()
        {
            return new object[]{
                this.Nev,
                this.Gyarto,
                 this.Ar+(this.Ar*this.Szorzo/100),
                this.Akcios_ar,
            };
        }
    }
}
