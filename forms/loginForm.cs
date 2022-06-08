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

namespace Program.forms
{
    public partial class loginForm : Form
    {
        readonly selectData selData = new selectData();
        
        public loginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length < 3 || textBoxPassword.Text.Length < 3)
            {
                MessageBox.Show("Username or Password is invalid or is short!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (selData.SelectData(textBoxLogin.Text, textBoxPassword.Text) == true)
                {
                    (this.Owner as FormMain).userLoged = true;
                    (this.Owner as FormMain).ShowButton(FormMain.DataUser.levelAcces);
                    (this.Owner as FormMain).iconButtonLogin.Text = "Account";
                    this.Hide();
                    (this.Owner as FormMain).Reset();
                    (this.Owner as FormMain).iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.User;
                    MessageBox.Show("Hi " + FormMain.DataUser.name, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                }
            }
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '*';
        }
    }
}
