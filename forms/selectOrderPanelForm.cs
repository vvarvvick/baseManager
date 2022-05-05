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
using Program.db;

namespace Program.forms
{
    public partial class selectOrderPanelForm : Form
    {
        readonly Connection con = new Connection();

        public selectOrderPanelForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FillDGV(textBoxClient.Text);
        }

        public void FillDGV(string value)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM orders WHERE idClient = @idC");
            command.Parameters.AddWithValue("@idC", value);

            Connection.DataSource();
            command.Connection = Connection.connMaster;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable(); adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
