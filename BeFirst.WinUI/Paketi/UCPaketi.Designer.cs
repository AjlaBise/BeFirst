namespace BeFirst.WinUI.Paketi
{
    partial class UCPaketi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPaketi));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBPaketi = new System.Windows.Forms.GroupBox();
            this.dgvPaketi = new System.Windows.Forms.DataGridView();
            this.btnDodajPaket = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBPaketi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(138, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paketi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 155);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gBPaketi
            // 
            this.gBPaketi.Controls.Add(this.dgvPaketi);
            this.gBPaketi.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPaketi.ForeColor = System.Drawing.Color.Teal;
            this.gBPaketi.Location = new System.Drawing.Point(356, 223);
            this.gBPaketi.Name = "gBPaketi";
            this.gBPaketi.Size = new System.Drawing.Size(506, 288);
            this.gBPaketi.TabIndex = 2;
            this.gBPaketi.TabStop = false;
            this.gBPaketi.Text = "Paketi";
            // 
            // dgvPaketi
            // 
            this.dgvPaketi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaketi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dgvPaketi.Location = new System.Drawing.Point(17, 35);
            this.dgvPaketi.Name = "dgvPaketi";
            this.dgvPaketi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaketi.Size = new System.Drawing.Size(467, 238);
            this.dgvPaketi.TabIndex = 0;
            this.dgvPaketi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPaketi_MouseDoubleClick);
            // 
            // btnDodajPaket
            // 
            this.btnDodajPaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPaket.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPaket.ForeColor = System.Drawing.Color.Teal;
            this.btnDodajPaket.Location = new System.Drawing.Point(690, 129);
            this.btnDodajPaket.Name = "btnDodajPaket";
            this.btnDodajPaket.Size = new System.Drawing.Size(150, 31);
            this.btnDodajPaket.TabIndex = 3;
            this.btnDodajPaket.Text = "+ Dodaj";
            this.btnDodajPaket.UseVisualStyleBackColor = true;
            this.btnDodajPaket.Click += new System.EventHandler(this.btnDodajPaket_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // UCPaketi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnDodajPaket);
            this.Controls.Add(this.gBPaketi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UCPaketi";
            this.Size = new System.Drawing.Size(925, 549);
            this.Load += new System.EventHandler(this.UCPaketi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBPaketi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaketi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gBPaketi;
        private System.Windows.Forms.DataGridView dgvPaketi;
        private System.Windows.Forms.Button btnDodajPaket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
