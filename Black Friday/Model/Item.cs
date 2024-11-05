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
        private double Akcios_ar { get; set; }

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
        public Item()
        {
            this.Nev = "ures";
            this.Gyarto = "ures";
            this.Ar = 0;
            this.Szorzo = 0;
            this.Akcios_ar = 0;
        }
        public List<string> getValues()
        {
            List<string> items = new List<string>
            {
                Nev,
                Gyarto,
                Ar.ToString(),
                Szorzo.ToString(),
                Akcios_ar.ToString()
            };

            return items;
        }


    }
}
