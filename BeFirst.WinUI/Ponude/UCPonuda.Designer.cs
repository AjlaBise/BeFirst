namespace BeFirst.WinUI.Ponude
{
    partial class UCPonuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPonuda));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbPonude = new System.Windows.Forms.GroupBox();
            this.dgvPonuda = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajPonudu = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPonude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(88, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ponude";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 127);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gbPonude
            // 
            this.gbPonude.Controls.Add(this.dgvPonuda);
            this.gbPonude.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPonude.ForeColor = System.Drawing.Color.Teal;
            this.gbPonude.Location = new System.Drawing.Point(358, 227);
            this.gbPonude.Name = "gbPonude";
            this.gbPonude.Size = new System.Drawing.Size(480, 295);
            this.gbPonude.TabIndex = 2;
            this.gbPonude.TabStop = false;
            this.gbPonude.Text = "Ponude";
            // 
            // dgvPonuda
            // 
            this.dgvPonuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dgvPonuda.Location = new System.Drawing.Point(6, 23);
            this.dgvPonuda.Name = "dgvPonuda";
            this.dgvPonuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPonuda.Size = new System.Drawing.Size(468, 266);
            this.dgvPonuda.TabIndex = 0;
            this.dgvPonuda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPonuda_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // btnDodajPonudu
            // 
            this.btnDodajPonudu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPonudu.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPonudu.ForeColor = System.Drawing.Color.Teal;
            this.btnDodajPonudu.Location = new System.Drawing.Point(719, 88);
            this.btnDodajPonudu.Name = "btnDodajPonudu";
            this.btnDodajPonudu.Size = new System.Drawing.Size(113, 30);
            this.btnDodajPonudu.TabIndex = 3;
            this.btnDodajPonudu.Text = "+ Dodaj";
            this.btnDodajPonudu.UseVisualStyleBackColor = true;
            this.btnDodajPonudu.Click += new System.EventHandler(this.btnDodajPonudu_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(595, 158);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(192, 20);
            this.txtPretraga.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(793, 151);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UCPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnDodajPonudu);
            this.Controls.Add(this.gbPonude);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UCPonuda";
            this.Size = new System.Drawing.Size(930, 557);
            this.Load += new System.EventHandler(this.UCPonuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPonude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbPonude;
        private System.Windows.Forms.DataGridView dgvPonuda;
        private System.Windows.Forms.Button btnDodajPonudu;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
