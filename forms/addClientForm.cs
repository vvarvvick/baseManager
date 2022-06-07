using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Program.db;

namespace Program.forms
{
    public partial class addClientForm : addUserForm
    {
        readonly insertData insData = new insertData();

        public addClientForm()
        {
            InitializeComponent();
            button1.Text = "Add Client";
        }

        protected override void insert()
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            

            if (textBoxLogin.Text.Length < 3 || textBoxPassword.Text.Length < 3)
                MessageBox.Show("Var i Name musza posiadać wiecej niz 3 znaki", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (insData.InsertDataClient(
                textBoxLogin.Text,
                textBoxPassword.Text,
                Int32.Parse(textBoxPosition.Text),
                fecha,
                textBoxName.Text
                ) == true)
                clear();
        }
    }
}
