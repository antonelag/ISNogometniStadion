namespace ISNogometniStadion.WinUI.Utakmice
{
    partial class frmUtakmice
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
            this.dgvUtakmice = new System.Windows.Forms.DataGridView();
            this.UtakmicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomaciTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomaciTimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GostujuciTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GostujuciTimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdigravanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeOdigravanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LigaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbLiga = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUtakmice);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utakmice";
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.AllowUserToAddRows = false;
            this.dgvUtakmice.AllowUserToDeleteRows = false;
            this.dgvUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtakmice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UtakmicaID,
            this.DomaciTim,
            this.DomaciTimID,
            this.GostujuciTim,
            this.GostujuciTimID,
            this.DatumOdigravanja,
            this.VrijemeOdigravanja,
            this.Stadion,
            this.StadionID,
            this.LigaID,
            this.Liga});
            this.dgvUtakmice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUtakmice.Location = new System.Drawing.Point(3, 16);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtakmice.Size = new System.Drawing.Size(770, 306);
            this.dgvUtakmice.TabIndex = 0;
            this.dgvUtakmice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvUtakmice_MouseDoubleClick);
            // 
            // UtakmicaID
            // 
            this.UtakmicaID.DataPropertyName = "UtakmicaID";
            this.UtakmicaID.HeaderText = "UtakmicaID";
            this.UtakmicaID.Name = "UtakmicaID";
            this.UtakmicaID.ReadOnly = true;
            this.UtakmicaID.Visible = false;
            // 
            // DomaciTim
            // 
            this.DomaciTim.DataPropertyName = "DomaciTim";
            this.DomaciTim.HeaderText = "DomaciTim";
            this.DomaciTim.Name = "DomaciTim";
            this.DomaciTim.ReadOnly = true;
            // 
            // DomaciTimID
            // 
            this.DomaciTimID.DataPropertyName = "DomaciTimID";
            this.DomaciTimID.HeaderText = "DomaciTimID";
            this.DomaciTimID.Name = "DomaciTimID";
            this.DomaciTimID.ReadOnly = true;
            this.DomaciTimID.Visible = false;
            // 
            // GostujuciTim
            // 
            this.GostujuciTim.DataPropertyName = "GostujuciTim";
            this.GostujuciTim.HeaderText = "GostujuciTim";
            this.GostujuciTim.Name = "GostujuciTim";
            this.GostujuciTim.ReadOnly = true;
            // 
            // GostujuciTimID
            // 
            this.GostujuciTimID.DataPropertyName = "GostujuciTimID";
            this.GostujuciTimID.HeaderText = "GostujuciTimID";
            this.GostujuciTimID.Name = "GostujuciTimID";
            this.GostujuciTimID.ReadOnly = true;
            this.GostujuciTimID.Visible = false;
            // 
            // DatumOdigravanja
            // 
            this.DatumOdigravanja.DataPropertyName = "DatumOdigravanja";
            this.DatumOdigravanja.HeaderText = "Datum odigravanja";
            this.DatumOdigravanja.Name = "DatumOdigravanja";
            this.DatumOdigravanja.ReadOnly = true;
            // 
            // VrijemeOdigravanja
            // 
            this.VrijemeOdigravanja.DataPropertyName = "VrijemeOdigravanja";
            this.VrijemeOdigravanja.HeaderText = "Vrijeme odigravanja";
            this.VrijemeOdigravanja.Name = "VrijemeOdigravanja";
            this.VrijemeOdigravanja.ReadOnly = true;
            // 
            // Stadion
            // 
            this.Stadion.DataPropertyName = "stadion";
            this.Stadion.HeaderText = "Stadion";
            this.Stadion.Name = "Stadion";
            this.Stadion.ReadOnly = true;
            // 
            // StadionID
            // 
            this.StadionID.DataPropertyName = "StadionID";
            this.StadionID.HeaderText = "StadionID";
            this.StadionID.Name = "StadionID";
            this.StadionID.ReadOnly = true;
            this.StadionID.Visible = false;
            // 
            // LigaID
            // 
            this.LigaID.DataPropertyName = "LigaID";
            this.LigaID.HeaderText = "LigaID";
            this.LigaID.Name = "LigaID";
            this.LigaID.ReadOnly = true;
            this.LigaID.Visible = false;
            // 
            // Liga
            // 
            this.Liga.DataPropertyName = "Liga";
            this.Liga.HeaderText = "Vrsta natjecanja";
            this.Liga.Name = "Liga";
            this.Liga.ReadOnly = true;
            // 
            // cbLiga
            // 
            this.cbLiga.FormattingEnabled = true;
            this.cbLiga.Location = new System.Drawing.Point(15, 27);
            this.cbLiga.Name = "cbLiga";
            this.cbLiga.Size = new System.Drawing.Size(373, 21);
            this.cbLiga.TabIndex = 3;
            this.cbLiga.SelectedIndexChanged += new System.EventHandler(this.CbLiga_SelectedIndexChanged);
            // 
            // frmUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbLiga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUtakmice";
            this.Text = "frmUtakmice";
            this.Load += new System.EventHandler(this.FrmUtakmice_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UtakmicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomaciTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomaciTimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GostujuciTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn GostujuciTimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdigravanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeOdigravanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LigaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liga;
        private System.Windows.Forms.ComboBox cbLiga;
    }
}