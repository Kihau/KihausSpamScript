namespace Kihson_s_Spam_Script.AutoClicker
{
    partial class AutoClickerForm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.AutoClickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangPLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MBOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MBOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoClickerToolStripMenuItem,
            this.ThreadsToolStripMenuItem,
            this.OptionsToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(530, 24);
            this.menuStrip2.TabIndex = 19;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // AutoClickerToolStripMenuItem
            // 
            this.AutoClickerToolStripMenuItem.Name = "AutoClickerToolStripMenuItem";
            this.AutoClickerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.AutoClickerToolStripMenuItem.Text = "Spam Bot";
            this.AutoClickerToolStripMenuItem.Click += new System.EventHandler(this.AutoClickerToolStripMenuItem_Click);
            // 
            // ThreadsToolStripMenuItem
            // 
            this.ThreadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.wczytajToolStripMenuItem});
            this.ThreadsToolStripMenuItem.Name = "ThreadsToolStripMenuItem";
            this.ThreadsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ThreadsToolStripMenuItem.Text = "Wątki";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguagesToolStripMenuItem,
            this.MBoxesToolStripMenuItem});
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.OptionsToolStripMenuItem.Text = "Opcje";
            // 
            // LanguagesToolStripMenuItem
            // 
            this.LanguagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LangPLToolStripMenuItem,
            this.LangENToolStripMenuItem});
            this.LanguagesToolStripMenuItem.Name = "LanguagesToolStripMenuItem";
            this.LanguagesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.LanguagesToolStripMenuItem.Text = "Języki";
            // 
            // LangPLToolStripMenuItem
            // 
            this.LangPLToolStripMenuItem.Name = "LangPLToolStripMenuItem";
            this.LangPLToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.LangPLToolStripMenuItem.Text = "Polski";
            // 
            // LangENToolStripMenuItem
            // 
            this.LangENToolStripMenuItem.Name = "LangENToolStripMenuItem";
            this.LangENToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.LangENToolStripMenuItem.Text = "English";
            // 
            // MBoxesToolStripMenuItem
            // 
            this.MBoxesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MBOnToolStripMenuItem,
            this.MBOffToolStripMenuItem});
            this.MBoxesToolStripMenuItem.Name = "MBoxesToolStripMenuItem";
            this.MBoxesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.MBoxesToolStripMenuItem.Text = "MessageBoxy";
            // 
            // MBOnToolStripMenuItem
            // 
            this.MBOnToolStripMenuItem.Name = "MBOnToolStripMenuItem";
            this.MBOnToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.MBOnToolStripMenuItem.Text = "Włącz";
            // 
            // MBOffToolStripMenuItem
            // 
            this.MBOffToolStripMenuItem.Name = "MBOffToolStripMenuItem";
            this.MBOffToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.MBOffToolStripMenuItem.Text = "Wyłącz";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.HelpToolStripMenuItem.Text = "Pomoc";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.AboutToolStripMenuItem.Text = "O programie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 230);
            this.button1.TabIndex = 20;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 230);
            this.button2.TabIndex = 21;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AutoClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 272);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "AutoClickerForm";
            this.Text = "AutoClickerForm";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem AutoClickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LangPLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LangENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MBoxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MBOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MBOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}