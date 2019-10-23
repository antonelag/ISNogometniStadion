namespace ISNogometniStadion.WinUI.Utakmice
{
    partial class FrmUtakmiceDetalji
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
            this.cbGosti = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStadion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbLiga = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domaći tim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gostujući tim";
            // 
            // cbDomaci
            // 
            this.cbDomaci.DisplayMember = "TimID";
            this.cbDomaci.FormattingEnabled = true;
            this.cbDomaci.Location = new System.Drawing.Point(51, 50);
            this.cbDomaci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDomaci.Name = "cbDomaci";
            this.cbDomaci.Size = new System.Drawing.Size(407, 24);
            this.cbDomaci.TabIndex = 2;
            this.cbDomaci.ValueMember = "TimID";
            this.cbDomaci.Validating += new System.ComponentModel.CancelEventHandler(this.CbDomaci_Validating);
            // 
            // cbGosti
            // 
            this.cbGosti.DisplayMember = "TimID";
            this.cbGosti.FormattingEnabled = true;
            this.cbGosti.Location = new System.Drawing.Point(51, 142);
            this.cbGosti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGosti.Name = "cbGosti";
            this.cbGosti.Size = new System.Drawing.Size(407, 24);
            this.cbGosti.TabIndex = 3;
            this.cbGosti.ValueMember = "TimID";
            this.cbGosti.Validating += new System.ComponentModel.CancelEventHandler(this.CbGosti_Validating);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(51, 220);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(407, 22);
            this.dtpDatum.TabIndex = 4;
            this.dtpDatum.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDatum_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum odigravanja";
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijeme.Location = new System.Drawing.Point(51, 295);
            this.dtpVrijeme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.ShowUpDown = true;
            this.dtpVrijeme.Size = new System.Drawing.Size(407, 22);
            this.dtpVrijeme.TabIndex = 6;
            this.dtpVrijeme.Validating += new System.ComponentModel.CancelEventHandler(this.DtpVrijeme_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vrijeme odigravanja";
            // 
            // cbStadion
            // 
            this.cbStadion.DisplayMember = "StadionID";
            this.cbStadion.FormattingEnabled = true;
            this.cbStadion.Location = new System.Drawing.Point(51, 370);
            this.cbStadion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStadion.Name = "cbStadion";
            this.cbStadion.Size = new System.Drawing.Size(407, 24);
            this.cbStadion.TabIndex = 8;
            this.cbStadion.ValueMember = "StadionID";
            this.cbStadion.Validating += new System.ComponentModel.CancelEventHandler(this.CbStadion_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stadion";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(54, 609);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(404, 38);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vrsta natjecanja";
            // 
            // cbLiga
            // 
            this.cbLiga.FormattingEnabled = true;
            this.cbLiga.Location = new System.Drawing.Point(51, 453);
            this.cbLiga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLiga.Name = "cbLiga";
            this.cbLiga.Size = new System.Drawing.Size(407, 24);
            this.cbLiga.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 503);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 72);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(340, 520);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(118, 45);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUtakmiceDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 687);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbLiga);
            this.Controls.Add(this.label6);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUtakmiceDetalji";
            this.Text = "frmUtakmiceDetalji";
            this.Load += new System.EventHandler(this.FrmUtakmiceDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDomaci;
        private System.Windows.Forms.ComboBox cbGosti;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStadion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbLiga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}