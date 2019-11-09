namespace ISNogometniStadion.WinUI.Izvješća
{
    partial class FrmGodineIStadioniIzvjesce
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
            this.dgvIzvješće = new System.Windows.Forms.DataGridView();
            this.Stadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojProdanihUlaznica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaZarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvješće)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIzvješće);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1272, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ukupni prihodi";
            // 
            // dgvIzvješće
            // 
            this.dgvIzvješće.AllowUserToAddRows = false;
            this.dgvIzvješće.AllowUserToDeleteRows = false;
            this.dgvIzvješće.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvješće.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stadion,
            this.Grad,
            this.BrojProdanihUlaznica,
            this.UkupnaZarada});
            this.dgvIzvješće.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzvješće.Location = new System.Drawing.Point(3, 18);
            this.dgvIzvješće.Name = "dgvIzvješće";
            this.dgvIzvješće.ReadOnly = true;
            this.dgvIzvješće.RowHeadersWidth = 51;
            this.dgvIzvješće.RowTemplate.Height = 24;
            this.dgvIzvješće.Size = new System.Drawing.Size(1266, 530);
            this.dgvIzvješće.TabIndex = 0;
            // 
            // Stadion
            // 
            this.Stadion.DataPropertyName = "Stadion";
            this.Stadion.HeaderText = "Naziv stadiona";
            this.Stadion.MinimumWidth = 6;
            this.Stadion.Name = "Stadion";
            this.Stadion.ReadOnly = true;
            this.Stadion.Width = 125;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.MinimumWidth = 6;
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.Width = 125;
            // 
            // BrojProdanihUlaznica
            // 
            this.BrojProdanihUlaznica.DataPropertyName = "BrojProdanihUlaznica";
            this.BrojProdanihUlaznica.HeaderText = "Broj prodanih ulaznica";
            this.BrojProdanihUlaznica.MinimumWidth = 6;
            this.BrojProdanihUlaznica.Name = "BrojProdanihUlaznica";
            this.BrojProdanihUlaznica.ReadOnly = true;
            this.BrojProdanihUlaznica.Width = 125;
            // 
            // UkupnaZarada
            // 
            this.UkupnaZarada.DataPropertyName = "Zarada";
            this.UkupnaZarada.HeaderText = "Ukupna zarada";
            this.UkupnaZarada.MinimumWidth = 6;
            this.UkupnaZarada.Name = "UkupnaZarada";
            this.UkupnaZarada.ReadOnly = true;
            this.UkupnaZarada.Width = 125;
            // 
            // cbGodina
            // 
            this.cbGodina.FormattingEnabled = true;
            this.cbGodina.Location = new System.Drawing.Point(15, 42);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(280, 24);
            this.cbGodina.TabIndex = 1;
            this.cbGodina.SelectedIndexChanged += new System.EventHandler(this.CbGodina_SelectedIndexChanged);
            // 
            // FrmGodineIStadioniIzvjesce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 668);
            this.Controls.Add(this.cbGodina);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGodineIStadioniIzvjesce";
            this.Text = "frmGodineIStadioniIzvjesce";
            this.Load += new System.EventHandler(this.FrmGodineIStadioniIzvjesce_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvješće)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIzvješće;
        private System.Windows.Forms.ComboBox cbGodina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojProdanihUlaznica;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaZarada;
    }
}