namespace ISNogometniStadion.WinUI.Gradovi
{
    partial class FrmGradovi
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
            this.dgvGradovi = new System.Windows.Forms.DataGridView();
            this.GradID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrzavaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGradovi);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gradovi";
            // 
            // dgvGradovi
            // 
            this.dgvGradovi.AllowUserToAddRows = false;
            this.dgvGradovi.AllowUserToDeleteRows = false;
            this.dgvGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradID,
            this.Naziv,
            this.Drzava,
            this.DrzavaID});
            this.dgvGradovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGradovi.Location = new System.Drawing.Point(3, 16);
            this.dgvGradovi.Name = "dgvGradovi";
            this.dgvGradovi.ReadOnly = true;
            this.dgvGradovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradovi.Size = new System.Drawing.Size(770, 341);
            this.dgvGradovi.TabIndex = 0;
            this.dgvGradovi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvGradovi_MouseDoubleClick);
            // 
            // GradID
            // 
            this.GradID.DataPropertyName = "gradID";
            this.GradID.HeaderText = "GradID";
            this.GradID.Name = "GradID";
            this.GradID.ReadOnly = true;
            this.GradID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv Grada";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Drzava
            // 
            this.Drzava.DataPropertyName = "Drzava";
            this.Drzava.HeaderText = "Naziv Države";
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            // 
            // DrzavaID
            // 
            this.DrzavaID.DataPropertyName = "DrzavaID";
            this.DrzavaID.HeaderText = "DrzavaID";
            this.DrzavaID.Name = "DrzavaID";
            this.DrzavaID.ReadOnly = true;
            this.DrzavaID.Visible = false;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(15, 33);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(422, 20);
            this.txtPretraga.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(696, 30);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // frmGradovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGradovi";
            this.Text = "frmGradovi";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGradovi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaID;
    }
}