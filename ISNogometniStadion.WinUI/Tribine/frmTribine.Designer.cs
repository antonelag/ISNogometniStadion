namespace ISNogometniStadion.WinUI.Tribine
{
    partial class FrmTribine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTribine = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.TribinaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTribine)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTribine);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tribine";
            // 
            // dgvTribine
            // 
            this.dgvTribine.AllowUserToAddRows = false;
            this.dgvTribine.AllowUserToDeleteRows = false;
            this.dgvTribine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTribine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TribinaID,
            this.Cijena,
            this.Naziv,
            this.StadionID,
            this.Stadion});
            this.dgvTribine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTribine.Location = new System.Drawing.Point(3, 16);
            this.dgvTribine.Name = "dgvTribine";
            this.dgvTribine.ReadOnly = true;
            this.dgvTribine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTribine.Size = new System.Drawing.Size(770, 338);
            this.dgvTribine.TabIndex = 0;
            this.dgvTribine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvTribine_MouseDoubleClick);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(15, 42);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(511, 20);
            this.txtPretraga.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(678, 39);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // TribinaID
            // 
            this.TribinaID.DataPropertyName = "TribinaID";
            this.TribinaID.HeaderText = "TribinaID";
            this.TribinaID.Name = "TribinaID";
            this.TribinaID.ReadOnly = true;
            this.TribinaID.Visible = false;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // StadionID
            // 
            this.StadionID.DataPropertyName = "StadionID";
            this.StadionID.HeaderText = "StadionID";
            this.StadionID.Name = "StadionID";
            this.StadionID.ReadOnly = true;
            this.StadionID.Visible = false;
            // 
            // Stadion
            // 
            this.Stadion.DataPropertyName = "Stadion";
            this.Stadion.HeaderText = "Stadion";
            this.Stadion.Name = "Stadion";
            this.Stadion.ReadOnly = true;
            // 
            // frmTribine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTribine";
            this.Text = "frmTribine";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTribine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvTribine;
        private System.Windows.Forms.DataGridViewTextBoxColumn TribinaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadion;
    }
}