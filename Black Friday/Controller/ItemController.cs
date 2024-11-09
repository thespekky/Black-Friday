using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Black_Friday.Model;

namespace Black_Friday.Controller
{
    internal class ItemController
    {
        private static ItemController instance;
        private static DAOController dao;


        public static ItemController getInstance()
        {
            if(instance==null)
            {
                instance = new ItemController();
            }
            return instance;
        }
        private ItemController()
        {
            dao = new DAOController();
        }
        public bool addItem(Item oneItem)
        {
            return dao.AddItem(oneItem);
        }
        public bool changeItem(string nev,string gyarto,int ar,int szorzo,int index)
        {
            return dao.ChangeItem( nev,  gyarto,  ar,  szorzo,  index);
        }
        public Item SearchItem(string nev)
        {
            return dao.Search(nev);
        }
        public bool HasItem(string nev)
        {
            return dao.HasItem(nev);
        }
        public List<Item> GetItems() {
            return dao.getItems();
        }
    }
}
