using Black_Friday.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Friday.Controller
{
    internal class DAOController
    {
        List<Item>items=new List<Item> { new Item(), new Item("nev2", "gyarto012", 100, 20) };
        public bool AddItem(Item item)
        {
            return true;
        }
        public bool ChangeItem(string nev, string gyarto, int ar, int szorzo, int index)
        {
            Item item=new Item(nev,gyarto,ar,szorzo);
            items[index]=item;
            return true;
        }
        public Item Search(string nev)
        {
            return new Item();
        }
        public List<Item> getItems() {
            return items;
        }
    }
}
