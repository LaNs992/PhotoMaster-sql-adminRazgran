namespace WindowsFormsApp1.Forms
{
    partial class MainForm
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
            this.Uchet = new System.Windows.Forms.Button();
            this.Oil = new System.Windows.Forms.Button();
            this.Spr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Uchet
            // 
            this.Uchet.Location = new System.Drawing.Point(58, 465);
            this.Uchet.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Uchet.Name = "Uchet";
            this.Uchet.Size = new System.Drawing.Size(384, 94);
            this.Uchet.TabIndex = 7;
            this.Uchet.Text = "Учёт";
            this.Uchet.UseVisualStyleBackColor = true;
            this.Uchet.Click += new System.EventHandler(this.Uchet_Click);
            // 
            // Oil
            // 
            this.Oil.Location = new System.Drawing.Point(58, 211);
            this.Oil.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Oil.Name = "Oil";
            this.Oil.Size = new System.Drawing.Size(384, 94);
            this.Oil.TabIndex = 6;
            this.Oil.Text = "Фотограф";
            this.Oil.UseVisualStyleBackColor = true;
            this.Oil.Click += new System.EventHandler(this.Oil_Click);
            // 
            // Spr
            // 
            this.Spr.Location = new System.Drawing.Point(58, 85);
            this.Spr.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Spr.Name = "Spr";
            this.Spr.Size = new System.Drawing.Size(384, 94);
            this.Spr.TabIndex = 5;
            this.Spr.Text = "Клиент";
            this.Spr.UseVisualStyleBackColor = true;
            this.Spr.Click += new System.EventHandler(this.Spr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 94);
            this.button1.TabIndex = 10;
            this.button1.Text = "Услуги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 35);
            this.menuStrip1.TabIndex = 84;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.файлToolStripMenuItem.Text = "Назад";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1587215785_61_p_foni_dlya_prilozhenii_1091;
            this.ClientSize = new System.Drawing.Size(520, 651);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Uchet);
            this.Controls.Add(this.Oil);
            this.Controls.Add(this.Spr);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Uchet;
        private System.Windows.Forms.Button Oil;
        private System.Windows.Forms.Button Spr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
    }
}