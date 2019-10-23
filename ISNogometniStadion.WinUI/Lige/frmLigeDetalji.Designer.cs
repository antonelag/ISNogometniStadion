namespace ISNogometniStadion.WinUI.Lige
{
    partial class FrmLigeDetalji
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.Drzava = new System.Windows.Forms.Label();
            this.cbDrzave = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv lige";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(43, 73);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(329, 22);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNaziv_Validating);
            // 
            // Drzava
            // 
            this.Drzava.AutoSize = true;
            this.Drzava.Location = new System.Drawing.Point(39, 128);
            this.Drzava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Drzava.Name = "Drzava";
            this.Drzava.Size = new System.Drawing.Size(53, 17);
            this.Drzava.TabIndex = 2;
            this.Drzava.Text = "Drzava";
            // 
            // cbDrzave
            // 
            this.cbDrzave.FormattingEnabled = true;
            this.cbDrzave.Location = new System.Drawing.Point(43, 177);
            this.cbDrzave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDrzave.Name = "cbDrzave";
            this.cbDrzave.Size = new System.Drawing.Size(329, 24);
            this.cbDrzave.TabIndex = 3;
            this.cbDrzave.Validating += new System.ComponentModel.CancelEventHandler(this.CbDrzave_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(43, 236);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(329, 48);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLigeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 329);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbDrzave);
            this.Controls.Add(this.Drzava);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLigeDetalji";
            this.Text = "frmLigeDetalji";
            this.Load += new System.EventHandler(this.FrmLigeDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label Drzava;
        private System.Windows.Forms.ComboBox cbDrzave;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}