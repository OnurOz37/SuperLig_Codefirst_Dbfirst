
namespace SuperLig_Codefirst
{
    partial class TakimForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbTakim = new System.Windows.Forms.GroupBox();
            this.btnTakimKaydet = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAntrenorAdi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lbltakimAd = new System.Windows.Forms.Label();
            this.lblTakim = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.dataGridViewTakim = new System.Windows.Forms.DataGridView();
            this.gbTakim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakim)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTakim
            // 
            this.gbTakim.Controls.Add(this.btnTakimKaydet);
            this.gbTakim.Controls.Add(this.textBox3);
            this.gbTakim.Controls.Add(this.textBox2);
            this.gbTakim.Controls.Add(this.textBox1);
            this.gbTakim.Controls.Add(this.lblAntrenorAdi);
            this.gbTakim.Controls.Add(this.lblTarih);
            this.gbTakim.Controls.Add(this.lbltakimAd);
            this.gbTakim.Controls.Add(this.lblTakim);
            this.gbTakim.Location = new System.Drawing.Point(17, 34);
            this.gbTakim.Name = "gbTakim";
            this.gbTakim.Size = new System.Drawing.Size(500, 173);
            this.gbTakim.TabIndex = 1;
            this.gbTakim.TabStop = false;
            this.gbTakim.Text = "Takim Giris";
            // 
            // btnTakimKaydet
            // 
            this.btnTakimKaydet.Location = new System.Drawing.Point(385, 50);
            this.btnTakimKaydet.Name = "btnTakimKaydet";
            this.btnTakimKaydet.Size = new System.Drawing.Size(113, 85);
            this.btnTakimKaydet.TabIndex = 9;
            this.btnTakimKaydet.Text = "Kaydet";
            this.btnTakimKaydet.UseVisualStyleBackColor = true;
            this.btnTakimKaydet.Click += new System.EventHandler(this.btnTakimKaydet_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 5;
            // 
            // lblAntrenorAdi
            // 
            this.lblAntrenorAdi.AutoSize = true;
            this.lblAntrenorAdi.Location = new System.Drawing.Point(143, 118);
            this.lblAntrenorAdi.Name = "lblAntrenorAdi";
            this.lblAntrenorAdi.Size = new System.Drawing.Size(63, 17);
            this.lblAntrenorAdi.TabIndex = 3;
            this.lblAntrenorAdi.Text = "Antrenor";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(143, 83);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(91, 17);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Kurulus tarihi";
            // 
            // lbltakimAd
            // 
            this.lbltakimAd.AutoSize = true;
            this.lbltakimAd.Location = new System.Drawing.Point(143, 53);
            this.lbltakimAd.Name = "lbltakimAd";
            this.lbltakimAd.Size = new System.Drawing.Size(46, 17);
            this.lbltakimAd.TabIndex = 1;
            this.lbltakimAd.Text = "Takim";
            // 
            // lblTakim
            // 
            this.lblTakim.Location = new System.Drawing.Point(6, 37);
            this.lblTakim.Name = "lblTakim";
            this.lblTakim.Size = new System.Drawing.Size(131, 50);
            this.lblTakim.TabIndex = 0;
            this.lblTakim.Text = "Lutfen Takim bilgilerini giriniz : ";
            this.toolTip1.SetToolTip(this.lblTakim, "Butun sutunlari doldurmayi unutmayiniz ! ");
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(542, 34);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(203, 173);
            this.buttonTemizle.TabIndex = 4;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // dataGridViewTakim
            // 
            this.dataGridViewTakim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTakim.Location = new System.Drawing.Point(17, 213);
            this.dataGridViewTakim.Name = "dataGridViewTakim";
            this.dataGridViewTakim.RowHeadersWidth = 51;
            this.dataGridViewTakim.RowTemplate.Height = 24;
            this.dataGridViewTakim.Size = new System.Drawing.Size(728, 280);
            this.dataGridViewTakim.TabIndex = 5;
            // 
            // TakimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 505);
            this.Controls.Add(this.dataGridViewTakim);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.gbTakim);
            this.Name = "TakimForm";
            this.Text = "Bilgi Girisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTakim.ResumeLayout(false);
            this.gbTakim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTakim;
        private System.Windows.Forms.Label lblTakim;
        private System.Windows.Forms.Label lblAntrenorAdi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lbltakimAd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button btnTakimKaydet;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.DataGridView dataGridViewTakim;
    }
}

