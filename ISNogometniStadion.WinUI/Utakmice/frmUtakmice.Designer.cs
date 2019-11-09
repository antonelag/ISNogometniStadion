namespace ISNogometniStadion.WinUI.Utakmice
{
    partial class FrmUtakmice
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
            this.cbLiga = new System.Windows.Forms.ComboBox();
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
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUtakmice);
            this.groupBox1.Location = new System.Drawing.Point(16, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1305, 400);
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
            this.Liga,
            this.Slika,
            this.SlikaThumb});
            this.dgvUtakmice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUtakmice.Location = new System.Drawing.Point(4, 19);
            this.dgvUtakmice.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.RowHeadersWidth = 51;
            this.dgvUtakmice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtakmice.Size = new System.Drawing.Size(1297, 377);
            this.dgvUtakmice.TabIndex = 0;
            this.dgvUtakmice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvUtakmice_MouseDoubleClick);
            // 
            // cbLiga
            // 
            this.cbLiga.FormattingEnabled = true;
            this.cbLiga.Location = new System.Drawing.Point(20, 33);
            this.cbLiga.Margin = new System.Windows.Forms.Padding(4);
            this.cbLiga.Name = "cbLiga";
            this.cbLiga.Size = new System.Drawing.Size(920, 24);
            this.cbLiga.TabIndex = 3;
            this.cbLiga.SelectedIndexChanged += new System.EventHandler(this.CbLiga_SelectedIndexChanged);
            // 
            // UtakmicaID
            // 
            this.UtakmicaID.DataPropertyName = "UtakmicaID";
            this.UtakmicaID.HeaderText = "UtakmicaID";
            this.UtakmicaID.MinimumWidth = 6;
            this.UtakmicaID.Name = "UtakmicaID";
            this.UtakmicaID.ReadOnly = true;
            this.UtakmicaID.Visible = false;
            this.UtakmicaID.Width = 125;
            // 
            // DomaciTim
            // 
            this.DomaciTim.DataPropertyName = "DomaciTim";
            this.DomaciTim.HeaderText = "DomaciTim";
            this.DomaciTim.MinimumWidth = 6;
            this.DomaciTim.Name = "DomaciTim";
            this.DomaciTim.ReadOnly = true;
            this.DomaciTim.Width = 125;
            // 
            // DomaciTimID
            // 
            this.DomaciTimID.DataPropertyName = "DomaciTimID";
            this.DomaciTimID.HeaderText = "DomaciTimID";
            this.DomaciTimID.MinimumWidth = 6;
            this.DomaciTimID.Name = "DomaciTimID";
            this.DomaciTimID.ReadOnly = true;
            this.DomaciTimID.Visible = false;
            this.DomaciTimID.Width = 125;
            // 
            // GostujuciTim
            // 
            this.GostujuciTim.DataPropertyName = "GostujuciTim";
            this.GostujuciTim.HeaderText = "GostujuciTim";
            this.GostujuciTim.MinimumWidth = 6;
            this.GostujuciTim.Name = "GostujuciTim";
            this.GostujuciTim.ReadOnly = true;
            this.GostujuciTim.Width = 125;
            // 
            // GostujuciTimID
            // 
            this.GostujuciTimID.DataPropertyName = "GostujuciTimID";
            this.GostujuciTimID.HeaderText = "GostujuciTimID";
            this.GostujuciTimID.MinimumWidth = 6;
            this.GostujuciTimID.Name = "GostujuciTimID";
            this.GostujuciTimID.ReadOnly = true;
            this.GostujuciTimID.Visible = false;
            this.GostujuciTimID.Width = 125;
            // 
            // DatumOdigravanja
            // 
            this.DatumOdigravanja.DataPropertyName = "DatumOdigravanja";
            this.DatumOdigravanja.HeaderText = "Datum odigravanja";
            this.DatumOdigravanja.MinimumWidth = 6;
            this.DatumOdigravanja.Name = "DatumOdigravanja";
            this.DatumOdigravanja.ReadOnly = true;
            this.DatumOdigravanja.Width = 125;
            // 
            // VrijemeOdigravanja
            // 
            this.VrijemeOdigravanja.DataPropertyName = "VrijemeOdigravanja";
            this.VrijemeOdigravanja.HeaderText = "Vrijeme odigravanja";
            this.VrijemeOdigravanja.MinimumWidth = 6;
            this.VrijemeOdigravanja.Name = "VrijemeOdigravanja";
            this.VrijemeOdigravanja.ReadOnly = true;
            this.VrijemeOdigravanja.Width = 125;
            // 
            // Stadion
            // 
            this.Stadion.DataPropertyName = "stadion";
            this.Stadion.HeaderText = "Stadion";
            this.Stadion.MinimumWidth = 6;
            this.Stadion.Name = "Stadion";
            this.Stadion.ReadOnly = true;
            this.Stadion.Width = 125;
            // 
            // StadionID
            // 
            this.StadionID.DataPropertyName = "StadionID";
            this.StadionID.HeaderText = "StadionID";
            this.StadionID.MinimumWidth = 6;
            this.StadionID.Name = "StadionID";
            this.StadionID.ReadOnly = true;
            this.StadionID.Visible = false;
            this.StadionID.Width = 125;
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
            // Liga
            // 
            this.Liga.DataPropertyName = "Liga";
            this.Liga.HeaderText = "Vrsta natjecanja";
            this.Liga.MinimumWidth = 6;
            this.Liga.Name = "Liga";
            this.Liga.ReadOnly = true;
            this.Liga.Width = 125;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 6;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Visible = false;
            this.Slika.Width = 125;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.MinimumWidth = 6;
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.ReadOnly = true;
            this.SlikaThumb.Width = 125;
            // 
            // FrmUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 554);
            this.Controls.Add(this.cbLiga);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUtakmice";
            this.Text = "frmUtakmice";
            this.Load += new System.EventHandler(this.FrmUtakmice_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.ComboBox cbLiga;
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
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
    }
}