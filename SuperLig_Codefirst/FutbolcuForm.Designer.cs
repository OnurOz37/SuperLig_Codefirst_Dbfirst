
namespace SuperLig_Codefirst
{
    partial class FutbolcuForm
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
            this.gbFutbolcu = new System.Windows.Forms.GroupBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.btnFutbolcuKaydet = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblFormaNum = new System.Windows.Forms.Label();
            this.lblOTakim = new System.Windows.Forms.Label();
            this.lblUlke = new System.Windows.Forms.Label();
            this.lblFutbolcuYas = new System.Windows.Forms.Label();
            this.lblFutbolcuAd = new System.Windows.Forms.Label();
            this.lblFutbolcu = new System.Windows.Forms.Label();
            this.dataGridViewFutbolcu = new System.Windows.Forms.DataGridView();
            this.gbFutbolcu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFutbolcu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFutbolcu
            // 
            this.gbFutbolcu.Controls.Add(this.buttonTemizle);
            this.gbFutbolcu.Controls.Add(this.btnFutbolcuKaydet);
            this.gbFutbolcu.Controls.Add(this.textBox8);
            this.gbFutbolcu.Controls.Add(this.textBox7);
            this.gbFutbolcu.Controls.Add(this.textBox6);
            this.gbFutbolcu.Controls.Add(this.textBox5);
            this.gbFutbolcu.Controls.Add(this.textBox4);
            this.gbFutbolcu.Controls.Add(this.lblFormaNum);
            this.gbFutbolcu.Controls.Add(this.lblOTakim);
            this.gbFutbolcu.Controls.Add(this.lblUlke);
            this.gbFutbolcu.Controls.Add(this.lblFutbolcuYas);
            this.gbFutbolcu.Controls.Add(this.lblFutbolcuAd);
            this.gbFutbolcu.Controls.Add(this.lblFutbolcu);
            this.gbFutbolcu.Location = new System.Drawing.Point(12, 26);
            this.gbFutbolcu.Name = "gbFutbolcu";
            this.gbFutbolcu.Size = new System.Drawing.Size(776, 255);
            this.gbFutbolcu.TabIndex = 3;
            this.gbFutbolcu.TabStop = false;
            this.gbFutbolcu.Text = "Futbolcu Giris";
            this.gbFutbolcu.Enter += new System.EventHandler(this.gbFutbolcu_Enter);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(548, 43);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(203, 173);
            this.buttonTemizle.TabIndex = 16;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // btnFutbolcuKaydet
            // 
            this.btnFutbolcuKaydet.Location = new System.Drawing.Point(385, 44);
            this.btnFutbolcuKaydet.Name = "btnFutbolcuKaydet";
            this.btnFutbolcuKaydet.Size = new System.Drawing.Size(113, 171);
            this.btnFutbolcuKaydet.TabIndex = 15;
            this.btnFutbolcuKaydet.Text = "Kaydet";
            this.btnFutbolcuKaydet.UseVisualStyleBackColor = true;
            this.btnFutbolcuKaydet.Click += new System.EventHandler(this.btnFutbolcuKaydet_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(245, 194);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(118, 22);
            this.textBox8.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(245, 155);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 22);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(244, 108);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(118, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(245, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(245, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 22);
            this.textBox4.TabIndex = 10;
            // 
            // lblFormaNum
            // 
            this.lblFormaNum.Location = new System.Drawing.Point(142, 186);
            this.lblFormaNum.Name = "lblFormaNum";
            this.lblFormaNum.Size = new System.Drawing.Size(93, 36);
            this.lblFormaNum.TabIndex = 9;
            this.lblFormaNum.Text = "Forma Numarasi";
            // 
            // lblOTakim
            // 
            this.lblOTakim.Location = new System.Drawing.Point(144, 137);
            this.lblOTakim.Name = "lblOTakim";
            this.lblOTakim.Size = new System.Drawing.Size(91, 40);
            this.lblOTakim.TabIndex = 8;
            this.lblOTakim.Text = "Oynadigi Takim";
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Location = new System.Drawing.Point(144, 108);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(36, 17);
            this.lblUlke.TabIndex = 7;
            this.lblUlke.Text = "Ülke";
            // 
            // lblFutbolcuYas
            // 
            this.lblFutbolcuYas.AutoSize = true;
            this.lblFutbolcuYas.Location = new System.Drawing.Point(144, 77);
            this.lblFutbolcuYas.Name = "lblFutbolcuYas";
            this.lblFutbolcuYas.Size = new System.Drawing.Size(32, 17);
            this.lblFutbolcuYas.TabIndex = 6;
            this.lblFutbolcuYas.Text = "Yas";
            // 
            // lblFutbolcuAd
            // 
            this.lblFutbolcuAd.AutoSize = true;
            this.lblFutbolcuAd.Location = new System.Drawing.Point(144, 47);
            this.lblFutbolcuAd.Name = "lblFutbolcuAd";
            this.lblFutbolcuAd.Size = new System.Drawing.Size(88, 17);
            this.lblFutbolcuAd.TabIndex = 5;
            this.lblFutbolcuAd.Text = "Ad ve Soyad";
            // 
            // lblFutbolcu
            // 
            this.lblFutbolcu.Location = new System.Drawing.Point(6, 33);
            this.lblFutbolcu.Name = "lblFutbolcu";
            this.lblFutbolcu.Size = new System.Drawing.Size(118, 43);
            this.lblFutbolcu.TabIndex = 1;
            this.lblFutbolcu.Text = "Lutfen Futbolcu bilgilerini giriniz : ";
            // 
            // dataGridViewFutbolcu
            // 
            this.dataGridViewFutbolcu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFutbolcu.Location = new System.Drawing.Point(12, 287);
            this.dataGridViewFutbolcu.Name = "dataGridViewFutbolcu";
            this.dataGridViewFutbolcu.RowHeadersWidth = 51;
            this.dataGridViewFutbolcu.RowTemplate.Height = 24;
            this.dataGridViewFutbolcu.Size = new System.Drawing.Size(776, 280);
            this.dataGridViewFutbolcu.TabIndex = 6;
            // 
            // FutbolcuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.dataGridViewFutbolcu);
            this.Controls.Add(this.gbFutbolcu);
            this.Name = "FutbolcuForm";
            this.Text = "FutbolcuForm";
            this.Load += new System.EventHandler(this.FutbolcuForm_Load);
            this.gbFutbolcu.ResumeLayout(false);
            this.gbFutbolcu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFutbolcu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFutbolcu;
        private System.Windows.Forms.Button btnFutbolcuKaydet;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblFormaNum;
        private System.Windows.Forms.Label lblOTakim;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.Label lblFutbolcuYas;
        private System.Windows.Forms.Label lblFutbolcuAd;
        private System.Windows.Forms.Label lblFutbolcu;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.DataGridView dataGridViewFutbolcu;
    }
}