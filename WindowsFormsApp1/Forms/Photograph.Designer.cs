﻿namespace WindowsFormsApp1.Forms
{
    partial class Photograph
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Photograph));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Del_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Edit_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Reload_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Search = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(44, 155);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(747, 317);
            this.dataGridView1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Location = new System.Drawing.Point(838, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(250, 317);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(26, 102);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 29);
            this.radioButton1.TabIndex = 86;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "по Фио";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb1.Location = new System.Drawing.Point(26, 60);
            this.rb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(205, 29);
            this.rb1.TabIndex = 85;
            this.rb1.TabStop = true;
            this.rb1.Text = "Коду Фотографа";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb2.Location = new System.Drawing.Point(26, 143);
            this.rb2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(144, 29);
            this.rb2.TabIndex = 84;
            this.rb2.TabStop = true;
            this.rb2.Text = "по Номеру";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Berlin Sans FB", 12.75F);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(26, 242);
            this.button4.Margin = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 51);
            this.button4.TabIndex = 83;
            this.button4.Text = "Сортировать ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Checked = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rb3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb3.Location = new System.Drawing.Point(26, 185);
            this.rb3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(127, 29);
            this.rb3.TabIndex = 81;
            this.rb3.TabStop = true;
            this.rb3.Text = "по Почте";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_toolStripButton,
            this.Del_toolStripButton,
            this.Edit_toolStripButton,
            this.toolStripButton1,
            this.Reload_toolStripButton,
            this.Search,
            this.toolStripButton2,
            this.ButtonSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1128, 38);
            this.toolStrip1.TabIndex = 74;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add_toolStripButton
            // 
            this.Add_toolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.Add_toolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_toolStripButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_добавить_правило_48;
            this.Add_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_toolStripButton.Name = "Add_toolStripButton";
            this.Add_toolStripButton.Size = new System.Drawing.Size(118, 33);
            this.Add_toolStripButton.Text = "Добавить";
            this.Add_toolStripButton.Click += new System.EventHandler(this.Add_toolStripButton_Click);
            // 
            // Del_toolStripButton
            // 
            this.Del_toolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Del_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Del_toolStripButton.Image")));
            this.Del_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Del_toolStripButton.Name = "Del_toolStripButton";
            this.Del_toolStripButton.Size = new System.Drawing.Size(104, 33);
            this.Del_toolStripButton.Text = "Удалить";
            this.Del_toolStripButton.Click += new System.EventHandler(this.Del_toolStripButton_Click);
            // 
            // Edit_toolStripButton
            // 
            this.Edit_toolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_toolStripButton.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_folder_4080912;
            this.Edit_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_toolStripButton.Name = "Edit_toolStripButton";
            this.Edit_toolStripButton.Size = new System.Drawing.Size(119, 33);
            this.Edit_toolStripButton.Text = "Изменить";
            this.Edit_toolStripButton.Click += new System.EventHandler(this.Edit_toolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(83, 33);
            this.toolStripButton1.Text = "Экспорт";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Reload_toolStripButton
            // 
            this.Reload_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Reload_toolStripButton.Image = global::WindowsFormsApp1.Properties.Resources.up;
            this.Reload_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reload_toolStripButton.Name = "Reload_toolStripButton";
            this.Reload_toolStripButton.Size = new System.Drawing.Size(34, 33);
            this.Reload_toolStripButton.Text = "toolStripButton2";
            this.Reload_toolStripButton.Click += new System.EventHandler(this.Reload_toolStripButton_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(148, 38);
            this.Search.Click += new System.EventHandler(this.Search_Click);
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(34, 33);
            this.ButtonSearch.Text = "Поиск";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 36);
            this.menuStrip1.TabIndex = 75;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(77, 30);
            this.файлToolStripMenuItem.Text = "Назад";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 30);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(80, 30);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Photograph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1587215785_61_p_foni_dlya_prilozhenii_1091;
            this.ClientSize = new System.Drawing.Size(1128, 522);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Photograph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фотографы";
            this.Load += new System.EventHandler(this.Photograph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_toolStripButton;
        private System.Windows.Forms.ToolStripButton Del_toolStripButton;
        private System.Windows.Forms.ToolStripButton Edit_toolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton Reload_toolStripButton;
        private System.Windows.Forms.ToolStripTextBox Search;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.ToolStripButton ButtonSearch;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}