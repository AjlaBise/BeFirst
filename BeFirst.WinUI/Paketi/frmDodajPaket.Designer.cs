namespace BeFirst.WinUI.Paketi
{
    partial class frmDodajPaket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajPaket));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUgovor = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chBoxVaTv = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxUgovor = new System.Windows.Forms.ComboBox();
            this.lblInternet = new System.Windows.Forms.Label();
            this.comboBoxInternet = new System.Windows.Forms.ComboBox();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.comboBoxVrsta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(198, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj paket";
            // 
            // lblUgovor
            // 
            this.lblUgovor.AutoSize = true;
            this.lblUgovor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUgovor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUgovor.Location = new System.Drawing.Point(477, 251);
            this.lblUgovor.Name = "lblUgovor";
            this.lblUgovor.Size = new System.Drawing.Size(63, 20);
            this.lblUgovor.TabIndex = 5;
            this.lblUgovor.Text = "Ugovor";
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.Teal;
            this.btnSpremi.Location = new System.Drawing.Point(664, 364);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(134, 37);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 134);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // chBoxVaTv
            // 
            this.chBoxVaTv.AutoSize = true;
            this.chBoxVaTv.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxVaTv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chBoxVaTv.Location = new System.Drawing.Point(481, 148);
            this.chBoxVaTv.Name = "chBoxVaTv";
            this.chBoxVaTv.Size = new System.Drawing.Size(69, 24);
            this.chBoxVaTv.TabIndex = 9;
            this.chBoxVaTv.Text = "CaTv";
            this.chBoxVaTv.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxUgovor
            // 
            this.comboBoxUgovor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUgovor.FormattingEnabled = true;
            this.comboBoxUgovor.Location = new System.Drawing.Point(582, 249);
            this.comboBoxUgovor.Name = "comboBoxUgovor";
            this.comboBoxUgovor.Size = new System.Drawing.Size(211, 21);
            this.comboBoxUgovor.TabIndex = 11;
            this.comboBoxUgovor.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxUgovor_Validating);
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInternet.Location = new System.Drawing.Point(477, 199);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(71, 20);
            this.lblInternet.TabIndex = 3;
            this.lblInternet.Text = "Internet";
            // 
            // comboBoxInternet
            // 
            this.comboBoxInternet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInternet.FormattingEnabled = true;
            this.comboBoxInternet.Location = new System.Drawing.Point(582, 197);
            this.comboBoxInternet.Name = "comboBoxInternet";
            this.comboBoxInternet.Size = new System.Drawing.Size(211, 21);
            this.comboBoxInternet.TabIndex = 10;
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrsta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVrsta.Location = new System.Drawing.Point(477, 303);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(104, 20);
            this.lblVrsta.TabIndex = 12;
            this.lblVrsta.Text = "Vrsta paketa";
            // 
            // comboBoxVrsta
            // 
            this.comboBoxVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVrsta.FormattingEnabled = true;
            this.comboBoxVrsta.Location = new System.Drawing.Point(582, 301);
            this.comboBoxVrsta.Name = "comboBoxVrsta";
            this.comboBoxVrsta.Size = new System.Drawing.Size(211, 21);
            this.comboBoxVrsta.TabIndex = 13;
            this.comboBoxVrsta.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrsta_SelectedIndexChanged);
            // 
            // frmDodajPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(904, 486);
            this.Controls.Add(this.comboBoxVrsta);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.comboBoxUgovor);
            this.Controls.Add(this.comboBoxInternet);
            this.Controls.Add(this.chBoxVaTv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblUgovor);
            this.Controls.Add(this.lblInternet);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajPaket";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novi paket";
            this.Load += new System.EventHandler(this.frmDodajPaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUgovor;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chBoxVaTv;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox comboBoxUgovor;
        private System.Windows.Forms.ComboBox comboBoxInternet;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.ComboBox comboBoxVrsta;
    }
}