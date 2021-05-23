namespace BeFirst.WinUI.Internet
{
    partial class frmDodajInternet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajInternet));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtBrzina = new System.Windows.Forms.TextBox();
            this.lblBrzina = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblUgovor = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxUgovor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(130, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Internet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 148);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNaziv.Location = new System.Drawing.Point(396, 179);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(46, 17);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(477, 176);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(215, 20);
            this.txtNaziv.TabIndex = 3;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // txtBrzina
            // 
            this.txtBrzina.Location = new System.Drawing.Point(477, 218);
            this.txtBrzina.Name = "txtBrzina";
            this.txtBrzina.Size = new System.Drawing.Size(215, 20);
            this.txtBrzina.TabIndex = 5;
            this.txtBrzina.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrzina_Validating);
            // 
            // lblBrzina
            // 
            this.lblBrzina.AutoSize = true;
            this.lblBrzina.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrzina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrzina.Location = new System.Drawing.Point(390, 219);
            this.lblBrzina.Name = "lblBrzina";
            this.lblBrzina.Size = new System.Drawing.Size(52, 17);
            this.lblBrzina.TabIndex = 4;
            this.lblBrzina.Text = "Brzina";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(477, 256);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(215, 20);
            this.txtCijena.TabIndex = 7;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCijena.Location = new System.Drawing.Point(390, 259);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(50, 17);
            this.lblCijena.TabIndex = 6;
            this.lblCijena.Text = "Cijena";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(477, 294);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(215, 20);
            this.txtOpis.TabIndex = 9;
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOpis.Location = new System.Drawing.Point(403, 297);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(37, 17);
            this.lblOpis.TabIndex = 8;
            this.lblOpis.Text = "Opis";
            // 
            // lblUgovor
            // 
            this.lblUgovor.AutoSize = true;
            this.lblUgovor.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUgovor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUgovor.Location = new System.Drawing.Point(396, 337);
            this.lblUgovor.Name = "lblUgovor";
            this.lblUgovor.Size = new System.Drawing.Size(55, 17);
            this.lblUgovor.TabIndex = 10;
            this.lblUgovor.Text = "Ugovor";
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.Teal;
            this.btnSpremi.Location = new System.Drawing.Point(572, 389);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(120, 42);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxUgovor
            // 
            this.comboBoxUgovor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUgovor.FormattingEnabled = true;
            this.comboBoxUgovor.Location = new System.Drawing.Point(477, 337);
            this.comboBoxUgovor.Name = "comboBoxUgovor";
            this.comboBoxUgovor.Size = new System.Drawing.Size(215, 21);
            this.comboBoxUgovor.TabIndex = 13;
            this.comboBoxUgovor.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxUgovor_Validating);
            // 
            // frmDodajInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(851, 470);
            this.Controls.Add(this.comboBoxUgovor);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblUgovor);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtBrzina);
            this.Controls.Add(this.lblBrzina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajInternet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj internet";
            this.Load += new System.EventHandler(this.frmDodajInternet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtBrzina;
        private System.Windows.Forms.Label lblBrzina;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblUgovor;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox comboBoxUgovor;
    }
}