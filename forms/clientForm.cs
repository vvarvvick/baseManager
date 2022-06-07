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
    public partial class clientForm : Form
    {
        string id;
        string var;
        string name;
        string nip;
        string reg;
        string description;

        readonly Connection conn = new Connection();

        public clientForm()
        {
            InitializeComponent();
            FillDGV("");
        }

        public void FillDGV(string value)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM clients WHERE CONCAT(var, name, description, nip) LIKE '%" + value + "%'");
            Connection.DataSource();
            command.Connection = Connection.connMaster;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable(); 
            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            addClientForm aCForm = new addClientForm();
            aCForm.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            updateClientForm uCForm = new updateClientForm();
            uCForm.Show(id,var,name,nip,reg,description);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to delete data??", "Delete Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(res == DialogResult.OK)
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM clients WHERE idClient=@idD");
                command.Parameters.Add("@idD", MySqlDbType.VarChar).Value = id;

                Connection.DataSource();
                conn.connOpen();
                command.Connection = Connection.connMaster;
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Data Deleted", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Query Not Executed");
                conn.connClose();

                FillDGV("");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            nip = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            reg = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            description = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBox1.Text);
        }
    }
}
