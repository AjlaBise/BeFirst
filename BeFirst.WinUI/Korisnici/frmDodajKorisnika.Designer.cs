namespace BeFirst.WinUI.Korisnici
{
    partial class frmDodajKorisnika
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
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKomenatar = new System.Windows.Forms.TextBox();
            this.lbKomenatar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxUgovor = new System.Windows.Forms.ComboBox();
            this.comboBoxPaket = new System.Windows.Forms.ComboBox();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePickerRodjenje = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(276, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj korisnik";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIme.Location = new System.Drawing.Point(94, 172);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(38, 20);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(165, 172);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(197, 20);
            this.txtIme.TabIndex = 2;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(165, 208);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(197, 20);
            this.txtPrezime.TabIndex = 4;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(165, 243);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(197, 20);
            this.txtAdresa.TabIndex = 6;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(71, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adresa";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(165, 280);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(197, 20);
            this.txtGrad.TabIndex = 8;
            this.txtGrad.Validating += new System.ComponentModel.CancelEventHandler(this.txtGrad_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(86, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grad";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(165, 321);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(197, 20);
            this.txtBrojTelefona.TabIndex = 10;
            this.txtBrojTelefona.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojTelefona_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(28, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Broj telefona";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(545, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(458, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // txtKomenatar
            // 
            this.txtKomenatar.Location = new System.Drawing.Point(545, 243);
            this.txtKomenatar.Name = "txtKomenatar";
            this.txtKomenatar.Size = new System.Drawing.Size(197, 20);
            this.txtKomenatar.TabIndex = 16;
            // 
            // lbKomenatar
            // 
            this.lbKomenatar.AutoSize = true;
            this.lbKomenatar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKomenatar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbKomenatar.Location = new System.Drawing.Point(429, 241);
            this.lbKomenatar.Name = "lbKomenatar";
            this.lbKomenatar.Size = new System.Drawing.Size(83, 20);
            this.lbKomenatar.TabIndex = 15;
            this.lbKomenatar.Text = "Komentar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(449, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ugovor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(458, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Paket";
            // 
            // comboBoxUgovor
            // 
            this.comboBoxUgovor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUgovor.FormattingEnabled = true;
            this.comboBoxUgovor.Location = new System.Drawing.Point(545, 282);
            this.comboBoxUgovor.Name = "comboBoxUgovor";
            this.comboBoxUgovor.Size = new System.Drawing.Size(197, 21);
            this.comboBoxUgovor.TabIndex = 21;
            this.comboBoxUgovor.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxUgovor_Validating);
            // 
            // comboBoxPaket
            // 
            this.comboBoxPaket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaket.FormattingEnabled = true;
            this.comboBoxPaket.Location = new System.Drawing.Point(545, 323);
            this.comboBoxPaket.Name = "comboBoxPaket";
            this.comboBoxPaket.Size = new System.Drawing.Size(197, 21);
            this.comboBoxPaket.TabIndex = 22;
            this.comboBoxPaket.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxPaket_Validating);
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSpremi.ForeColor = System.Drawing.Color.Teal;
            this.BtnSpremi.Location = new System.Drawing.Point(624, 390);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(118, 39);
            this.BtnSpremi.TabIndex = 23;
            this.BtnSpremi.Text = "Spremi";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(392, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Datum rođenja";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dateTimePickerRodjenje
            // 
            this.dateTimePickerRodjenje.Location = new System.Drawing.Point(545, 208);
            this.dateTimePickerRodjenje.Name = "dateTimePickerRodjenje";
            this.dateTimePickerRodjenje.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRodjenje.TabIndex = 25;
            // 
            // frmDodajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(882, 487);
            this.Controls.Add(this.dateTimePickerRodjenje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.comboBoxPaket);
            this.Controls.Add(this.comboBoxUgovor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKomenatar);
            this.Controls.Add(this.lbKomenatar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajKorisnika";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj korisnika";
            this.Load += new System.EventHandler(this.frmDodajKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKomenatar;
        private System.Windows.Forms.Label lbKomenatar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxUgovor;
        private System.Windows.Forms.ComboBox comboBoxPaket;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dateTimePickerRodjenje;
    }
}