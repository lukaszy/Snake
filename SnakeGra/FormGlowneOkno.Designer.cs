namespace SnakeGra
{
    partial class FormGlowneOkno
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
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbWizualizacja = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWizualizacja)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malaToolStripMenuItem,
            this.standardowaToolStripMenuItem,
            this.duzaToolStripMenuItem});
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nowaGraToolStripMenuItem.Text = "Nowa Gra";
            // 
            // malaToolStripMenuItem
            // 
            this.malaToolStripMenuItem.Name = "malaToolStripMenuItem";
            this.malaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.malaToolStripMenuItem.Text = "Mała";
            this.malaToolStripMenuItem.Click += new System.EventHandler(this.menu_Click);
            // 
            // standardowaToolStripMenuItem
            // 
            this.standardowaToolStripMenuItem.Name = "standardowaToolStripMenuItem";
            this.standardowaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.standardowaToolStripMenuItem.Text = "Standardowa";
            this.standardowaToolStripMenuItem.Click += new System.EventHandler(this.menu_Click);
            // 
            // duzaToolStripMenuItem
            // 
            this.duzaToolStripMenuItem.Name = "duzaToolStripMenuItem";
            this.duzaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.duzaToolStripMenuItem.Text = "Duża";
            this.duzaToolStripMenuItem.Click += new System.EventHandler(this.menu_Click);
            // 
            // pbWizualizacja
            // 
            this.pbWizualizacja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbWizualizacja.Location = new System.Drawing.Point(0, 24);
            this.pbWizualizacja.Name = "pbWizualizacja";
            this.pbWizualizacja.Size = new System.Drawing.Size(625, 386);
            this.pbWizualizacja.TabIndex = 2;
            this.pbWizualizacja.TabStop = false;
            this.pbWizualizacja.SizeChanged += new System.EventHandler(this.pbWizualizacja_SizeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 410);
            this.Controls.Add(this.pbWizualizacja);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWizualizacja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duzaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbWizualizacja;
    }
}

