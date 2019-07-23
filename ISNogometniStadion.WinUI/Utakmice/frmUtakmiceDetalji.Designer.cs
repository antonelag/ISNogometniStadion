namespace ISNogometniStadion.WinUI.Utakmice
{
    partial class frmUtakmiceDetalji
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDomaci = new System.Windows.Forms.ComboBox();
            this.timoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timoviDBDataSet = new ISNogometniStadion.WinUI.TimoviDBDataSet();
            this.timoviTableAdapter = new ISNogometniStadion.WinUI.TimoviDBDataSetTableAdapters.TimoviTableAdapter();
            this.cbGosti = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStadion = new System.Windows.Forms.ComboBox();
            this.stadioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadioniDataSet = new ISNogometniStadion.WinUI.StadioniDataSet();
            this.stadioniTableAdapter = new ISNogometniStadion.WinUI.StadioniDataSetTableAdapters.StadioniTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timovi2DBDataSet = new ISNogometniStadion.WinUI.timovi2DBDataSet();
            this.timoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timoviTableAdapter1 = new ISNogometniStadion.WinUI.timovi2DBDataSetTableAdapters.TimoviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.timoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timoviDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timovi2DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timoviBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domaći tim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gostujući tim";
            // 
            // cbDomaci
            // 
            this.cbDomaci.DataSource = this.timoviBindingSource;
            this.cbDomaci.DisplayMember = "Naziv";
            this.cbDomaci.FormattingEnabled = true;
            this.cbDomaci.Location = new System.Drawing.Point(12, 41);
            this.cbDomaci.Name = "cbDomaci";
            this.cbDomaci.Size = new System.Drawing.Size(200, 21);
            this.cbDomaci.TabIndex = 2;
            this.cbDomaci.ValueMember = "TimID";
            this.cbDomaci.Validating += new System.ComponentModel.CancelEventHandler(this.CbDomaci_Validating);
            // 
            // timoviBindingSource
            // 
            this.timoviBindingSource.DataMember = "Timovi";
            this.timoviBindingSource.DataSource = this.timoviDBDataSet;
            // 
            // timoviDBDataSet
            // 
            this.timoviDBDataSet.DataSetName = "TimoviDBDataSet";
            this.timoviDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timoviTableAdapter
            // 
            this.timoviTableAdapter.ClearBeforeFill = true;
            // 
            // cbGosti
            // 
            this.cbGosti.DataSource = this.timoviBindingSource1;
            this.cbGosti.DisplayMember = "Naziv";
            this.cbGosti.FormattingEnabled = true;
            this.cbGosti.Location = new System.Drawing.Point(12, 115);
            this.cbGosti.Name = "cbGosti";
            this.cbGosti.Size = new System.Drawing.Size(200, 21);
            this.cbGosti.TabIndex = 3;
            this.cbGosti.ValueMember = "TimID";
            this.cbGosti.Validating += new System.ComponentModel.CancelEventHandler(this.CbGosti_Validating);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(12, 179);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 4;
            this.dtpDatum.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDatum_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum odigravanja";
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijeme.Location = new System.Drawing.Point(12, 240);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.ShowUpDown = true;
            this.dtpVrijeme.Size = new System.Drawing.Size(200, 20);
            this.dtpVrijeme.TabIndex = 6;
            this.dtpVrijeme.Validating += new System.ComponentModel.CancelEventHandler(this.DtpVrijeme_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vrijeme odigravanja";
            // 
            // cbStadion
            // 
            this.cbStadion.DataSource = this.stadioniBindingSource;
            this.cbStadion.DisplayMember = "Naziv";
            this.cbStadion.FormattingEnabled = true;
            this.cbStadion.Location = new System.Drawing.Point(12, 301);
            this.cbStadion.Name = "cbStadion";
            this.cbStadion.Size = new System.Drawing.Size(200, 21);
            this.cbStadion.TabIndex = 8;
            this.cbStadion.ValueMember = "StadionID";
            this.cbStadion.Validating += new System.ComponentModel.CancelEventHandler(this.CbStadion_Validating);
            // 
            // stadioniBindingSource
            // 
            this.stadioniBindingSource.DataMember = "Stadioni";
            this.stadioniBindingSource.DataSource = this.stadioniDataSet;
            // 
            // stadioniDataSet
            // 
            this.stadioniDataSet.DataSetName = "StadioniDataSet";
            this.stadioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stadioniTableAdapter
            // 
            this.stadioniTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stadion";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(137, 343);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 31);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timovi2DBDataSet
            // 
            this.timovi2DBDataSet.DataSetName = "timovi2DBDataSet";
            this.timovi2DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timoviBindingSource1
            // 
            this.timoviBindingSource1.DataMember = "Timovi";
            this.timoviBindingSource1.DataSource = this.timovi2DBDataSet;
            // 
            // timoviTableAdapter1
            // 
            this.timoviTableAdapter1.ClearBeforeFill = true;
            // 
            // frmUtakmiceDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 386);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStadion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbGosti);
            this.Controls.Add(this.cbDomaci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUtakmiceDetalji";
            this.Text = "frmUtakmiceDetalji";
            this.Load += new System.EventHandler(this.FrmUtakmiceDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timoviDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timovi2DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timoviBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDomaci;
        private TimoviDBDataSet timoviDBDataSet;
        private System.Windows.Forms.BindingSource timoviBindingSource;
        private TimoviDBDataSetTableAdapters.TimoviTableAdapter timoviTableAdapter;
        private System.Windows.Forms.ComboBox cbGosti;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStadion;
        private StadioniDataSet stadioniDataSet;
        private System.Windows.Forms.BindingSource stadioniBindingSource;
        private StadioniDataSetTableAdapters.StadioniTableAdapter stadioniTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private timovi2DBDataSet timovi2DBDataSet;
        private System.Windows.Forms.BindingSource timoviBindingSource1;
        private timovi2DBDataSetTableAdapters.TimoviTableAdapter timoviTableAdapter1;
    }
}