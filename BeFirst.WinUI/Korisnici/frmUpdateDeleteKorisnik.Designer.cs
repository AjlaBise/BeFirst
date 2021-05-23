namespace BeFirst.WinUI.Korisnici
{
    partial class frmUpdateDeleteKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateDeleteKorisnik));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPaket = new System.Windows.Forms.ComboBox();
            this.comboBoxUgovor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKomenatar = new System.Windows.Forms.TextBox();
            this.lbKomenatar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.dateTimePickerRodjenje = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxPaket
            // 
            this.comboBoxPaket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaket.FormattingEnabled = true;
            this.comboBoxPaket.Location = new System.Drawing.Point(560, 327);
            this.comboBoxPaket.Name = "comboBoxPaket";
            this.comboBoxPaket.Size = new System.Drawing.Size(197, 21);
            this.comboBoxPaket.TabIndex = 42;
            this.comboBoxPaket.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxPaket_Validating);
            // 
            // comboBoxUgovor
            // 
            this.comboBoxUgovor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUgovor.FormattingEnabled = true;
            this.comboBoxUgovor.Location = new System.Drawing.Point(560, 286);
            this.comboBoxUgovor.Name = "comboBoxUgovor";
            this.comboBoxUgovor.Size = new System.Drawing.Size(197, 21);
            this.comboBoxUgovor.TabIndex = 41;
            this.comboBoxUgovor.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxUgovor_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(473, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Paket";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(464, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ugovor";
            // 
            // txtKomenatar
            // 
            this.txtKomenatar.Location = new System.Drawing.Point(560, 247);
            this.txtKomenatar.Name = "txtKomenatar";
            this.txtKomenatar.Size = new System.Drawing.Size(197, 20);
            this.txtKomenatar.TabIndex = 38;
            // 
            // lbKomenatar
            // 
            this.lbKomenatar.AutoSize = true;
            this.lbKomenatar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKomenatar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbKomenatar.Location = new System.Drawing.Point(444, 245);
            this.lbKomenatar.Name = "lbKomenatar";
            this.lbKomenatar.Size = new System.Drawing.Size(83, 20);
            this.lbKomenatar.TabIndex = 37;
            this.lbKomenatar.Text = "Komentar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(407, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Datum rođenja";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(560, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(473, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Email";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(180, 325);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(197, 20);
            this.txtBrojTelefona.TabIndex = 32;
            this.txtBrojTelefona.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojTelefona_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(43, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Broj telefona";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(180, 284);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(197, 20);
            this.txtGrad.TabIndex = 30;
            this.txtGrad.Validating += new System.ComponentModel.CancelEventHandler(this.txtGrad_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(101, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Grad";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(180, 247);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(197, 20);
            this.txtAdresa.TabIndex = 28;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(86, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Adresa";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(180, 212);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(197, 20);
            this.txtPrezime.TabIndex = 26;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(77, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(180, 176);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(197, 20);
            this.txtIme.TabIndex = 24;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIme.Location = new System.Drawing.Point(109, 176);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(38, 20);
            this.lblIme.TabIndex = 23;
            this.lblIme.Text = "Ime";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SpringGreen;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(513, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 43;
            this.button1.Text = "Spremi";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkloni.ForeColor = System.Drawing.Color.Red;
            this.btnUkloni.Image = ((System.Drawing.Image)(resources.GetObject("btnUkloni.Image")));
            this.btnUkloni.Location = new System.Drawing.Point(657, 402);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(100, 34);
            this.btnUkloni.TabIndex = 44;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUkloni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // dateTimePickerRodjenje
            // 
            this.dateTimePickerRodjenje.Location = new System.Drawing.Point(560, 209);
            this.dateTimePickerRodjenje.Name = "dateTimePickerRodjenje";
            this.dateTimePickerRodjenje.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRodjenje.TabIndex = 45;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateDeleteKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(859, 494);
            this.Controls.Add(this.dateTimePickerRodjenje);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPaket);
            this.Controls.Add(this.comboBoxUgovor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKomenatar);
            this.Controls.Add(this.lbKomenatar);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmUpdateDeleteKorisnik";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi podatke o korisniku";
            this.Load += new System.EventHandler(this.frmUpdateDeleteKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxPaket;
        private System.Windows.Forms.ComboBox comboBoxUgovor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKomenatar;
        private System.Windows.Forms.Label lbKomenatar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.DateTimePicker dateTimePickerRodjenje;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}