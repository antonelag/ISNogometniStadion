namespace ISNogometniStadion.WinUI.Sektori
{
    partial class FrmSektori
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
            this.dgvSektori = new System.Windows.Forms.DataGridView();
            this.cbTribine = new System.Windows.Forms.ComboBox();
            this.SektorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaPodaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TribinaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tribina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektori)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSektori);
            this.groupBox1.Location = new System.Drawing.Point(16, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sektori";
            // 
            // dgvSektori
            // 
            this.dgvSektori.AllowUserToAddRows = false;
            this.dgvSektori.AllowUserToDeleteRows = false;
            this.dgvSektori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSektori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SektorID,
            this.Naziv,
            this.Cijena,
            this.CijenaPodaci,
            this.TribinaID,
            this.Tribina});
            this.dgvSektori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSektori.Location = new System.Drawing.Point(4, 19);
            this.dgvSektori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSektori.Name = "dgvSektori";
            this.dgvSektori.ReadOnly = true;
            this.dgvSektori.RowHeadersWidth = 51;
            this.dgvSektori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSektori.Size = new System.Drawing.Size(1027, 418);
            this.dgvSektori.TabIndex = 0;
            this.dgvSektori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvSektori_MouseDoubleClick);
            // 
            // cbTribine
            // 
            this.cbTribine.FormattingEnabled = true;
            this.cbTribine.Location = new System.Drawing.Point(20, 44);
            this.cbTribine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTribine.Name = "cbTribine";
            this.cbTribine.Size = new System.Drawing.Size(664, 24);
            this.cbTribine.TabIndex = 1;
            this.cbTribine.SelectedIndexChanged += new System.EventHandler(this.CbTribine_SelectedIndexChanged);
            // 
            // SektorID
            // 
            this.SektorID.DataPropertyName = "SektorID";
            this.SektorID.HeaderText = "SektorID";
            this.SektorID.MinimumWidth = 6;
            this.SektorID.Name = "SektorID";
            this.SektorID.ReadOnly = true;
            this.SektorID.Visible = false;
            this.SektorID.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 125;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 125;
            // 
            // CijenaPodaci
            // 
            this.CijenaPodaci.DataPropertyName = "CijenaPodaci";
            this.CijenaPodaci.HeaderText = "CijenaPodaci";
            this.CijenaPodaci.MinimumWidth = 6;
            this.CijenaPodaci.Name = "CijenaPodaci";
            this.CijenaPodaci.ReadOnly = true;
            this.CijenaPodaci.Width = 125;
            // 
            // TribinaID
            // 
            this.TribinaID.DataPropertyName = "TribinaID";
            this.TribinaID.HeaderText = "TribinaID";
            this.TribinaID.MinimumWidth = 6;
            this.TribinaID.Name = "TribinaID";
            this.TribinaID.ReadOnly = true;
            this.TribinaID.Visible = false;
            this.TribinaID.Width = 125;
            // 
            // Tribina
            // 
            this.Tribina.DataPropertyName = "Tribina";
            this.Tribina.HeaderText = "Tribina";
            this.Tribina.MinimumWidth = 6;
            this.Tribina.Name = "Tribina";
            this.Tribina.ReadOnly = true;
            this.Tribina.Width = 125;
            // 
            // FrmSektori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbTribine);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSektori";
            this.Text = "frmSektori";
            this.Load += new System.EventHandler(this.FrmSektori_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSektori;
        private System.Windows.Forms.ComboBox cbTribine;
        private System.Windows.Forms.DataGridViewTextBoxColumn SektorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaPodaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn TribinaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tribina;
    }
}