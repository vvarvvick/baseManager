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
    public partial class ordersForm : Form
    {
        Form formActive;

        public ordersForm()
        {
            InitializeComponent();
            formActive = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            openchildform(new addOrderPanelForm());
        }

        private void buttonSelectClient_Click(object sender, EventArgs e)
        {
            openchildform(new selectOrderPanelForm());
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            openchildform(new selectOrdersPanelForm());
        }

        private void openchildform(Form childform)
        {
            if (formActive != null)
                formActive.Close();

            formActive = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelShow.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();

            childform.BackColor = Color.FromArgb(39, 41, 61);
        }
    }
}
