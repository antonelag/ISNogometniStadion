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
            this.cbLige = new System.Windows.Forms.ComboBox();
            this.LigaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrzavaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLige)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLige);
            this.groupBox1.Location = new System.Drawing.Point(2, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 342);
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
            this.dgvLige.Location = new System.Drawing.Point(3, 16);
            this.dgvLige.Name = "dgvLige";
            this.dgvLige.ReadOnly = true;
            this.dgvLige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLige.Size = new System.Drawing.Size(780, 323);
            this.dgvLige.TabIndex = 0;
            this.dgvLige.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvLige_MouseDoubleClick);
            // 
            // cbLige
            // 
            this.cbLige.FormattingEnabled = true;
            this.cbLige.Location = new System.Drawing.Point(12, 40);
            this.cbLige.Name = "cbLige";
            this.cbLige.Size = new System.Drawing.Size(160, 21);
            this.cbLige.TabIndex = 1;
            this.cbLige.SelectedIndexChanged += new System.EventHandler(this.CbLige_SelectedIndexChanged);
            // 
            // LigaID
            // 
            this.LigaID.DataPropertyName = "LigaID";
            this.LigaID.HeaderText = "LigaID";
            this.LigaID.Name = "LigaID";
            this.LigaID.ReadOnly = true;
            this.LigaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // DrzavaID
            // 
            this.DrzavaID.DataPropertyName = "DrzavaID";
            this.DrzavaID.HeaderText = "DrzavaID";
            this.DrzavaID.Name = "DrzavaID";
            this.DrzavaID.ReadOnly = true;
            this.DrzavaID.Visible = false;
            // 
            // Drzava
            // 
            this.Drzava.DataPropertyName = "Drzava";
            this.Drzava.HeaderText = "Drzava";
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            // 
            // frmLige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbLige);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLige";
            this.Text = "frmLige";
            this.Load += new System.EventHandler(this.FrmLige_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLige;
        private System.Windows.Forms.ComboBox cbLige;
        private System.Windows.Forms.DataGridViewTextBoxColumn LigaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
    }
}