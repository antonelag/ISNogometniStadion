namespace ISNogometniStadion.WinUI.Tribine
{
    partial class frmTribineDetalji
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
            this.components = new System.ComponentModel.Container();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTribine = new System.Windows.Forms.ComboBox();
            this.Stadion = new System.Windows.Forms.Label();
            this.stadioniDataSet = new ISNogometniStadion.WinUI.StadioniDataSet();
            this.stadioniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadioniTableAdapter = new ISNogometniStadion.WinUI.StadioniDataSetTableAdapters.StadioniTableAdapter();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stadioniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(29, 63);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(206, 20);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNaziv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv tribine";
            // 
            // cbTribine
            // 
            this.cbTribine.DataSource = this.stadioniBindingSource;
            this.cbTribine.DisplayMember = "Naziv";
            this.cbTribine.FormattingEnabled = true;
            this.cbTribine.Location = new System.Drawing.Point(29, 130);
            this.cbTribine.Name = "cbTribine";
            this.cbTribine.Size = new System.Drawing.Size(206, 21);
            this.cbTribine.TabIndex = 2;
            this.cbTribine.ValueMember = "StadionID";
            this.cbTribine.Validating += new System.ComponentModel.CancelEventHandler(this.CbTribine_Validating);
            // 
            // Stadion
            // 
            this.Stadion.AutoSize = true;
            this.Stadion.Location = new System.Drawing.Point(26, 105);
            this.Stadion.Name = "Stadion";
            this.Stadion.Size = new System.Drawing.Size(43, 13);
            this.Stadion.TabIndex = 3;
            this.Stadion.Text = "Stadion";
            // 
            // stadioniDataSet
            // 
            this.stadioniDataSet.DataSetName = "StadioniDataSet";
            this.stadioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stadioniDataSetBindingSource
            // 
            this.stadioniDataSetBindingSource.DataSource = this.stadioniDataSet;
            this.stadioniDataSetBindingSource.Position = 0;
            // 
            // stadioniBindingSource
            // 
            this.stadioniBindingSource.DataMember = "Stadioni";
            this.stadioniBindingSource.DataSource = this.stadioniDataSetBindingSource;
            // 
            // stadioniTableAdapter
            // 
            this.stadioniTableAdapter.ClearBeforeFill = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(160, 188);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 44);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTribineDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 277);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.Stadion);
            this.Controls.Add(this.cbTribine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmTribineDetalji";
            this.Text = "frmTribineDetalji";
            this.Load += new System.EventHandler(this.FrmTribineDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stadioniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTribine;
        private System.Windows.Forms.Label Stadion;
        private System.Windows.Forms.BindingSource stadioniDataSetBindingSource;
        private StadioniDataSet stadioniDataSet;
        private System.Windows.Forms.BindingSource stadioniBindingSource;
        private StadioniDataSetTableAdapters.StadioniTableAdapter stadioniTableAdapter;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}