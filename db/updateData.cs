using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Program.db
{
    class updateData
    {
        Connection con = new Connection();

        public bool updatePass(string nameSelect, string passUpdate)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand
                {
                    CommandText = "UPDATE users SET password = @pass WHERE login = @nameLogin"
                };

                command.Parameters.Add("@nameLogin", MySqlDbType.VarChar).Value = nameSelect;
                command.Parameters.Add("@pass", MySqlDbType.VarBinary).Value = Encrypt.HashString(passUpdate);

                command.Connection = Connection.connMaster;
                if (command.ExecuteNonQuery() == 1)
                    System.Windows.Forms.MessageBox.Show("Password Updated", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                else
                    System.Windows.Forms.MessageBox.Show("Error data", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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

        public bool updateDataClient(string id, string name, string nip, string desc)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand
                {
                    CommandText = "UPDATE clients SET name=@nameU, nip=@nipU, description=@descU WHERE idClient = @idU"
                };

                command.Parameters.Add("@idU", MySqlDbType.VarChar).Value = id;
                command.Parameters.Add("@nameU", MySqlDbType.VarBinary).Value = name;
                command.Parameters.Add("@nipU", MySqlDbType.VarBinary).Value = nip;
                command.Parameters.Add("@descU", MySqlDbType.VarBinary).Value = desc;

                command.Connection = Connection.connMaster;
                if (command.ExecuteNonQuery() == 1)
                    System.Windows.Forms.MessageBox.Show("Data Updated", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                else
                    System.Windows.Forms.MessageBox.Show("Error data", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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
