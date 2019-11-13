namespace ISNogometniStadion.WinUI.Lige
{
    partial class FrmLige
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
            this.dgvLige = new System.Windows.Forms.DataGridView();
            this.LigaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrzavaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDrzave = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLige)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLige);
            this.groupBox1.Location = new System.Drawing.Point(3, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1048, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lige";
            // 
            // dgvLige
            // 
            this.dgvLige.AllowUserToAddRows = false;
            this.dgvLige.AllowUserToDeleteRows = false;
            this.dgvLige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LigaID,
            this.Naziv,
            this.DrzavaID,
            this.Drzava});
            this.dgvLige.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLige.Location = new System.Drawing.Point(4, 19);
            this.dgvLige.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLige.Name = "dgvLige";
            this.dgvLige.ReadOnly = true;
            this.dgvLige.RowHeadersWidth = 51;
            this.dgvLige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLige.Size = new System.Drawing.Size(1040, 398);
            this.dgvLige.TabIndex = 0;
            this.dgvLige.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvLige_MouseDoubleClick);
            // 
            // LigaID
            // 
            this.LigaID.DataPropertyName = "LigaID";
            this.LigaID.HeaderText = "LigaID";
            this.LigaID.MinimumWidth = 6;
            this.LigaID.Name = "LigaID";
            this.LigaID.ReadOnly = true;
            this.LigaID.Visible = false;
            this.LigaID.Width = 125;
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
            // DrzavaID
            // 
            this.DrzavaID.DataPropertyName = "DrzavaID";
            this.DrzavaID.HeaderText = "DrzavaID";
            this.DrzavaID.MinimumWidth = 6;
            this.DrzavaID.Name = "DrzavaID";
            this.DrzavaID.ReadOnly = true;
            this.DrzavaID.Visible = false;
            this.DrzavaID.Width = 125;
            // 
            // Drzava
            // 
            this.Drzava.DataPropertyName = "Drzava";
            this.Drzava.HeaderText = "Drzava";
            this.Drzava.MinimumWidth = 6;
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            this.Drzava.Width = 125;
            // 
            // cbDrzave
            // 
            this.cbDrzave.FormattingEnabled = true;
            this.cbDrzave.Location = new System.Drawing.Point(16, 49);
            this.cbDrzave.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrzave.Name = "cbDrzave";
            this.cbDrzave.Size = new System.Drawing.Size(212, 24);
            this.cbDrzave.TabIndex = 1;
            this.cbDrzave.SelectedIndexChanged += new System.EventHandler(this.CbDrzave_SelectedIndexChanged);
            // 
            // FrmLige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbDrzave);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLige";
            this.Text = "frmLige";
            this.Load += new System.EventHandler(this.FrmLige_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLige;
        private System.Windows.Forms.ComboBox cbDrzave;
        private System.Windows.Forms.DataGridViewTextBoxColumn LigaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
    }
}