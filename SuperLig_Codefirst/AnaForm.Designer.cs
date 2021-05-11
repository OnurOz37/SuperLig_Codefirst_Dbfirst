
namespace SuperLig_Codefirst
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.futbolcuTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takimKaydiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futbolcuKaydiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antrenorKaydiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.futbolcuTablosuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // futbolcuTablosuToolStripMenuItem
            // 
            this.futbolcuTablosuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takimKaydiToolStripMenuItem,
            this.futbolcuKaydiToolStripMenuItem,
            this.antrenorKaydiToolStripMenuItem});
            this.futbolcuTablosuToolStripMenuItem.Name = "futbolcuTablosuToolStripMenuItem";
            this.futbolcuTablosuToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.futbolcuTablosuToolStripMenuItem.Text = "Bilgi Kayit Islemi";
            // 
            // takimKaydiToolStripMenuItem
            // 
            this.takimKaydiToolStripMenuItem.Name = "takimKaydiToolStripMenuItem";
            this.takimKaydiToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.takimKaydiToolStripMenuItem.Text = "Takim Kaydi";
            this.takimKaydiToolStripMenuItem.Click += new System.EventHandler(this.takimKaydiToolStripMenuItem_Click);
            // 
            // futbolcuKaydiToolStripMenuItem
            // 
            this.futbolcuKaydiToolStripMenuItem.Name = "futbolcuKaydiToolStripMenuItem";
            this.futbolcuKaydiToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.futbolcuKaydiToolStripMenuItem.Text = "Futbolcu Kaydi";
            this.futbolcuKaydiToolStripMenuItem.Click += new System.EventHandler(this.futbolcuKaydiToolStripMenuItem_Click);
            // 
            // antrenorKaydiToolStripMenuItem
            // 
            this.antrenorKaydiToolStripMenuItem.Name = "antrenorKaydiToolStripMenuItem";
            this.antrenorKaydiToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.antrenorKaydiToolStripMenuItem.Text = "Antrenor Kaydi";
            this.antrenorKaydiToolStripMenuItem.Click += new System.EventHandler(this.antrenorKaydiToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 680);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem futbolcuTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takimKaydiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futbolcuKaydiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antrenorKaydiToolStripMenuItem;
    }
}