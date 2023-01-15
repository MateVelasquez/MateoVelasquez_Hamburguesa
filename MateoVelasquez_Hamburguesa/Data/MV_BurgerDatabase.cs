using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MateoVelasquez_Hamburguesa.Models;
using SQLite;

namespace MateoVelasquez_Hamburguesa.Data
{
    public class MV_BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;

        public MV_BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<MV_Burger>();
        }
        public int AddNewBurger(MV_Burger burger)
        {
            Init();
            int result = conn.Insert(burger);
            return result;
        }
        public List<MV_Burger> GetAllBurgers()
        {
            Init();
            List<MV_Burger> burgers = conn.Table<MV_Burger>().ToList();
            return burgers;
        }
    }
}
