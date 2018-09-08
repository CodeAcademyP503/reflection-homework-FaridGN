namespace Cardsystem
{
    partial class Mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSehifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haqqimizdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xidmetlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texnikiDestekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(28, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TekIstifade";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Qeydiyyat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(544, 290);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Daxil Ol";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Card Num";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSehifeToolStripMenuItem,
            this.haqqimizdaToolStripMenuItem,
            this.xidmetlerToolStripMenuItem,
            this.texnikiDestekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSehifeToolStripMenuItem
            // 
            this.anaSehifeToolStripMenuItem.Name = "anaSehifeToolStripMenuItem";
            this.anaSehifeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.anaSehifeToolStripMenuItem.Text = "Ana Sehife";
            // 
            // haqqimizdaToolStripMenuItem
            // 
            this.haqqimizdaToolStripMenuItem.Name = "haqqimizdaToolStripMenuItem";
            this.haqqimizdaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.haqqimizdaToolStripMenuItem.Text = "Haqqimizda";
            // 
            // xidmetlerToolStripMenuItem
            // 
            this.xidmetlerToolStripMenuItem.Name = "xidmetlerToolStripMenuItem";
            this.xidmetlerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.xidmetlerToolStripMenuItem.Text = "Xidmetler";
            // 
            // texnikiDestekToolStripMenuItem
            // 
            this.texnikiDestekToolStripMenuItem.Name = "texnikiDestekToolStripMenuItem";
            this.texnikiDestekToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.texnikiDestekToolStripMenuItem.Text = "Texniki destek";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSehifeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haqqimizdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xidmetlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem texnikiDestekToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

