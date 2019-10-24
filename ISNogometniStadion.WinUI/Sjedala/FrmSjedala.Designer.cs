namespace ISNogometniStadion.WinUI.Sjedala
{
    partial class FrmSjedala
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
            this.dgvSjedala = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.txtPretrazi = new System.Windows.Forms.Button();
            this.sjedaloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sektor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SektorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedala)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSjedala);
            this.groupBox1.Location = new System.Drawing.Point(5, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1045, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sjedala";
            // 
            // dgvSjedala
            // 
            this.dgvSjedala.AllowUserToAddRows = false;
            this.dgvSjedala.AllowUserToDeleteRows = false;
            this.dgvSjedala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSjedala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sjedaloID,
            this.oznaka,
            this.Status,
            this.Sektor,
            this.SektorID});
            this.dgvSjedala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSjedala.Location = new System.Drawing.Point(4, 19);
            this.dgvSjedala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSjedala.Name = "dgvSjedala";
            this.dgvSjedala.ReadOnly = true;
            this.dgvSjedala.RowHeadersWidth = 51;
            this.dgvSjedala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSjedala.Size = new System.Drawing.Size(1037, 430);
            this.dgvSjedala.TabIndex = 0;
            this.dgvSjedala.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvSjedala_MouseDoubleClick);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(16, 41);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(596, 22);
            this.txtPretraga.TabIndex = 1;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(923, 38);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(100, 28);
            this.txtPretrazi.TabIndex = 2;
            this.txtPretrazi.Text = "Pretraži";
            this.txtPretrazi.UseVisualStyleBackColor = true;
            this.txtPretrazi.Click += new System.EventHandler(this.TxtPretrazi_Click);
            // 
            // sjedaloID
            // 
            this.sjedaloID.DataPropertyName = "SjedaloID";
            this.sjedaloID.HeaderText = "SjedaloID";
            this.sjedaloID.MinimumWidth = 6;
            this.sjedaloID.Name = "sjedaloID";
            this.sjedaloID.ReadOnly = true;
            this.sjedaloID.Visible = false;
            this.sjedaloID.Width = 125;
            // 
            // oznaka
            // 
            this.oznaka.DataPropertyName = "Oznaka";
            this.oznaka.HeaderText = "Oznaka sjedala";
            this.oznaka.MinimumWidth = 6;
            this.oznaka.Name = "oznaka";
            this.oznaka.ReadOnly = true;
            this.oznaka.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Zauzeto";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Sektor
            // 
            this.Sektor.DataPropertyName = "Sektor";
            this.Sektor.HeaderText = "Naziv sektora";
            this.Sektor.MinimumWidth = 6;
            this.Sektor.Name = "Sektor";
            this.Sektor.ReadOnly = true;
            this.Sektor.Width = 125;
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
            // FrmSjedala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSjedala";
            this.Text = "frmSjedala";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSjedala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSjedala;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button txtPretrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjedaloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaka;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sektor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SektorID;
    }
}