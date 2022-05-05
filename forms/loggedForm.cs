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
using Microsoft.VisualBasic;
using System.IO;

namespace Program.forms
{
    public partial class loggedForm : Form
    {
        readonly updateData upData = new updateData();

        public loggedForm()
        {
            InitializeComponent();
        }

        private void loggedForm_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(FormMain.DataUser.img);

            labelName.Text = FormMain.DataUser.name;
            labelSurname.Text = FormMain.DataUser.surname;
            labelLogin.Text = FormMain.DataUser.login;
            labelPhone.Text = FormMain.DataUser.phone.ToString();
            labelEmail.Text = FormMain.DataUser.email;
            labelRegistred.Text = FormMain.DataUser.registred;
            pictureBox1.Image = Image.FromStream(ms);

            if (FormMain.DataUser.levelAcces == 1)
                labelLevel.Text = "Pracownik";
            if (FormMain.DataUser.levelAcces == 2)
                labelLevel.Text = "Kierownik";
            if (FormMain.DataUser.levelAcces == 3)
                labelLevel.Text = "Administrator";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormMain.DataUser.name = "";
            FormMain.DataUser.surname="";
            FormMain.DataUser.login="";
            FormMain.DataUser.phone=0;
            FormMain.DataUser.email="";
            FormMain.DataUser.registred=null;
            FormMain.DataUser.levelAcces = 0;
            FormMain.DataUser.img = null;

            (this.Owner as FormMain).userLoged = false;
            (this.Owner as FormMain).ShowButton(FormMain.DataUser.levelAcces);
            (this.Owner as FormMain).iconButtonLogin.Text = "Login";
            (this.Owner as FormMain).Reset();
            (this.Owner as FormMain).iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.Hide();

            MessageBox.Show("Your account has been logged out, Bye", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            string pass = Interaction.InputBox("Input New Password", "Change Password", "");

            if (pass != "" && pass.Length > 3)
                upData.updatePass(FormMain.DataUser.login, pass);
            if (pass.Length < 3 && pass.Length>0)
                MessageBox.Show("Password is invalid or is short!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
