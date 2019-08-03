namespace ISNogometniStadion.WinUI.Ulaznice
{
    partial class frmUlaznice
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
            this.dgvUlaznice = new System.Windows.Forms.DataGridView();
            this.UlaznicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SjedaloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sjedalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UtakmicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utakmica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKupnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeKupnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKorisniciPretraga = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlaznice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUlaznice);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulaznice";
            // 
            // dgvUlaznice
            // 
            this.dgvUlaznice.AllowUserToAddRows = false;
            this.dgvUlaznice.AllowUserToDeleteRows = false;
            this.dgvUlaznice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUlaznice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UlaznicaID,
            this.SjedaloID,
            this.Sjedalo,
            this.UtakmicaID,
            this.Utakmica,
            this.KorisnikID,
            this.Korisnik,
            this.DatumKupnje,
            this.VrijemeKupnje});
            this.dgvUlaznice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUlaznice.Location = new System.Drawing.Point(3, 16);
            this.dgvUlaznice.Name = "dgvUlaznice";
            this.dgvUlaznice.ReadOnly = true;
            this.dgvUlaznice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUlaznice.Size = new System.Drawing.Size(749, 351);
            this.dgvUlaznice.TabIndex = 0;
            this.dgvUlaznice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvUlaznice_MouseDoubleClick);
            // 
            // UlaznicaID
            // 
            this.UlaznicaID.DataPropertyName = "UlaznicaID";
            this.UlaznicaID.HeaderText = "UlaznicaID";
            this.UlaznicaID.Name = "UlaznicaID";
            this.UlaznicaID.ReadOnly = true;
            this.UlaznicaID.Visible = false;
            // 
            // SjedaloID
            // 
            this.SjedaloID.DataPropertyName = "SjedaloID";
            this.SjedaloID.HeaderText = "SjedaloID";
            this.SjedaloID.Name = "SjedaloID";
            this.SjedaloID.ReadOnly = true;
            this.SjedaloID.Visible = false;
            // 
            // Sjedalo
            // 
            this.Sjedalo.DataPropertyName = "Oznaka";
            this.Sjedalo.HeaderText = "Sjedalo";
            this.Sjedalo.Name = "Sjedalo";
            this.Sjedalo.ReadOnly = true;
            // 
            // UtakmicaID
            // 
            this.UtakmicaID.DataPropertyName = "UtakmicaID";
            this.UtakmicaID.HeaderText = "UtakmicaID";
            this.UtakmicaID.Name = "UtakmicaID";
            this.UtakmicaID.ReadOnly = true;
            this.UtakmicaID.Visible = false;
            // 
            // Utakmica
            // 
            this.Utakmica.DataPropertyName = "Utakmica";
            this.Utakmica.HeaderText = "Utakmica";
            this.Utakmica.Name = "Utakmica";
            this.Utakmica.ReadOnly = true;
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // DatumKupnje
            // 
            this.DatumKupnje.DataPropertyName = "DatumKupnje";
            this.DatumKupnje.HeaderText = "DatumKupnje";
            this.DatumKupnje.Name = "DatumKupnje";
            this.DatumKupnje.ReadOnly = true;
            // 
            // VrijemeKupnje
            // 
            this.VrijemeKupnje.DataPropertyName = "VrijemeKupnje";
            this.VrijemeKupnje.HeaderText = "VrijemeKupnje";
            this.VrijemeKupnje.Name = "VrijemeKupnje";
            this.VrijemeKupnje.ReadOnly = true;
            // 
            // cbKorisniciPretraga
            // 
            this.cbKorisniciPretraga.FormattingEnabled = true;
            this.cbKorisniciPretraga.Location = new System.Drawing.Point(15, 30);
            this.cbKorisniciPretraga.Name = "cbKorisniciPretraga";
            this.cbKorisniciPretraga.Size = new System.Drawing.Size(121, 21);
            this.cbKorisniciPretraga.TabIndex = 3;
            this.cbKorisniciPretraga.SelectedIndexChanged += new System.EventHandler(this.CbKorisniciPretraga_SelectedIndexChanged);
            // 
            // frmUlaznice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.cbKorisniciPretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUlaznice";
            this.Text = "frmUlaznice";
            this.Load += new System.EventHandler(this.FrmUlaznice_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlaznice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUlaznice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlaznicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SjedaloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sjedalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UtakmicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utakmica;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKupnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeKupnje;
        private System.Windows.Forms.ComboBox cbKorisniciPretraga;
    }
}