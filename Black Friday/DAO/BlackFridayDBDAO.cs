using Black_Friday.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Friday.DAO
{
    internal class BlackFridayDBDAO : IDAO
    {
        private static readonly string s_connectionString = @"Data Source=db\blackFridayWeek.db";
        public bool AddItem(Item item)
        {
            if (item == null) return false;
            using (SQLiteConnection conn = new SQLiteConnection(s_connectionString))
            { 
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO blackfriday" +
                        " (nev,gyarto,ar,szorzo,akciosar)"+
                        " VALUES (@Nev, @Gyarto, @Ar, @Szorzo,@Akciosar)";
                    cmd.Parameters.Add("Nev", System.Data.DbType.String).Value=item.Nev;
                    cmd.Parameters.Add("Gyarto", System.Data.DbType.String).Value = item.Gyarto;
                    cmd.Parameters.Add("Ar", System.Data.DbType.Double).Value = item.Ar;
                    cmd.Parameters.Add("Szorzo", System.Data.DbType.Double).Value = item.Szorzo;
                    cmd.Parameters.Add("Akciosar", System.Data.DbType.Double).Value = item.Akcios_ar;
                    int row=cmd.ExecuteNonQuery();
                    if (row != 1)
                    {
                        return false;
                    }  
                }
            }
            return true;
        }

        public bool ChangeItem(string nev, string gyarto, double ar, double szorzo,double akciosar, int index)
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(s_connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                   
                    cmd.CommandText = "UPDATE blackfriday" +
                        " SET nev=@Nev, gyarto=@Gyarto,ar=@Ar,szorzo=@Szorzo,akciosar=@Akciosar" +
                        " WHERE id=@Id";
                    cmd.Parameters.Add("Nev", System.Data.DbType.String).Value = nev;
                    cmd.Parameters.Add("Gyarto", System.Data.DbType.String).Value = gyarto;
                    cmd.Parameters.Add("Ar", System.Data.DbType.Double).Value = ar;
                    cmd.Parameters.Add("Szorzo", System.Data.DbType.Double).Value = szorzo;
                    cmd.Parameters.Add("Akciosar", System.Data.DbType.Double).Value = akciosar;
                    cmd.Parameters.Add("Id", System.Data.DbType.Int32).Value = index;
                    int row = cmd.ExecuteNonQuery();
                    if (row != 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public List<Item> getItems()
        {
            List<Item> items = new List<Item>();
            using(SQLiteConnection conn=new SQLiteConnection(s_connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM blackfriday";
                    using(SQLiteDataReader reader=cmd.ExecuteReader())
                    {
                        items = ReadItemsFromReader(reader);
                    }
                }
            }
            return items;
        }

        private List<Item> ReadItemsFromReader(SQLiteDataReader reader)
        {
            List<Item> items = new List<Item>();
            while(reader.Read())
            {
                Item egyitem=new Item();
                egyitem.Nev = reader.GetString(reader.GetOrdinal("nev"));
                egyitem.Gyarto = reader.GetString(reader.GetOrdinal("gyarto"));
                egyitem.Ar = reader.GetDouble(reader.GetOrdinal("ar"));
                egyitem.Szorzo = reader.GetDouble(reader.GetOrdinal("szorzo"));
                egyitem.Akcios_ar = reader.GetDouble(reader.GetOrdinal("akciosar"));
                items.Add(egyitem);
            }
            return items;
        }

        public bool HasItem(string nev)
        {
            if (nev == null) return false;
            using (SQLiteConnection conn = new SQLiteConnection(s_connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    
                    cmd.CommandText = "SELECT * FROM blackfriday" +
                        " WHERE nev= @Nev";
                    cmd.Parameters.Add("Nev", System.Data.DbType.String).Value = nev;
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public List<Item> Search(string nev)
        {
            List<Item> items = new List<Item>();
            using (SQLiteConnection conn = new SQLiteConnection(s_connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                        cmd.CommandText = "SELECT * FROM blackfriday";
                    
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        List<Item> helper = new List<Item>();
                        helper = ReadItemsFromReader(reader);
                        for (int i = 0; i < helper.Count; i++)
                        {
                            if (helper[i].Nev.Contains(nev))
                            {
                                items.Add(helper[i]);
                            }
                        }
                    }
                }
            }
            return items;
        }
    }
}
