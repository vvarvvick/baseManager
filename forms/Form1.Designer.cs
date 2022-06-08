
namespace Program
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxHomeBtn = new System.Windows.Forms.PictureBox();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdmin = new FontAwesome.Sharp.IconButton();
            this.iconButtonOrder = new FontAwesome.Sharp.IconButton();
            this.iconButtonBase = new FontAwesome.Sharp.IconButton();
            this.iconButtonClient = new FontAwesome.Sharp.IconButton();
            this.iconButtonLogin = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelCurrentTitle = new System.Windows.Forms.Label();
            this.iconPictureBoxCurrentIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.iconButtonFils = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeBtn)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Silver;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.iconButtonFils);
            this.panelMenu.Controls.Add(this.pictureBoxHomeBtn);
            this.panelMenu.Controls.Add(this.iconButtonExit);
            this.panelMenu.Controls.Add(this.iconButtonAdmin);
            this.panelMenu.Controls.Add(this.iconButtonOrder);
            this.panelMenu.Controls.Add(this.iconButtonBase);
            this.panelMenu.Controls.Add(this.iconButtonClient);
            this.panelMenu.Controls.Add(this.iconButtonLogin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 574);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBoxHomeBtn
            // 
            this.pictureBoxHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHomeBtn.BackgroundImage = global::Program.Properties.Resources.cmpLogo2;
            this.pictureBoxHomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHomeBtn.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHomeBtn.Name = "pictureBoxHomeBtn";
            this.pictureBoxHomeBtn.Size = new System.Drawing.Size(244, 131);
            this.pictureBoxHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHomeBtn.TabIndex = 0;
            this.pictureBoxHomeBtn.TabStop = false;
            this.pictureBoxHomeBtn.Click += new System.EventHandler(this.pictureBoxHomeBtn_Click);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonExit.ForeColor = System.Drawing.Color.White;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 30;
            this.iconButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.Location = new System.Drawing.Point(0, 525);
            this.iconButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonExit.Size = new System.Drawing.Size(250, 40);
            this.iconButtonExit.TabIndex = 7;
            this.iconButtonExit.Text = "Exit";
            this.iconButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // iconButtonAdmin
            // 
            this.iconButtonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.iconButtonAdmin.FlatAppearance.BorderSize = 0;
            this.iconButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdmin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonAdmin.ForeColor = System.Drawing.Color.White;
            this.iconButtonAdmin.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButtonAdmin.IconColor = System.Drawing.Color.White;
            this.iconButtonAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdmin.IconSize = 30;
            this.iconButtonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdmin.Location = new System.Drawing.Point(0, 428);
            this.iconButtonAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonAdmin.Name = "iconButtonAdmin";
            this.iconButtonAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonAdmin.Size = new System.Drawing.Size(250, 40);
            this.iconButtonAdmin.TabIndex = 6;
            this.iconButtonAdmin.Text = "Admin";
            this.iconButtonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdmin.UseVisualStyleBackColor = false;
            this.iconButtonAdmin.Visible = false;
            this.iconButtonAdmin.Click += new System.EventHandler(this.iconButtonAdmin_Click);
            // 
            // iconButtonOrder
            // 
            this.iconButtonOrder.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonOrder.FlatAppearance.BorderSize = 0;
            this.iconButtonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonOrder.ForeColor = System.Drawing.Color.White;
            this.iconButtonOrder.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButtonOrder.IconColor = System.Drawing.Color.White;
            this.iconButtonOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOrder.IconSize = 30;
            this.iconButtonOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOrder.Location = new System.Drawing.Point(0, 320);
            this.iconButtonOrder.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonOrder.Name = "iconButtonOrder";
            this.iconButtonOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonOrder.Size = new System.Drawing.Size(250, 40);
            this.iconButtonOrder.TabIndex = 4;
            this.iconButtonOrder.Text = "Orders";
            this.iconButtonOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOrder.UseVisualStyleBackColor = false;
            this.iconButtonOrder.Visible = false;
            this.iconButtonOrder.Click += new System.EventHandler(this.iconButtonOrder_Click);
            // 
            // iconButtonBase
            // 
            this.iconButtonBase.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonBase.FlatAppearance.BorderSize = 0;
            this.iconButtonBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonBase.ForeColor = System.Drawing.Color.White;
            this.iconButtonBase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButtonBase.IconColor = System.Drawing.Color.White;
            this.iconButtonBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBase.IconSize = 30;
            this.iconButtonBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBase.Location = new System.Drawing.Point(0, 266);
            this.iconButtonBase.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonBase.Name = "iconButtonBase";
            this.iconButtonBase.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonBase.Size = new System.Drawing.Size(250, 40);
            this.iconButtonBase.TabIndex = 3;
            this.iconButtonBase.Text = "DataBase";
            this.iconButtonBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBase.UseVisualStyleBackColor = false;
            this.iconButtonBase.Visible = false;
            this.iconButtonBase.Click += new System.EventHandler(this.iconButtonBase_Click);
            // 
            // iconButtonClient
            // 
            this.iconButtonClient.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonClient.FlatAppearance.BorderSize = 0;
            this.iconButtonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClient.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonClient.ForeColor = System.Drawing.Color.White;
            this.iconButtonClient.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.iconButtonClient.IconColor = System.Drawing.Color.White;
            this.iconButtonClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClient.IconSize = 30;
            this.iconButtonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClient.Location = new System.Drawing.Point(0, 212);
            this.iconButtonClient.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonClient.Name = "iconButtonClient";
            this.iconButtonClient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonClient.Size = new System.Drawing.Size(250, 40);
            this.iconButtonClient.TabIndex = 2;
            this.iconButtonClient.Text = "Client";
            this.iconButtonClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClient.UseVisualStyleBackColor = false;
            this.iconButtonClient.Visible = false;
            this.iconButtonClient.Click += new System.EventHandler(this.iconButtonClient_Click);
            // 
            // iconButtonLogin
            // 
            this.iconButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonLogin.FlatAppearance.BorderSize = 0;
            this.iconButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonLogin.ForeColor = System.Drawing.Color.White;
            this.iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButtonLogin.IconColor = System.Drawing.Color.White;
            this.iconButtonLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogin.IconSize = 30;
            this.iconButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogin.Location = new System.Drawing.Point(0, 158);
            this.iconButtonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonLogin.Name = "iconButtonLogin";
            this.iconButtonLogin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonLogin.Size = new System.Drawing.Size(250, 40);
            this.iconButtonLogin.TabIndex = 1;
            this.iconButtonLogin.Text = "Login";
            this.iconButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogin.UseVisualStyleBackColor = false;
            this.iconButtonLogin.Click += new System.EventHandler(this.IconButtonLogin_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.panelTop.Controls.Add(this.labelCurrentTitle);
            this.panelTop.Controls.Add(this.iconPictureBoxCurrentIcon);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(882, 90);
            this.panelTop.TabIndex = 1;
            // 
            // labelCurrentTitle
            // 
            this.labelCurrentTitle.AutoSize = true;
            this.labelCurrentTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentTitle.Location = new System.Drawing.Point(107, 32);
            this.labelCurrentTitle.Name = "labelCurrentTitle";
            this.labelCurrentTitle.Size = new System.Drawing.Size(73, 24);
            this.labelCurrentTitle.TabIndex = 1;
            this.labelCurrentTitle.Text = "Home";
            // 
            // iconPictureBoxCurrentIcon
            // 
            this.iconPictureBoxCurrentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.iconPictureBoxCurrentIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBoxCurrentIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxCurrentIcon.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBoxCurrentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCurrentIcon.IconSize = 59;
            this.iconPictureBoxCurrentIcon.Location = new System.Drawing.Point(42, 21);
            this.iconPictureBoxCurrentIcon.Name = "iconPictureBoxCurrentIcon";
            this.iconPictureBoxCurrentIcon.Size = new System.Drawing.Size(59, 63);
            this.iconPictureBoxCurrentIcon.TabIndex = 0;
            this.iconPictureBoxCurrentIcon.TabStop = false;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panelCenter.Location = new System.Drawing.Point(250, 90);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(882, 484);
            this.panelCenter.TabIndex = 0;
            // 
            // iconButtonFils
            // 
            this.iconButtonFils.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonFils.FlatAppearance.BorderSize = 0;
            this.iconButtonFils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFils.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonFils.ForeColor = System.Drawing.Color.White;
            this.iconButtonFils.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonFils.IconColor = System.Drawing.Color.White;
            this.iconButtonFils.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFils.IconSize = 30;
            this.iconButtonFils.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFils.Location = new System.Drawing.Point(0, 374);
            this.iconButtonFils.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonFils.Name = "iconButtonFils";
            this.iconButtonFils.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonFils.Size = new System.Drawing.Size(250, 40);
            this.iconButtonFils.TabIndex = 5;
            this.iconButtonFils.Text = "Search";
            this.iconButtonFils.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFils.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFils.UseVisualStyleBackColor = false;
            this.iconButtonFils.Visible = false;
            this.iconButtonFils.Click += new System.EventHandler(this.iconButtonFils_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 574);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeBtn)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label labelCurrentTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCurrentIcon;
        private FontAwesome.Sharp.IconButton iconButtonOrder;
        private FontAwesome.Sharp.IconButton iconButtonBase;
        private FontAwesome.Sharp.IconButton iconButtonClient;
        public FontAwesome.Sharp.IconButton iconButtonLogin;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private FontAwesome.Sharp.IconButton iconButtonAdmin;
        private System.Windows.Forms.PictureBox pictureBoxHomeBtn;
        private FontAwesome.Sharp.IconButton iconButtonFils;
    }
}

