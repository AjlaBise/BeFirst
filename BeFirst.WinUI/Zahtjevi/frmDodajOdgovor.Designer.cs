namespace BeFirst.WinUI.Zahtjevi
{
    partial class frmDodajOdgovor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajOdgovor));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbOdgovor = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdgovori = new System.Windows.Forms.Button();
            this.checkBoxOdgovoreno = new System.Windows.Forms.CheckBox();
            this.checkBoxPOgledano = new System.Windows.Forms.CheckBox();
            this.richTextBoxZahjtev = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(318, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalji";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 84);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNaslov.Location = new System.Drawing.Point(228, 95);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(72, 20);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "Naslov : ";
            // 
            // txtNaslov
            // 
            this.txtNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtNaslov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaslov.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNaslov.Location = new System.Drawing.Point(307, 94);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ReadOnly = true;
            this.txtNaslov.Size = new System.Drawing.Size(209, 20);
            this.txtNaslov.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(228, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zahtjev : ";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtKorisnik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKorisnik.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKorisnik.Location = new System.Drawing.Point(307, 217);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(209, 20);
            this.txtKorisnik.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(228, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Korisnik : ";
            // 
            // rtbOdgovor
            // 
            this.rtbOdgovor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbOdgovor.Location = new System.Drawing.Point(232, 296);
            this.rtbOdgovor.Name = "rtbOdgovor";
            this.rtbOdgovor.Size = new System.Drawing.Size(471, 152);
            this.rtbOdgovor.TabIndex = 8;
            this.rtbOdgovor.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(228, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Odgovor : ";
            // 
            // btnOdgovori
            // 
            this.btnOdgovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdgovori.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdgovori.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOdgovori.Location = new System.Drawing.Point(611, 466);
            this.btnOdgovori.Name = "btnOdgovori";
            this.btnOdgovori.Size = new System.Drawing.Size(92, 35);
            this.btnOdgovori.TabIndex = 10;
            this.btnOdgovori.Text = "Odgovori";
            this.btnOdgovori.UseVisualStyleBackColor = true;
            this.btnOdgovori.Click += new System.EventHandler(this.btnOdgovori_Click);
            // 
            // checkBoxOdgovoreno
            // 
            this.checkBoxOdgovoreno.AutoSize = true;
            this.checkBoxOdgovoreno.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOdgovoreno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxOdgovoreno.Location = new System.Drawing.Point(587, 95);
            this.checkBoxOdgovoreno.Name = "checkBoxOdgovoreno";
            this.checkBoxOdgovoreno.Size = new System.Drawing.Size(116, 24);
            this.checkBoxOdgovoreno.TabIndex = 11;
            this.checkBoxOdgovoreno.Text = "Odgovoreno";
            this.checkBoxOdgovoreno.UseVisualStyleBackColor = true;
            // 
            // checkBoxPOgledano
            // 
            this.checkBoxPOgledano.AutoSize = true;
            this.checkBoxPOgledano.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPOgledano.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxPOgledano.Location = new System.Drawing.Point(587, 138);
            this.checkBoxPOgledano.Name = "checkBoxPOgledano";
            this.checkBoxPOgledano.Size = new System.Drawing.Size(112, 24);
            this.checkBoxPOgledano.TabIndex = 12;
            this.checkBoxPOgledano.Text = "Pregledano";
            this.checkBoxPOgledano.UseVisualStyleBackColor = true;
            // 
            // richTextBoxZahjtev
            // 
            this.richTextBoxZahjtev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.richTextBoxZahjtev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxZahjtev.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxZahjtev.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxZahjtev.Location = new System.Drawing.Point(312, 145);
            this.richTextBoxZahjtev.Name = "richTextBoxZahjtev";
            this.richTextBoxZahjtev.Size = new System.Drawing.Size(244, 70);
            this.richTextBoxZahjtev.TabIndex = 13;
            this.richTextBoxZahjtev.Text = "";
            // 
            // frmDodajOdgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(834, 530);
            this.Controls.Add(this.richTextBoxZahjtev);
            this.Controls.Add(this.checkBoxPOgledano);
            this.Controls.Add(this.checkBoxOdgovoreno);
            this.Controls.Add(this.btnOdgovori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbOdgovor);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajOdgovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj odgovor";
            this.Load += new System.EventHandler(this.frmDodajOdgovor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbOdgovor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdgovori;
        private System.Windows.Forms.CheckBox checkBoxOdgovoreno;
        private System.Windows.Forms.CheckBox checkBoxPOgledano;
        private System.Windows.Forms.RichTextBox richTextBoxZahjtev;
    }
}