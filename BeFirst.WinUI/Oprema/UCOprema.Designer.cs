namespace BeFirst.WinUI.Oprema
{
    partial class UCOprema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOprema));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxOprema = new System.Windows.Forms.GroupBox();
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOprema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(64, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oprema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 141);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxOprema
            // 
            this.groupBoxOprema.Controls.Add(this.dgvOprema);
            this.groupBoxOprema.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOprema.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxOprema.Location = new System.Drawing.Point(287, 273);
            this.groupBoxOprema.Name = "groupBoxOprema";
            this.groupBoxOprema.Size = new System.Drawing.Size(558, 262);
            this.groupBoxOprema.TabIndex = 2;
            this.groupBoxOprema.TabStop = false;
            this.groupBoxOprema.Text = "Oprema";
            // 
            // dgvOprema
            // 
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dgvOprema.Location = new System.Drawing.Point(7, 24);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOprema.Size = new System.Drawing.Size(545, 232);
            this.dgvOprema.TabIndex = 0;
            this.dgvOprema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOprema_CellContentClick);
            this.dgvOprema.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvOprema_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(695, 124);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(144, 41);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "+ Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPretraga.Location = new System.Drawing.Point(618, 216);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(175, 24);
            this.txtPretraga.TabIndex = 4;
            // 
            // btnPretraga
            // 
            this.btnPretraga.FlatAppearance.BorderSize = 0;
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraga.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraga.Image")));
            this.btnPretraga.Location = new System.Drawing.Point(811, 219);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(34, 21);
            this.btnPretraga.TabIndex = 5;
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // UCOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBoxOprema);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UCOprema";
            this.Size = new System.Drawing.Size(903, 582);
            this.Load += new System.EventHandler(this.UCOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOprema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxOprema;
        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
