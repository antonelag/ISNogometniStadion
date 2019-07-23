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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.UtakmicaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomaciTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomaciTimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GostujuciTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GostujuciTimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdigravanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeOdigravanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.StadionID});
            this.dgvUtakmice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUtakmice.Location = new System.Drawing.Point(3, 16);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtakmice.Size = new System.Drawing.Size(770, 306);
            this.dgvUtakmice.TabIndex = 0;
            this.dgvUtakmice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvUtakmice_MouseDoubleClick);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(15, 27);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(473, 20);
            this.txtPretraga.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(710, 27);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
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
            // frmUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUtakmice";
            this.Text = "frmUtakmice";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UtakmicaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomaciTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomaciTimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GostujuciTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn GostujuciTimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdigravanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeOdigravanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadion;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadionID;
    }
}