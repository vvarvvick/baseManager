using Program.db;
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

namespace Program.forms
{
    public partial class addOrderPanelForm : Form
    {
        readonly Connection con = new Connection();

        public addOrderPanelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertDataOrder();
        }

        public bool InsertDataOrder()
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand
                {
                    CommandText = "INSERT INTO orders(idClient, id, created, description) VALUES (@idCO, @idAO, @datO, @descO)"
                };

                command.Parameters.AddWithValue("@idCO", textBoxIdClient.Text);
                command.Parameters.AddWithValue("@idAO", textBoxIdAssort.Text);
                command.Parameters.AddWithValue("@datO", fecha);
                command.Parameters.AddWithValue("@descO", textBoxDesc.Text);

                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Order Added", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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
