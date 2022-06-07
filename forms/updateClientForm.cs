using Program.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Program.forms
{
    public partial class updateClientForm : addUserForm
    {
        updateData uData = new updateData();

        public updateClientForm()
        {
            InitializeComponent();
            Show();
            button1.Text = "Update data";
        }

        internal void Show(string id, string var, string name, string nip, string reg, string desc)
        {
            textBoxLogin.Text = id;
            textBoxPassword.Text = var;
            textBoxPosition.Text = name;
            textBoxName.Text = nip;
            textBoxSurname.Text = reg;
            textBoxEmail.Text = desc;
        }

        protected override void insert()
        {
            uData.updateDataClient(
                textBoxLogin.Text,
                textBoxPosition.Text,
                textBoxName.Text,
                textBoxEmail.Text
                );
            this.Close();
        }
    }
}
