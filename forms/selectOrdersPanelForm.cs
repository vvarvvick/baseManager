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
    public partial class selectOrdersPanelForm : Form
    {
        readonly Connection con = new Connection();

        public selectOrdersPanelForm()
        {
            InitializeComponent();
        }

        private void selectOrdersPanelForm_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        public void FillDGV()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM orders");

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
