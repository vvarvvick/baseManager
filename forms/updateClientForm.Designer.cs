
namespace Program.forms
{
    partial class updateClientForm
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.Text = "ID:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Enabled = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.Text = "Var:";
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.Text = "NIP:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Enabled = false;
            // 
            // label5
            // 
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.Text = "Reg:";
            // 
            // label6
            // 
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.Text = "Desc:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Visible = false;
            // 
            // label7
            // 
            this.label7.Visible = false;
            // 
            // button2
            // 
            this.button2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Visible = false;
            // 
            // updateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(592, 359);
            this.Name = "updateClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
