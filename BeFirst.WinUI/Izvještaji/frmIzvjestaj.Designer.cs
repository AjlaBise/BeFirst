namespace BeFirst.WinUI.Izvještaji
{
    partial class frmIzvjestaj
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMjesec = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIntervencije = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.txtPotroseniAlat = new System.Windows.Forms.TextBox();
            this.txtIskoristenaOprema = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(173, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj intervencija : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(173, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utrošeni alat u KM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(173, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj iskorištene opreme :  ";
            // 
            // txtMjesec
            // 
            this.txtMjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMjesec.Location = new System.Drawing.Point(569, 93);
            this.txtMjesec.Name = "txtMjesec";
            this.txtMjesec.Size = new System.Drawing.Size(42, 26);
            this.txtMjesec.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(737, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "traži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(556, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unesite mjesec i godinu u brojčanom obliku";
            // 
            // txtIntervencije
            // 
            this.txtIntervencije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtIntervencije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntervencije.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIntervencije.Location = new System.Drawing.Point(362, 140);
            this.txtIntervencije.Name = "txtIntervencije";
            this.txtIntervencije.ReadOnly = true;
            this.txtIntervencije.Size = new System.Drawing.Size(85, 13);
            this.txtIntervencije.TabIndex = 6;
            // 
            // txtGodina
            // 
            this.txtGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodina.Location = new System.Drawing.Point(628, 93);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(103, 26);
            this.txtGodina.TabIndex = 7;
            // 
            // txtPotroseniAlat
            // 
            this.txtPotroseniAlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtPotroseniAlat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPotroseniAlat.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPotroseniAlat.Location = new System.Drawing.Point(382, 212);
            this.txtPotroseniAlat.Name = "txtPotroseniAlat";
            this.txtPotroseniAlat.ReadOnly = true;
            this.txtPotroseniAlat.Size = new System.Drawing.Size(85, 13);
            this.txtPotroseniAlat.TabIndex = 8;
            // 
            // txtIskoristenaOprema
            // 
            this.txtIskoristenaOprema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtIskoristenaOprema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIskoristenaOprema.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIskoristenaOprema.Location = new System.Drawing.Point(423, 273);
            this.txtIskoristenaOprema.Name = "txtIskoristenaOprema";
            this.txtIskoristenaOprema.ReadOnly = true;
            this.txtIskoristenaOprema.Size = new System.Drawing.Size(85, 13);
            this.txtIskoristenaOprema.TabIndex = 9;
            // 
            // frmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(820, 459);
            this.Controls.Add(this.txtIskoristenaOprema);
            this.Controls.Add(this.txtPotroseniAlat);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.txtIntervencije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMjesec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "frmIzvjestaj";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "izvjestaj";
            this.Load += new System.EventHandler(this.frmIzvjestaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMjesec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIntervencije;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.TextBox txtPotroseniAlat;
        private System.Windows.Forms.TextBox txtIskoristenaOprema;
    }
}