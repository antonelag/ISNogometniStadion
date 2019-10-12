namespace ISNogometniStadion.WinUI.Ulaznice
{
    partial class frmUlazniceDetalji
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSektor = new System.Windows.Forms.ComboBox();
            this.cbSjedala = new System.Windows.Forms.ComboBox();
            this.cbKorisnik = new System.Windows.Forms.ComboBox();
            this.cbUtakmica = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utakmica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oznaka sjedala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Korisnik";
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.CustomFormat = "";
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijeme.Location = new System.Drawing.Point(33, 457);
            this.dtpVrijeme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.ShowUpDown = true;
            this.dtpVrijeme.Size = new System.Drawing.Size(420, 22);
            this.dtpVrijeme.TabIndex = 6;
            this.dtpVrijeme.Value = new System.DateTime(2019, 7, 23, 16, 24, 0, 0);
            this.dtpVrijeme.Validating += new System.ComponentModel.CancelEventHandler(this.DtpVrijeme_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vrijeme kupnje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum kupnje";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "ddd dd MMM yyyy";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(33, 388);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(420, 22);
            this.dtpDatum.TabIndex = 8;
            this.dtpDatum.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDatum_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(33, 526);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(420, 48);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sektor";
            // 
            // cbSektor
            // 
            this.cbSektor.FormattingEnabled = true;
            this.cbSektor.Location = new System.Drawing.Point(33, 161);
            this.cbSektor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSektor.Name = "cbSektor";
            this.cbSektor.Size = new System.Drawing.Size(420, 24);
            this.cbSektor.TabIndex = 2;
            this.cbSektor.SelectionChangeCommitted += new System.EventHandler(this.CbSektor_SelectionChangeCommitted);
            // 
            // cbSjedala
            // 
            this.cbSjedala.FormattingEnabled = true;
            this.cbSjedala.Location = new System.Drawing.Point(33, 235);
            this.cbSjedala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSjedala.Name = "cbSjedala";
            this.cbSjedala.Size = new System.Drawing.Size(420, 24);
            this.cbSjedala.TabIndex = 3;
            // 
            // cbKorisnik
            // 
            this.cbKorisnik.FormattingEnabled = true;
            this.cbKorisnik.Location = new System.Drawing.Point(33, 311);
            this.cbKorisnik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKorisnik.Name = "cbKorisnik";
            this.cbKorisnik.Size = new System.Drawing.Size(420, 24);
            this.cbKorisnik.TabIndex = 14;
            // 
            // cbUtakmica
            // 
            this.cbUtakmica.FormattingEnabled = true;
            this.cbUtakmica.Location = new System.Drawing.Point(33, 86);
            this.cbUtakmica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUtakmica.Name = "cbUtakmica";
            this.cbUtakmica.Size = new System.Drawing.Size(420, 24);
            this.cbUtakmica.TabIndex = 1;
            this.cbUtakmica.SelectionChangeCommitted += new System.EventHandler(this.CbUtakmica_SelectionChangeCommitted);
            // 
            // frmUlazniceDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 608);
            this.Controls.Add(this.cbUtakmica);
            this.Controls.Add(this.cbKorisnik);
            this.Controls.Add(this.cbSjedala);
            this.Controls.Add(this.cbSektor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUlazniceDetalji";
            this.Text = "frmUlazniceDetalji";
            this.Load += new System.EventHandler(this.FrmUlazniceDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUtakmica;
        private System.Windows.Forms.ComboBox cbKorisnik;
        private System.Windows.Forms.ComboBox cbSjedala;
        private System.Windows.Forms.ComboBox cbSektor;
    }
}