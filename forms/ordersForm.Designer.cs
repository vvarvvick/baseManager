
namespace Program.forms
{
    partial class ordersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSelectClient = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 49);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "dodaj zamowienie";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSelectClient
            // 
            this.buttonSelectClient.Location = new System.Drawing.Point(12, 91);
            this.buttonSelectClient.Name = "buttonSelectClient";
            this.buttonSelectClient.Size = new System.Drawing.Size(111, 49);
            this.buttonSelectClient.TabIndex = 1;
            this.buttonSelectClient.Text = "pokasz zamowienia dla klienta";
            this.buttonSelectClient.UseVisualStyleBackColor = true;
            this.buttonSelectClient.Click += new System.EventHandler(this.buttonSelectClient_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(12, 160);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(111, 49);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "pokasz wszystkie zamowienia";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // panelShow
            // 
            this.panelShow.Location = new System.Drawing.Point(148, 12);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(705, 441);
            this.panelShow.TabIndex = 3;
            // 
            // ordersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 465);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonSelectClient);
            this.Controls.Add(this.buttonAdd);
            this.Name = "ordersForm";
            this.Text = "ordersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSelectClient;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Panel panelShow;
    }
}