using Black_Friday.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Friday.DAO
{
    internal interface IDAO
    {
        bool AddItem(Item item);
        bool ChangeItem(string nev, string gyarto, double ar, double szorzo,double akciosar, int index);
        List<Item> Search(string nev);
        bool HasItem(string nev);
        List<Item> getItems();
    }
}
