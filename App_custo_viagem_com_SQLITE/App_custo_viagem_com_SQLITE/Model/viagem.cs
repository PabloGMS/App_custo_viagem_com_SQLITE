using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App_custo_viagem_com_SQLITE.Model
{
    public class viagem
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
    }
}
