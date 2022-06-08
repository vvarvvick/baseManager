using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Program.db
{
    class connectionToBase1
    {
        static string server = "sql11.freemysqlhosting.net;";
        static string port = "3306;";
        static string database = "sql11498483;";
        static string uId = "sql11498483;";
        static string password = "vMMyxj1Q7l;";
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
