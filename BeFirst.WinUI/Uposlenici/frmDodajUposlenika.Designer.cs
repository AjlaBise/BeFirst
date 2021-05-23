namespace BeFirst.WinUI.Uposlenici
{
    partial class frmDodajUposlenika
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPlata = new System.Windows.Forms.TextBox();
            this.lblPlata = new System.Windows.Forms.Label();
            this.chBxAktivan = new System.Windows.Forms.CheckBox();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.lblUgovor = new System.Windows.Forms.Label();
            this.btnSpremiUposlenika = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxUgovor = new System.Windows.Forms.ComboBox();
            this.comboBoxPozicija = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(271, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj uposlenika";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblIme.Location = new System.Drawing.Point(87, 128);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(38, 20);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(155, 128);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(202, 20);
            this.txtIme.TabIndex = 2;
            this.txtIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPrezime.Location = new System.Drawing.Point(55, 173);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(70, 20);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(155, 175);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(202, 20);
            this.txtPrezime.TabIndex = 4;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(155, 217);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(202, 20);
            this.txtAdresa.TabIndex = 6;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblAdresa.Location = new System.Drawing.Point(64, 215);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(61, 20);
            this.lblAdresa.TabIndex = 5;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrad.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblGrad.Location = new System.Drawing.Point(79, 258);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(46, 20);
            this.lblGrad.TabIndex = 7;
            this.lblGrad.Text = "Grad";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(155, 260);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(202, 20);
            this.txtGrad.TabIndex = 8;
            this.txtGrad.Validating += new System.ComponentModel.CancelEventHandler(this.txtGrad_Validating);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(155, 301);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(202, 20);
            this.txtBrojTelefona.TabIndex = 10;
            this.txtBrojTelefona.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojTelefona_Validating);
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojTelefona.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblBrojTelefona.Location = new System.Drawing.Point(21, 299);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(104, 20);
            this.lblBrojTelefona.TabIndex = 9;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(491, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblEmail.Location = new System.Drawing.Point(423, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // txtPlata
            // 
            this.txtPlata.Location = new System.Drawing.Point(491, 173);
            this.txtPlata.Name = "txtPlata";
            this.txtPlata.Size = new System.Drawing.Size(202, 20);
            this.txtPlata.TabIndex = 14;
            this.txtPlata.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlata_Validating);
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlata.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPlata.Location = new System.Drawing.Point(428, 173);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(49, 20);
            this.lblPlata.TabIndex = 13;
            this.lblPlata.Text = "Plata";
            // 
            // chBxAktivan
            // 
            this.chBxAktivan.AutoSize = true;
            this.chBxAktivan.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxAktivan.Location = new System.Drawing.Point(432, 301);
            this.chBxAktivan.Name = "chBxAktivan";
            this.chBxAktivan.Size = new System.Drawing.Size(88, 24);
            this.chBxAktivan.TabIndex = 16;
            this.chBxAktivan.Text = "Aktivan";
            this.chBxAktivan.UseVisualStyleBackColor = true;
            // 
            // lblPozicija
            // 
            this.lblPozicija.AutoSize = true;
            this.lblPozicija.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblPozicija.Location = new System.Drawing.Point(410, 213);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(67, 20);
            this.lblPozicija.TabIndex = 17;
            this.lblPozicija.Text = "Pozicija";
            // 
            // lblUgovor
            // 
            this.lblUgovor.AutoSize = true;
            this.lblUgovor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUgovor.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblUgovor.Location = new System.Drawing.Point(414, 256);
            this.lblUgovor.Name = "lblUgovor";
            this.lblUgovor.Size = new System.Drawing.Size(63, 20);
            this.lblUgovor.TabIndex = 19;
            this.lblUgovor.Text = "Ugovor";
            // 
            // btnSpremiUposlenika
            // 
            this.btnSpremiUposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiUposlenika.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiUposlenika.ForeColor = System.Drawing.Color.Teal;
            this.btnSpremiUposlenika.Location = new System.Drawing.Point(567, 360);
            this.btnSpremiUposlenika.Name = "btnSpremiUposlenika";
            this.btnSpremiUposlenika.Size = new System.Drawing.Size(126, 40);
            this.btnSpremiUposlenika.TabIndex = 21;
            this.btnSpremiUposlenika.Text = "Spremi";
            this.btnSpremiUposlenika.UseCompatibleTextRendering = true;
            this.btnSpremiUposlenika.UseVisualStyleBackColor = true;
            this.btnSpremiUposlenika.Click += new System.EventHandler(this.btnSpremiUposlenika_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxUgovor
            // 
            this.comboBoxUgovor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUgovor.FormattingEnabled = true;
            this.comboBoxUgovor.Location = new System.Drawing.Point(491, 256);
            this.comboBoxUgovor.Name = "comboBoxUgovor";
            this.comboBoxUgovor.Size = new System.Drawing.Size(202, 21);
            this.comboBoxUgovor.TabIndex = 22;
            this.comboBoxUgovor.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxUgovor_Validating);
            // 
            // comboBoxPozicija
            // 
            this.comboBoxPozicija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPozicija.FormattingEnabled = true;
            this.comboBoxPozicija.Location = new System.Drawing.Point(491, 216);
            this.comboBoxPozicija.Name = "comboBoxPozicija";
            this.comboBoxPozicija.Size = new System.Drawing.Size(202, 21);
            this.comboBoxPozicija.TabIndex = 23;
            this.comboBoxPozicija.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxPozicija_Validating);
            // 
            // frmDodajUposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPozicija);
            this.Controls.Add(this.comboBoxUgovor);
            this.Controls.Add(this.btnSpremiUposlenika);
            this.Controls.Add(this.lblUgovor);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.chBxAktivan);
            this.Controls.Add(this.txtPlata);
            this.Controls.Add(this.lblPlata);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "frmDodajUposlenika";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj uposlenika";
            this.Load += new System.EventHandler(this.frmDodajUposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPlata;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.CheckBox chBxAktivan;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label lblUgovor;
        private System.Windows.Forms.Button btnSpremiUposlenika;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox comboBoxUgovor;
        private System.Windows.Forms.ComboBox comboBoxPozicija;
    }
}