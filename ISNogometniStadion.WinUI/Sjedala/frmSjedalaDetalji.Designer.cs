﻿namespace ISNogometniStadion.WinUI.Sjedala
{
    partial class frmSjedalaDetalji
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
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tribineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadioniTribineDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSektori = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tribineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniTribineDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOznaka
            // 
            this.txtOznaka.Location = new System.Drawing.Point(47, 83);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(100, 20);
            this.txtOznaka.TabIndex = 0;
            this.txtOznaka.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOznaka_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oznaka sjedala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sektor";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(48, 223);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 4;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.BtnSnimi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbSektori
            // 
            this.cbSektori.FormattingEnabled = true;
            this.cbSektori.Location = new System.Drawing.Point(47, 172);
            this.cbSektori.Name = "cbSektori";
            this.cbSektori.Size = new System.Drawing.Size(177, 21);
            this.cbSektori.TabIndex = 5;
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoSize = true;
            this.cbxStatus.Location = new System.Drawing.Point(153, 86);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(71, 17);
            this.cbxStatus.TabIndex = 7;
            this.cbxStatus.Text = "Zauzeto?";
            this.cbxStatus.UseVisualStyleBackColor = true;
            // 
            // frmSjedalaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbSektori);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOznaka);
            this.Name = "frmSjedalaDetalji";
            this.Text = "frmSjedalaDetalji";
            this.Load += new System.EventHandler(this.FrmSjedalaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tribineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadioniTribineDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource stadioniTribineDataSetBindingSource;
        private System.Windows.Forms.BindingSource tribineBindingSource;
        private System.Windows.Forms.ComboBox cbSektori;
        private System.Windows.Forms.CheckBox cbxStatus;
    }
}