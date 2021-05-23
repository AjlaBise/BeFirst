namespace BeFirst.WinUI.Oprema
{
    partial class frmUpdateDeleteOprema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateDeleteOprema));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblBrojKomada = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.checkBoxNaStanju = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.txtBrojKomada = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(374, 160);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(53, 20);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(460, 160);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(220, 20);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // lblBrojKomada
            // 
            this.lblBrojKomada.AutoSize = true;
            this.lblBrojKomada.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojKomada.Location = new System.Drawing.Point(324, 218);
            this.lblBrojKomada.Name = "lblBrojKomada";
            this.lblBrojKomada.Size = new System.Drawing.Size(103, 20);
            this.lblBrojKomada.TabIndex = 3;
            this.lblBrojKomada.Text = "Broj komada";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.Location = new System.Drawing.Point(369, 264);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(58, 20);
            this.lblCijena.TabIndex = 4;
            this.lblCijena.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(460, 266);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(220, 20);
            this.txtCijena.TabIndex = 6;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // checkBoxNaStanju
            // 
            this.checkBoxNaStanju.AutoSize = true;
            this.checkBoxNaStanju.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNaStanju.Location = new System.Drawing.Point(460, 314);
            this.checkBoxNaStanju.Name = "checkBoxNaStanju";
            this.checkBoxNaStanju.Size = new System.Drawing.Size(101, 24);
            this.checkBoxNaStanju.TabIndex = 7;
            this.checkBoxNaStanju.Text = "Na stanju";
            this.checkBoxNaStanju.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.ForeColor = System.Drawing.Color.Lime;
            this.btnSpremi.Image = ((System.Drawing.Image)(resources.GetObject("btnSpremi.Image")));
            this.btnSpremi.Location = new System.Drawing.Point(585, 402);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 31);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpremi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkloni.ForeColor = System.Drawing.Color.Red;
            this.btnUkloni.Image = ((System.Drawing.Image)(resources.GetObject("btnUkloni.Image")));
            this.btnUkloni.Location = new System.Drawing.Point(729, 402);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(100, 31);
            this.btnUkloni.TabIndex = 9;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUkloni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // txtBrojKomada
            // 
            this.txtBrojKomada.Location = new System.Drawing.Point(460, 218);
            this.txtBrojKomada.Name = "txtBrojKomada";
            this.txtBrojKomada.Size = new System.Drawing.Size(220, 20);
            this.txtBrojKomada.TabIndex = 10;
            this.txtBrojKomada.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojKomada_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmUpdateDeleteOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(900, 492);
            this.Controls.Add(this.txtBrojKomada);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.checkBoxNaStanju);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblBrojKomada);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "frmUpdateDeleteOprema";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi podatke o opremi";
            this.Load += new System.EventHandler(this.frmUpdateDeleteOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblBrojKomada;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.CheckBox checkBoxNaStanju;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.TextBox txtBrojKomada;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}