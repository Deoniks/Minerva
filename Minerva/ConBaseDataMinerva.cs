using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Minerva
{
    class ConBaseDataMinerva
    {
        private SQLiteConnection MinervaConn;

        public void MinervaOpenConnection()
        {
            MinervaConn = new SQLiteConnection("Data Source = Minerva.db");

            if(MinervaConn.State == System.Data.ConnectionState.Closed)
            {
                MinervaConn.Open();
            }
        }

        public void MinervaCloseConection()
        {
            if (MinervaConn.State == System.Data.ConnectionState.Open)
            {
                MinervaConn.Close();
            }
        }

        public SQLiteConnection MinervaGetConnection()
        {
            return MinervaConn;
        }

    }
}
