namespace BeFirst.WinUI.Korisnici
{
    partial class UCKorisnici
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKorisnici));
            this.gbKorisnici = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddKorisnik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKorisnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKorisnici
            // 
            this.gbKorisnici.Controls.Add(this.dgvKorisnici);
            this.gbKorisnici.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.gbKorisnici.ForeColor = System.Drawing.Color.Teal;
            this.gbKorisnici.Location = new System.Drawing.Point(13, 157);
            this.gbKorisnici.Name = "gbKorisnici";
            this.gbKorisnici.Size = new System.Drawing.Size(727, 336);
            this.gbKorisnici.TabIndex = 0;
            this.gbKorisnici.TabStop = false;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dgvKorisnici.Location = new System.Drawing.Point(18, 26);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(691, 298);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKorisnici_MouseDoubleClick);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.FlatAppearance.BorderSize = 0;
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikazi.Image")));
            this.btnPrikazi.Location = new System.Drawing.Point(685, 93);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(37, 32);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_ClickAsync);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 5;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPretraga.ForeColor = System.Drawing.Color.Teal;
            this.txtPretraga.Location = new System.Drawing.Point(465, 98);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(209, 27);
            this.txtPretraga.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddKorisnik);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPretraga);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.gbKorisnici);
            this.panel1.Location = new System.Drawing.Point(92, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 525);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddKorisnik
            // 
            this.btnAddKorisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKorisnik.ForeColor = System.Drawing.Color.Teal;
            this.btnAddKorisnik.Location = new System.Drawing.Point(598, 48);
            this.btnAddKorisnik.Name = "btnAddKorisnik";
            this.btnAddKorisnik.Size = new System.Drawing.Size(123, 29);
            this.btnAddKorisnik.TabIndex = 8;
            this.btnAddKorisnik.Text = "+ Dodaj";
            this.btnAddKorisnik.UseVisualStyleBackColor = true;
            this.btnAddKorisnik.Click += new System.EventHandler(this.btnAddKorisnik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(289, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Korisnici";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // UCKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "UCKorisnici";
            this.Size = new System.Drawing.Size(923, 556);
            this.Load += new System.EventHandler(this.UCKorisnik_Load);
            this.gbKorisnici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKorisnici;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
