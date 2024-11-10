using Black_Friday.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Friday.Controller
{
    internal class DAOInMemory
    {
        List<Item>items=new List<Item> { new Item(), new Item("nev2", "gyarto012", 100, 20) };
        public bool AddItem(Item item)
        {
            items.Add(item);
            return true;
        }
        public bool ChangeItem(string nev, string gyarto, int ar, int szorzo, int index)
        {
            Item item=new Item(nev,gyarto,ar,szorzo);
            items[index]=item;
            return true;
        }
        public List<Item> Search(string nev)
        {
            List <Item> searchedItems = new List <Item>();
            for (int i = 0;i<items.Count;i++)
            {
                if (items[i].Nev.Contains(nev))
                {
                    searchedItems.Add(items[i]);
                }
            }
            return searchedItems;
        }
        public bool HasItem(string nev)
        {
            foreach (var item in items)
            {
                if(item.Nev==nev)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Item> getItems() {
            return items;
        }
    }
}
