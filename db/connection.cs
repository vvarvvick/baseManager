using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Program.db
{
    class Connection
    {
        static readonly string server = "mysql-78080-0.cloudclusters.net;";
        static string port = "19755;";
        static readonly string database = "base;";
        static readonly string uId = "admin;";
        static readonly string password = "44ivq5hD;";
        public static MySqlConnection connMaster;

        public static MySqlConnection DataSource()
        {
            connMaster = new MySqlConnection($"server={server} port={port} database={database} Uid={uId} password={password}");
            return connMaster;
        }

        public void connOpen()
        {
            DataSource();
            connMaster.Open();
        }

        public void connClose()
        {
            DataSource();
            connMaster.Close();
        }
    }
}
