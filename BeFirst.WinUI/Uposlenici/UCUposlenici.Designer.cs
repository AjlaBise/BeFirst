namespace BeFirst.WinUI.Uposlenici
{
    partial class UCUposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUposlenici));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUposlenici = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajUposlenika = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(351, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uposlenici";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUposlenici);
            this.groupBox1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(95, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uposlenici";
            // 
            // dgvUposlenici
            // 
            this.dgvUposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dgvUposlenici.Location = new System.Drawing.Point(21, 27);
            this.dgvUposlenici.Name = "dgvUposlenici";
            this.dgvUposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUposlenici.Size = new System.Drawing.Size(685, 274);
            this.dgvUposlenici.TabIndex = 0;
            this.dgvUposlenici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUposlenici_CellContentClick);
            this.dgvUposlenici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUposlenici_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // btnDodajUposlenika
            // 
            this.btnDodajUposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajUposlenika.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUposlenika.ForeColor = System.Drawing.Color.Teal;
            this.btnDodajUposlenika.Location = new System.Drawing.Point(698, 92);
            this.btnDodajUposlenika.Name = "btnDodajUposlenika";
            this.btnDodajUposlenika.Size = new System.Drawing.Size(129, 32);
            this.btnDodajUposlenika.TabIndex = 2;
            this.btnDodajUposlenika.Text = "+ Dodaj";
            this.btnDodajUposlenika.UseVisualStyleBackColor = true;
            this.btnDodajUposlenika.Click += new System.EventHandler(this.btnDodajUposlenika_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.Color.Teal;
            this.txtPretraga.Location = new System.Drawing.Point(580, 163);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(205, 27);
            this.txtPretraga.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(791, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UCUposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnDodajUposlenika);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UCUposlenici";
            this.Size = new System.Drawing.Size(889, 553);
            this.Load += new System.EventHandler(this.UCUposlenici_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajUposlenika;
        private System.Windows.Forms.DataGridView dgvUposlenici;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
