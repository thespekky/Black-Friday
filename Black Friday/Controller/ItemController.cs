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


        public ItemController getInstance()
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
        public bool changeItem(Item oneItem)
        {
            return dao.ChangeItem(oneItem);
        }
        public Item SearchItem(string nev)
        {
            return dao.Search(nev);
        }
    }
}
