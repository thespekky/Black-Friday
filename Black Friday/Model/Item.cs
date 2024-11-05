using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Friday.Model
{
    internal class Item
    {
        private string Nev { get; set; }
        private string Gyarto { get; set; }
        private int Ar { get; set; }
        private int Szorzo { get; set; }
        private int Akcios_ar { get; set; }

        public Item(string nev,string gyaroto,int ar,int szorzo)
        {
            this.Nev = nev;
            this.Gyarto = gyaroto;
            this.Ar = ar;
            if (szorzo <= 100 && szorzo <= 1)
            {
                this.Szorzo = szorzo;
                this.Akcios_ar = (this.Ar * this.Szorzo) / 100;
            }
        }


    }
}
