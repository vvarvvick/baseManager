using Program.db;
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

namespace Program.forms
{
    public partial class addUserForm : Form
    {
        readonly insertData insData = new insertData();

        public addUserForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void clear()
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxPosition.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(opf.FileName);
        }

        protected virtual void insert()
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            if (textBoxLogin.Text.Length < 3 || textBoxPassword.Text.Length < 3)
                MessageBox.Show("Username or Password is invalid or is short!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (insData.InsertData(
                textBoxLogin.Text,
                textBoxPassword.Text,
                fecha,
                textBoxName.Text,
                textBoxSurname.Text,
                textBoxEmail.Text,
                Int32.Parse(textBoxPhone.Text),
                Int32.Parse(textBoxPosition.Text),
                img
                ) == true)
                clear();
        }
    }
}
