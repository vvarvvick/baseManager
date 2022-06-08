using FontAwesome.Sharp;
using Program.forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program
{
    public partial class FormMain : Form
    {
        private IconButton currBtn;
        private Panel leftBdr;
        private Form formActivate;
        public bool userLoged;

        public FormMain()
        {
            InitializeComponent();
            leftBdr = new Panel();
            leftBdr.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBdr);
            userLoged = false;
        }

        public struct DataUser
        {
            public static string login;
            public static string registred;
            public static int levelAcces;
            public static string name;
            public static string surname;
            public static string email;
            public static int phone;
            public static byte[] img;
        }

        private struct Colors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(172, 126, 241);
        }

        public void ShowButton(int x)
        {
            switch (x)
            {
                case 0:
                    iconButtonLogin.Visible = true;
                    iconButtonClient.Visible = false;
                    iconButtonBase.Visible = false;
                    iconButtonOrder.Visible = false;
                    iconButtonFils.Visible = false;
                    iconButtonAdmin.Visible = false;
                    iconButtonExit.Visible = true;
                    break;
                case 1:
                    iconButtonLogin.Visible = true;
                    iconButtonClient.Visible = true;
                    iconButtonBase.Visible = true;
                    iconButtonOrder.Visible = true;
                    iconButtonFils.Visible = true;
                    iconButtonAdmin.Visible = false;
                    iconButtonExit.Visible = true;
                    break;
                case 2:
                    iconButtonLogin.Visible = true;
                    iconButtonClient.Visible = true;
                    iconButtonBase.Visible = true;
                    iconButtonOrder.Visible = true;
                    iconButtonFils.Visible = true;
                    iconButtonAdmin.Visible = false;
                    iconButtonExit.Visible = true;
                    break;
                case 3:
                    iconButtonLogin.Visible = true;
                    iconButtonClient.Visible = true;
                    iconButtonBase.Visible = true;
                    iconButtonOrder.Visible = true;
                    iconButtonFils.Visible = true;
                    iconButtonAdmin.Visible = true;
                    iconButtonExit.Visible = true;
                    break;
            }
        }

        private void Activatebutton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                Diasblebutton();

                currBtn = (IconButton)senderbtn;
                currBtn.BackColor = Color.FromArgb(39, 41, 61);
                currBtn.ForeColor = color;
                currBtn.TextAlign = ContentAlignment.MiddleCenter;
                currBtn.IconColor = color;
                currBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBdr.BackColor = color;
                leftBdr.Location = new Point(0, currBtn.Location.Y);
                leftBdr.Visible = true;
                leftBdr.BringToFront();

                iconPictureBoxCurrentIcon.IconChar = currBtn.IconChar;
                iconPictureBoxCurrentIcon.IconColor = color;
                labelCurrentTitle.Text = currBtn.Text;
            }
        }

        private void Diasblebutton()
        {
            if (currBtn != null)
            {
                currBtn.BackColor = Color.Transparent;
                currBtn.ForeColor = Color.White;
                currBtn.TextAlign = ContentAlignment.MiddleLeft;
                currBtn.IconColor = Color.White;
                currBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Openchildform(Form childform)
        {
            if (formActivate != null)
                formActivate.Close();

            formActivate = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelCenter.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();

            childform.BackColor = Color.FromArgb(39, 41, 61);
        }

        public void IconButtonLogin_Click(object sender, EventArgs e)
        {
            Form lForm;

            if (userLoged == false)
                lForm = new loginForm();
            else
                lForm = new loggedForm();

            lForm.Owner = this;
            Activatebutton(sender, Colors.color1);
            Openchildform(lForm);
        }

        private void iconButtonClient_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color2);
            Openchildform(new clientForm());
        }

        private void iconButtonBase_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color3);
            Openchildform(new assortmentForm());
        }

        private void iconButtonOrder_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color4);
            Openchildform(new ordersForm());
        }

        private void iconButtonFils_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color5);
            Openchildform(new searchForm());
        }

        private void iconButtonAdmin_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color6);
            Openchildform(new adminForm());
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Activatebutton(sender, Colors.color7);

            if (formActivate != null)
                formActivate.Close();
                Reset();

            DialogResult result = MessageBox.Show("Are you sure you want to Exit??", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void pictureBoxHomeBtn_Click(object sender, EventArgs e)
        {
            if (formActivate != null)
                formActivate.Close();
            Reset();
        }

        public void Reset()
        {                   
            Diasblebutton();
            leftBdr.Visible = false;
            iconPictureBoxCurrentIcon.IconChar = IconChar.Home;
            iconPictureBoxCurrentIcon.IconColor = Color.White;
            labelCurrentTitle.Text = "Home";
        }
    }
}
