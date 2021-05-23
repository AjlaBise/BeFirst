namespace BeFirst.WinUI.Ponude
{
    partial class frmUpdateDeletePonuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateDeletePonuda));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNaziv.Location = new System.Drawing.Point(294, 157);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(53, 20);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(393, 159);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(194, 20);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(393, 202);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(194, 20);
            this.txtOpis.TabIndex = 4;
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOpis.Location = new System.Drawing.Point(305, 200);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(42, 20);
            this.lblOpis.TabIndex = 3;
            this.lblOpis.Text = "Opis";
            this.lblOpis.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSpremi.Image = ((System.Drawing.Image)(resources.GetObject("btnSpremi.Image")));
            this.btnSpremi.Location = new System.Drawing.Point(444, 347);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(113, 29);
            this.btnSpremi.TabIndex = 9;
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
            this.btnUkloni.Location = new System.Drawing.Point(596, 347);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(113, 29);
            this.btnUkloni.TabIndex = 10;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUkloni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUpdateDeletePonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 100);
            this.Name = "frmUpdateDeletePonuda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi podatke o ponudi";
            this.Load += new System.EventHandler(this.frmUpdateDeletePonuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}