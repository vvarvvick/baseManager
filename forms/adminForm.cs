using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Program.db;

namespace Program.forms
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            adminUsersForm aUForm = new adminUsersForm();
            aUForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            string query = "";
            string path = "";

            if (radioButton1.Checked)
                path = "assortTable";
            if (radioButton2.Checked)
                path = "clientsTable";
            if (radioButton3.Checked)
                path = "ordersTable";
            if (radioButton4.Checked)
                path = "usersTable";

            StreamWriter myFile = new StreamWriter($@"C:\Users\mateu\Desktop\Program\{path}.txt");
            Connection.DataSource();

            if (radioButton1.Checked)
            {
                query = "SELECT * FROM assort";
                myFile.WriteLine(String.Format("id,var,name,category,description"));
            }
            if (radioButton2.Checked)
            {
                query = "SELECT * FROM clients";
                myFile.WriteLine(String.Format("idClient,var,name,nip,registred,description"));
            }
            if (radioButton3.Checked)
            {
                query = "SELECT * FROM orders";
                myFile.WriteLine(String.Format("idOrders,idClient,id,created,description"));
            }       
            if (radioButton4.Checked)
            {
                query = "SELECT * FROM users";
                myFile.WriteLine(String.Format("id,login,password,registred,positionLevel,name,image,surname,email,phone"));
            }
                
            MySqlCommand command = new MySqlCommand(query);
            Connection.DataSource();
            conn.connOpen();
            command.Connection = Connection.connMaster;

            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (radioButton1.Checked)
                        myFile.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}", reader[0], reader[1], reader[2], reader[3], reader[4]));
                    if (radioButton2.Checked)
                        myFile.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]));
                    if (radioButton3.Checked)
                        myFile.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}", reader[0], reader[1], reader[2], reader[3], reader[4]));
                    if (radioButton4.Checked)
                        myFile.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7], reader[8], reader[9]));
                }
                MessageBox.Show("Export Successful!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                reader.Close();
                myFile.Close();
            }
        }
    }
}
