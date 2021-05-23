namespace BeFirst.WinUI.Paketi
{
    partial class frmUpdateDeletePaket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateDeletePaket));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chBxCaTv = new System.Windows.Forms.CheckBox();
            this.lblUgovor = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxUgovor = new System.Windows.Forms.ComboBox();
            this.comboBoxInternet = new System.Windows.Forms.ComboBox();
            this.comboBoxVrsta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(231, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(453, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Internet";
            // 
            // chBxCaTv
            // 
            this.chBxCaTv.AutoSize = true;
            this.chBxCaTv.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxCaTv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chBxCaTv.Location = new System.Drawing.Point(457, 182);
            this.chBxCaTv.Name = "chBxCaTv";
            this.chBxCaTv.Size = new System.Drawing.Size(69, 24);
            this.chBxCaTv.TabIndex = 3;
            this.chBxCaTv.Text = "CaTv";
            this.chBxCaTv.UseVisualStyleBackColor = true;
            this.chBxCaTv.Validating += new System.ComponentModel.CancelEventHandler(this.chBxCaTv_Validating);
            // 
            // lblUgovor
            // 
            this.lblUgovor.AutoSize = true;
            this.lblUgovor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUgovor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUgovor.Location = new System.Drawing.Point(453, 280);
            this.lblUgovor.Name = "lblUgovor";
            this.lblUgovor.Size = new System.Drawing.Size(63, 20);
            this.lblUgovor.TabIndex = 4;
            this.lblUgovor.Text = "Ugovor";
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSpremi.Image = ((System.Drawing.Image)(resources.GetObject("btnSpremi.Image")));
            this.btnSpremi.Location = new System.Drawing.Point(519, 397);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(127, 32);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpremi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkloni.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.ForeColor = System.Drawing.Color.Red;
            this.btnUkloni.Image = ((System.Drawing.Image)(resources.GetObject("btnUkloni.Image")));
            this.btnUkloni.Location = new System.Drawing.Point(692, 397);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(127, 32);
            this.btnUkloni.TabIndex = 7;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUkloni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 126);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxUgovor
            // 
            this.comboBoxUgovor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUgovor.FormattingEnabled = true;
            this.comboBoxUgovor.Location = new System.Drawing.Point(557, 279);
            this.comboBoxUgovor.Name = "comboBoxUgovor";
            this.comboBoxUgovor.Size = new System.Drawing.Size(191, 21);
            this.comboBoxUgovor.TabIndex = 9;
            this.comboBoxUgovor.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // comboBoxInternet
            // 
            this.comboBoxInternet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInternet.FormattingEnabled = true;
            this.comboBoxInternet.Location = new System.Drawing.Point(557, 240);
            this.comboBoxInternet.Name = "comboBoxInternet";
            this.comboBoxInternet.Size = new System.Drawing.Size(191, 21);
            this.comboBoxInternet.TabIndex = 10;
            // 
            // comboBoxVrsta
            // 
            this.comboBoxVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVrsta.FormattingEnabled = true;
            this.comboBoxVrsta.Location = new System.Drawing.Point(557, 322);
            this.comboBoxVrsta.Name = "comboBoxVrsta";
            this.comboBoxVrsta.Size = new System.Drawing.Size(191, 21);
            this.comboBoxVrsta.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(453, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vrsta paketa";
            // 
            // frmUpdateDeletePaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(876, 484);
            this.Controls.Add(this.comboBoxVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxInternet);
            this.Controls.Add(this.comboBoxUgovor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblUgovor);
            this.Controls.Add(this.chBxCaTv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateDeletePaket";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi paket";
            this.Load += new System.EventHandler(this.frmUpdateDeletePaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBxCaTv;
        private System.Windows.Forms.Label lblUgovor;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox comboBoxUgovor;
        private System.Windows.Forms.ComboBox comboBoxInternet;
        private System.Windows.Forms.ComboBox comboBoxVrsta;
        private System.Windows.Forms.Label label3;
    }
}