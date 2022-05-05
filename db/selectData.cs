using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Program.db 
{
    class selectData
    {
        readonly Connection conn = new Connection();
        
        public bool SelectData(string userInsert, string passInsert)
        {
            try
            {
                Connection.DataSource();
                conn.connOpen();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = ("SELECT * FROM users WHERE (login, password) = (@name, @pass)");
                command.Parameters.AddWithValue("@name", userInsert);
                command.Parameters.AddWithValue("@pass", Encrypt.HashString(passInsert));


                command.Connection = Connection.connMaster;
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    FormMain.DataUser.login = reader["login"].ToString();
                    FormMain.DataUser.registred = reader["registred"].ToString();
                    FormMain.DataUser.levelAcces = (int)(reader["positionLevel"]);
                    FormMain.DataUser.name = reader["name"].ToString();
                    FormMain.DataUser.img = (byte[])reader["image"];
                    FormMain.DataUser.surname = reader["surname"].ToString();
                    FormMain.DataUser.email = reader["email"].ToString();
                    FormMain.DataUser.phone = (int)(reader["phone"]);

                    conn.connClose();
                    return true;
                }
                System.Windows.Forms.MessageBox.Show("Error", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                conn.connClose();
            }
        }
    }
}
