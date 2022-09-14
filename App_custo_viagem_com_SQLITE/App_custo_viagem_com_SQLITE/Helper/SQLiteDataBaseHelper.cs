using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using App_custo_viagem_com_SQLITE.Model;
using System.Threading.Tasks;

namespace App_custo_viagem_com_SQLITE.Helper
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _db;

        public SQLiteDataBaseHelper(string dbPath)
        {

            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<viagem>().Wait();
            _db.CreateTableAsync<pedagio>().Wait();
           
        }
        public Task<List<viagem>> GetAll()
        {
            return _db.Table<viagem>().OrderByDescending(i => i.Id).ToListAsync();
        }

    }
}
