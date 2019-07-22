namespace ISNogometniStadion.WinUI.Stadioni
{
    partial class frmStadionDetalji
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbStadioni = new System.Windows.Forms.ComboBox();
            this.gradoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradoviDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradoviDataSet = new ISNogometniStadion.WinUI.GradoviDataSet();
            this.gradoviTableAdapter = new ISNogometniStadion.WinUI.GradoviDataSetTableAdapters.GradoviTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gradoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoviDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoviDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(13, 76);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(175, 20);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNaziv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv stadiona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv grada";
            // 
            // cbStadioni
            // 
            this.cbStadioni.DataSource = this.gradoviBindingSource;
            this.cbStadioni.DisplayMember = "Naziv";
            this.cbStadioni.FormattingEnabled = true;
            this.cbStadioni.Location = new System.Drawing.Point(12, 168);
            this.cbStadioni.Name = "cbStadioni";
            this.cbStadioni.Size = new System.Drawing.Size(176, 21);
            this.cbStadioni.TabIndex = 3;
            this.cbStadioni.ValueMember = "GradID";
            this.cbStadioni.Validating += new System.ComponentModel.CancelEventHandler(this.CbStadioni_Validating);
            // 
            // gradoviBindingSource
            // 
            this.gradoviBindingSource.DataMember = "Gradovi";
            this.gradoviBindingSource.DataSource = this.gradoviDataSetBindingSource;
            // 
            // gradoviDataSetBindingSource
            // 
            this.gradoviDataSetBindingSource.DataSource = this.gradoviDataSet;
            this.gradoviDataSetBindingSource.Position = 0;
            // 
            // gradoviDataSet
            // 
            this.gradoviDataSet.DataSetName = "GradoviDataSet";
            this.gradoviDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradoviTableAdapter
            // 
            this.gradoviTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(113, 215);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // frmStadionDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 250);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbStadioni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmStadionDetalji";
            this.Text = "frmStadionDetalji";
            this.Load += new System.EventHandler(this.FrmStadionDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoviDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoviDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStadioni;
        private System.Windows.Forms.BindingSource gradoviDataSetBindingSource;
        private GradoviDataSet gradoviDataSet;
        private System.Windows.Forms.BindingSource gradoviBindingSource;
        private GradoviDataSetTableAdapters.GradoviTableAdapter gradoviTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}