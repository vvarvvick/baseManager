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
using System.IO;

namespace Program.forms
{
    public partial class assortmentForm : Form
    {
        readonly Connection conn = new Connection();

        public assortmentForm()
        {
            InitializeComponent();
        }

        private void assortmentForm_Load(object sender, EventArgs e)
        {
            setMenu(FormMain.DataUser.levelAcces);
            FillDGV("");
        }

        protected virtual MySqlCommand commandSelect(string value)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM assort WHERE CONCAT(name, category, description) LIKE '%" + value + "%'");
            return command;
        }

        public void setMenu(int x)
        {
            switch (x)
            {
                case 0:
                    buttonDelete.Visible = false;
                    buttonInsert.Visible = false;
                    buttonUpdate.Visible = false;
                    buttonIMG.Visible = false;
                    break;
                case 1:
                    buttonDelete.Visible = false;
                    buttonInsert.Visible = false;
                    buttonUpdate.Visible = false;
                    buttonIMG.Visible = false;
                    break;
                case 2:
                    buttonDelete.Visible = true;
                    buttonInsert.Visible = true;
                    buttonUpdate.Visible = true;
                    buttonIMG.Visible = true;
                    break;
            }
        }

        public void FillDGV(string valueToSearch)
        {
            MySqlCommand command = commandSelect(valueToSearch);
            Connection.DataSource();
            command.Connection = Connection.connMaster;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable(); adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(opf.FileName);
        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            Connection.DataSource();
            conn.connOpen();
            mcomd.Connection = Connection.connMaster;
            if (mcomd.ExecuteNonQuery() == 1)
                MessageBox.Show(myMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Query Not Executed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            conn.connClose();
        }

        protected virtual void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE assort SET name=@name,category=@cat,description=@desc,image=@img WHERE var=@IDVar");

            command.Parameters.Add("@IDvar", MySqlDbType.VarChar).Value = textBoxVar.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = textBoxCategory.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;

            ExecMyQuery(command, "Data Updated");
            FillDGV("");
        }

        protected virtual void buttonDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM assort WHERE var=@IDvar");

            command.Parameters.Add("@IDvar", MySqlDbType.VarChar).Value = textBoxVar.Text;

            ExecMyQuery(command, "Data Deleted");
            FillDGV("");
            ClearFields();
        }

        public virtual void ClearFields()
        {
            textBoxVar.Text = "";
            textBoxName.Text = "";
            textBoxCategory.Text = "";
            textBoxDesc.Text = "";
            pictureBox1.Image = null;
            textBoxSearch.Text = "";
        }

        protected virtual void dataGridView1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            textBoxVar.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxCategory.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxDesc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBoxSearch.Text);
        }

        protected virtual void buttonInsert_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO assort(var, name, category, description, image) VALUES (@IDvar, @name, @cat, @desc, @img)");

            command.Parameters.Add("@IDvar", MySqlDbType.VarChar).Value = textBoxVar.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = textBoxCategory.Text;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;

            ExecMyQuery(command, "Data Inserted");
            FillDGV("");
        }
    }
}
