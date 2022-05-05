using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Program.db
{
    class insertData
    {
        readonly Connection con = new Connection();

        public bool InsertData(string userInsert, string passInsert, string dataTimeInsert, string nameInsert, string surnameInsert, string emailInsert, int phoneInsert, int stanowiskoInsert, byte[] img)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand
                {
                    CommandText = "INSERT INTO users(login, password, registred, positionLevel, name, image, surname, email, phone) " +
                    "VALUES(@nameLogin, @pass, @datatime, @position, @nameName, @img, @surname, @email, @phone)"
                };

                command.Parameters.AddWithValue("@nameLogin", userInsert);
                command.Parameters.AddWithValue("@pass", Encrypt.HashString(passInsert));
                command.Parameters.AddWithValue("@datatime", dataTimeInsert);
                command.Parameters.AddWithValue("@position", stanowiskoInsert);
                command.Parameters.AddWithValue("@nameName", nameInsert);
                command.Parameters.AddWithValue("@img", img);
                command.Parameters.AddWithValue("@surname", surnameInsert);
                command.Parameters.AddWithValue("@email", emailInsert);
                command.Parameters.AddWithValue("@phone", phoneInsert);

                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Account created", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                con.connClose();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                con.connClose();
            }
        }

        public bool InsertDataClient(string varInsert, string nameInsert, int nipInsert, string dat, string descInsert)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand
                {
                    CommandText = "INSERT INTO clients(var, name, nip, registred, description) VALUES (@varI, @nameI, @nipI, @registredI, @descriptionI)"
                };

                command.Parameters.AddWithValue("@varI", varInsert);
                command.Parameters.AddWithValue("@nameI", nameInsert);
                command.Parameters.AddWithValue("@nipI", nipInsert);
                command.Parameters.AddWithValue("@registredI", dat);
                command.Parameters.AddWithValue("@descriptionI", descInsert);
   

                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Account created", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                con.connClose();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                con.connClose();
            }
        }
    }
}
