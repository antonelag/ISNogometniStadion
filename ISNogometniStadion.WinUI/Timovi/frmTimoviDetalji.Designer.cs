namespace ISNogometniStadion.WinUI.Timovi
{
    partial class frmTimoviDetalji
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
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stadioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbTimovi = new System.Windows.Forms.ComboBox();
            this.stadioniDataSet = new ISNogometniStadion.WinUI.StadioniDataSet();
            this.stadioniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stadioniTableAdapter = new ISNogometniStadion.WinUI.StadioniDataSetTableAdapters.StadioniTableAdapter();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(13, 60);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 20);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNaziv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv tima";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(13, 115);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(250, 65);
            this.txtOpis.TabIndex = 2;
            this.txtOpis.Text = "";
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOpis_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis tima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stadion";
            // 
            // stadioniBindingSource
            // 
            this.stadioniBindingSource.DataMember = "Stadioni";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbTimovi
            // 
            this.cbTimovi.DataSource = this.stadioniBindingSource1;
            this.cbTimovi.DisplayMember = "Naziv";
            this.cbTimovi.FormattingEnabled = true;
            this.cbTimovi.Location = new System.Drawing.Point(13, 229);
            this.cbTimovi.Name = "cbTimovi";
            this.cbTimovi.Size = new System.Drawing.Size(250, 21);
            this.cbTimovi.TabIndex = 6;
            this.cbTimovi.ValueMember = "StadionID";
            // 
            // stadioniDataSet
            // 
            this.stadioniDataSet.DataSetName = "StadioniDataSet";
            this.stadioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stadioniBindingSource1
            // 
            this.stadioniBindingSource1.DataMember = "Stadioni";
            this.stadioniBindingSource1.DataSource = this.stadioniDataSet;
            // 
            // stadioniTableAdapter
            // 
            this.stadioniTableAdapter.ClearBeforeFill = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(188, 283);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 36);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // frmTimoviDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 343);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbTimovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmTimoviDetalji";
            this.Text = "frmTimoviDetalji";
            this.Load += new System.EventHandler(this.FrmTimoviDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stadioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource stadioniBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbTimovi;
        private StadioniDataSet stadioniDataSet;
        private System.Windows.Forms.BindingSource stadioniBindingSource1;
        private StadioniDataSetTableAdapters.StadioniTableAdapter stadioniTableAdapter;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}