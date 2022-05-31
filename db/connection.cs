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
        static string server = "sql11.freemysqlhosting.net;";
        static string port = "3306;";
        static string database = "sql11496640;";
        static string uId = "sql11496640;";
        static string password = "NVQalehX4Q;";
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
