using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Program.db;

namespace Program.forms
{
    public partial class adminUsersForm : assortmentForm
    {
        readonly updateData upData = new updateData();

        public adminUsersForm()
        {
            InitializeComponent();
        }

        protected override MySqlCommand commandSelect(string value)
        {
            MySqlCommand command = new MySqlCommand("SELECT id, login, registred, positionLevel, name, image, surname, email, phone FROM users");
            return command;
        }

        protected override void dataGridView1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxLogin.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxRegistred.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxVar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxCategory.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxDesc.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxSearch.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            if (textBoxLogin.Text != "")
                buttonPassword.Enabled = true;
        }

        public override void ClearFields()
        {
            textBoxVar.Text = "";
            textBoxName.Text = "";
            textBoxCategory.Text = "";
            textBoxDesc.Text = "";
            pictureBox1.Image = null;
            textBoxSearch.Text = "";
            textBoxID.Text = "";
            textBoxLogin.Text = "";
            textBoxRegistred.Text = "";
            buttonPassword.Enabled = false;
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            string pass = Interaction.InputBox("Input New Password", "Change Password", "");

            if (pass != "" && pass.Length > 3)
                upData.updatePass(textBoxLogin.Text, pass);
            if (pass.Length < 3 && pass.Length > 0)
                MessageBox.Show("Password is invalid or is short!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected override void buttonInsert_Click(object sender, EventArgs e)
        {
            addUserForm aUForm = new addUserForm();
            aUForm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ClearFields();
            FillDGV("");
        }

        protected override void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("UPDATE users SET positionLevel =@positionS, name =@nameS, image =@imgS, surname =@surnameS, email =@emailS, phone =@phoneS WHERE login=@loginS");

            command.Parameters.Add("@loginS", MySqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@positionS", MySqlDbType.Int32).Value = Int32.Parse(textBoxCategory.Text);
            command.Parameters.Add("@nameS", MySqlDbType.VarChar).Value = textBoxVar.Text;
            command.Parameters.Add("@imgS", MySqlDbType.LongBlob).Value = img;
            command.Parameters.Add("@surnameS", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@emailS", MySqlDbType.VarChar).Value = textBoxDesc.Text;
            command.Parameters.Add("@phoneS", MySqlDbType.Int32).Value = Int32.Parse(textBoxSearch.Text);

            ExecMyQuery(command, "Data Updated");
            FillDGV("");
        }

        protected override void buttonDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE login=@loginS");

            command.Parameters.Add("@loginS", MySqlDbType.VarChar).Value = textBoxLogin.Text;

            ExecMyQuery(command, "Data Deleted");
            FillDGV("");
            ClearFields();
        }
    }
}
