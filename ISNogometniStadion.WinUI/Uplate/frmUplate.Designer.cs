namespace ISNogometniStadion.WinUI.Uplate
{
    partial class FrmUplate
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
            this.dgvUplate = new System.Windows.Forms.DataGridView();
            this.UplataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UlaznicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UplataPodaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulaznica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbUtakmice = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUplate);
            this.groupBox1.Location = new System.Drawing.Point(0, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uplate";
            // 
            // dgvUplate
            // 
            this.dgvUplate.AllowUserToAddRows = false;
            this.dgvUplate.AllowUserToDeleteRows = false;
            this.dgvUplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UplataID,
            this.UlaznicaID,
            this.UplataPodaci,
            this.Iznos,
            this.Ulaznica});
            this.dgvUplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUplate.Location = new System.Drawing.Point(3, 18);
            this.dgvUplate.Name = "dgvUplate";
            this.dgvUplate.ReadOnly = true;
            this.dgvUplate.RowHeadersWidth = 51;
            this.dgvUplate.RowTemplate.Height = 24;
            this.dgvUplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUplate.Size = new System.Drawing.Size(852, 477);
            this.dgvUplate.TabIndex = 0;
            // 
            // UplataID
            // 
            this.UplataID.DataPropertyName = "UplataID";
            this.UplataID.HeaderText = "UplataID";
            this.UplataID.MinimumWidth = 6;
            this.UplataID.Name = "UplataID";
            this.UplataID.ReadOnly = true;
            this.UplataID.Visible = false;
            this.UplataID.Width = 125;
            // 
            // UlaznicaID
            // 
            this.UlaznicaID.DataPropertyName = "UlaznicaID";
            this.UlaznicaID.HeaderText = "UlaznicaID";
            this.UlaznicaID.MinimumWidth = 6;
            this.UlaznicaID.Name = "UlaznicaID";
            this.UlaznicaID.ReadOnly = true;
            this.UlaznicaID.Visible = false;
            this.UlaznicaID.Width = 125;
            // 
            // UplataPodaci
            // 
            this.UplataPodaci.DataPropertyName = "UplataPodaci";
            this.UplataPodaci.HeaderText = "Podaci o ulaznici";
            this.UplataPodaci.MinimumWidth = 6;
            this.UplataPodaci.Name = "UplataPodaci";
            this.UplataPodaci.ReadOnly = true;
            this.UplataPodaci.Width = 300;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.MinimumWidth = 6;
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            this.Iznos.Width = 125;
            // 
            // Ulaznica
            // 
            this.Ulaznica.DataPropertyName = "Ulaznica";
            this.Ulaznica.HeaderText = "Ulaznica";
            this.Ulaznica.MinimumWidth = 6;
            this.Ulaznica.Name = "Ulaznica";
            this.Ulaznica.ReadOnly = true;
            this.Ulaznica.Visible = false;
            this.Ulaznica.Width = 125;
            // 
            // cbUtakmice
            // 
            this.cbUtakmice.FormattingEnabled = true;
            this.cbUtakmice.Location = new System.Drawing.Point(12, 39);
            this.cbUtakmice.Name = "cbUtakmice";
            this.cbUtakmice.Size = new System.Drawing.Size(312, 24);
            this.cbUtakmice.TabIndex = 1;
            this.cbUtakmice.SelectionChangeCommitted += new System.EventHandler(this.CbUtakmice_SelectionChangeCommitted);
            // 
            // FrmUplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 597);
            this.Controls.Add(this.cbUtakmice);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUplate";
            this.Text = "frmUplate";
            this.Load += new System.EventHandler(this.FrmUplate_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUplate;
        private System.Windows.Forms.ComboBox cbUtakmice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UplataID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlaznicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UplataPodaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulaznica;
    }
}