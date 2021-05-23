namespace BeFirst.WinUI.Uposlenici
{
    partial class frmUpdateDeleteUposlenik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateDeleteUposlenik));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPlata = new System.Windows.Forms.TextBox();
            this.lblPlata = new System.Windows.Forms.Label();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.lblUgovor = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.chBxAktivan = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxUgovor = new System.Windows.Forms.ComboBox();
            this.comboBoxPozicija = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIme.Location = new System.Drawing.Point(88, 179);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(38, 20);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(148, 179);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(168, 20);
            this.txtIme.TabIndex = 2;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(148, 220);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(168, 20);
            this.txtPrezime.TabIndex = 4;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrezime.Location = new System.Drawing.Point(56, 220);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(70, 20);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(148, 258);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(168, 20);
            this.txtAdresa.TabIndex = 6;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAdresa.Location = new System.Drawing.Point(65, 256);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(61, 20);
            this.lblAdresa.TabIndex = 5;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(148, 303);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(168, 20);
            this.txtGrad.TabIndex = 8;
            this.txtGrad.Validating += new System.ComponentModel.CancelEventHandler(this.txtGrad_Validating);
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblGrad.Location = new System.Drawing.Point(80, 301);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(46, 20);
            this.lblGrad.TabIndex = 7;
            this.lblGrad.Text = "Grad";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(485, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmail.Location = new System.Drawing.Point(409, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // txtPlata
            // 
            this.txtPlata.Location = new System.Drawing.Point(485, 220);
            this.txtPlata.Name = "txtPlata";
            this.txtPlata.Size = new System.Drawing.Size(168, 20);
            this.txtPlata.TabIndex = 12;
            this.txtPlata.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlata_Validating);
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlata.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlata.Location = new System.Drawing.Point(414, 220);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(49, 20);
            this.lblPlata.TabIndex = 11;
            this.lblPlata.Text = "Plata";
            // 
            // lblPozicija
            // 
            this.lblPozicija.AutoSize = true;
            this.lblPozicija.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPozicija.Location = new System.Drawing.Point(396, 260);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(67, 20);
            this.lblPozicija.TabIndex = 13;
            this.lblPozicija.Text = "Pozicija";
            // 
            // lblUgovor
            // 
            this.lblUgovor.AutoSize = true;
            this.lblUgovor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUgovor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUgovor.Location = new System.Drawing.Point(400, 301);
            this.lblUgovor.Name = "lblUgovor";
            this.lblUgovor.Size = new System.Drawing.Size(63, 20);
            this.lblUgovor.TabIndex = 15;
            this.lblUgovor.Text = "Ugovor";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(148, 345);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(168, 20);
            this.txtBrojTelefona.TabIndex = 18;
            this.txtBrojTelefona.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojTelefona_Validating);
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojTelefona.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBrojTelefona.Location = new System.Drawing.Point(22, 343);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(104, 20);
            this.lblBrojTelefona.TabIndex = 17;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // chBxAktivan
            // 
            this.chBxAktivan.AutoSize = true;
            this.chBxAktivan.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxAktivan.ForeColor = System.Drawing.SystemColors.Info;
            this.chBxAktivan.Location = new System.Drawing.Point(400, 345);
            this.chBxAktivan.Name = "chBxAktivan";
            this.chBxAktivan.Size = new System.Drawing.Size(88, 24);
            this.chBxAktivan.TabIndex = 19;
            this.chBxAktivan.Text = "Aktivan";
            this.chBxAktivan.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSpremi.Image = ((System.Drawing.Image)(resources.GetObject("btnSpremi.Image")));
            this.btnSpremi.Location = new System.Drawing.Point(433, 432);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(122, 32);
            this.btnSpremi.TabIndex = 20;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpremi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(597, 432);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 32);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Ukloni";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxUgovor
            // 
            this.comboBoxUgovor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUgovor.FormattingEnabled = true;
            this.comboBoxUgovor.Location = new System.Drawing.Point(485, 300);
            this.comboBoxUgovor.Name = "comboBoxUgovor";
            this.comboBoxUgovor.Size = new System.Drawing.Size(168, 21);
            this.comboBoxUgovor.TabIndex = 22;
            this.comboBoxUgovor.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxUgovor_Validating);
            // 
            // comboBoxPozicija
            // 
            this.comboBoxPozicija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPozicija.FormattingEnabled = true;
            this.comboBoxPozicija.Location = new System.Drawing.Point(485, 260);
            this.comboBoxPozicija.Name = "comboBoxPozicija";
            this.comboBoxPozicija.Size = new System.Drawing.Size(168, 21);
            this.comboBoxPozicija.TabIndex = 23;
            this.comboBoxPozicija.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxPozicija_Validating);
            // 
            // frmUpdateDeleteUposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(831, 517);
            this.Controls.Add(this.comboBoxPozicija);
            this.Controls.Add(this.comboBoxUgovor);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.chBxAktivan);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblUgovor);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.txtPlata);
            this.Controls.Add(this.lblPlata);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmUpdateDeleteUposlenik";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređivanje podataka o uposleniku";
            this.Load += new System.EventHandler(this.frmUpdateDeleteUposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPlata;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label lblUgovor;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.CheckBox chBxAktivan;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox comboBoxUgovor;
        private System.Windows.Forms.ComboBox comboBoxPozicija;
    }
}