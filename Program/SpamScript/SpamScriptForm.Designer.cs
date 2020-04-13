namespace KihsonsBot.SpamScript
{
    partial class SpamScriptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpamScriptForm));
            this.text_label = new System.Windows.Forms.Label();
            this.textBoxSpamMessage = new System.Windows.Forms.TextBox();
            this.time_label = new System.Windows.Forms.Label();
            this.textBoxSpamTime = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.messnumb_label = new System.Windows.Forms.Label();
            this.textBoxSpamNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.delay_label = new System.Windows.Forms.Label();
            this.textBoxSpamDelay = new System.Windows.Forms.TextBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.BotUpdater = new System.Windows.Forms.Timer(this.components);
            this.thread_label = new System.Windows.Forms.Label();
            this.textBoxThreads = new System.Windows.Forms.TextBox();
            this.buttonListRemove = new System.Windows.Forms.Button();
            this.listBoxThreads = new System.Windows.Forms.ListBox();
            this.buttonListEdit = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.AutoClickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangPLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MBOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MBOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxDeleteFinalised = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_label.Location = new System.Drawing.Point(12, 35);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(372, 25);
            this.text_label.TabIndex = 0;
            this.text_label.Text = "Wiadomość, którą chcesz spamować:";
            // 
            // textBoxSpamMessage
            // 
            this.textBoxSpamMessage.Location = new System.Drawing.Point(17, 63);
            this.textBoxSpamMessage.Name = "textBoxSpamMessage";
            this.textBoxSpamMessage.Size = new System.Drawing.Size(367, 20);
            this.textBoxSpamMessage.TabIndex = 1;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.SystemColors.Control;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time_label.Location = new System.Drawing.Point(12, 99);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(319, 25);
            this.time_label.TabIndex = 2;
            this.time_label.Text = "Częstotliwość wysyłania (w ms):\r\n";
            // 
            // textBoxSpamTime
            // 
            this.textBoxSpamTime.Location = new System.Drawing.Point(17, 127);
            this.textBoxSpamTime.Name = "textBoxSpamTime";
            this.textBoxSpamTime.Size = new System.Drawing.Size(367, 20);
            this.textBoxSpamTime.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(17, 289);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(70, 65);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(93, 289);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(69, 65);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // messnumb_label
            // 
            this.messnumb_label.AutoSize = true;
            this.messnumb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messnumb_label.Location = new System.Drawing.Point(12, 161);
            this.messnumb_label.Name = "messnumb_label";
            this.messnumb_label.Size = new System.Drawing.Size(299, 25);
            this.messnumb_label.TabIndex = 6;
            this.messnumb_label.Text = "Ilość wiadomości do wysłania:";
            // 
            // textBoxSpamNumber
            // 
            this.textBoxSpamNumber.Location = new System.Drawing.Point(17, 189);
            this.textBoxSpamNumber.Name = "textBoxSpamNumber";
            this.textBoxSpamNumber.Size = new System.Drawing.Size(367, 20);
            this.textBoxSpamNumber.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(166, 289);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(69, 65);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "DODAJ\r\n";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // delay_label
            // 
            this.delay_label.AutoSize = true;
            this.delay_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delay_label.Location = new System.Drawing.Point(12, 225);
            this.delay_label.Name = "delay_label";
            this.delay_label.Size = new System.Drawing.Size(127, 25);
            this.delay_label.TabIndex = 9;
            this.delay_label.Text = "Opóżnienie:";
            // 
            // textBoxSpamDelay
            // 
            this.textBoxSpamDelay.Location = new System.Drawing.Point(17, 253);
            this.textBoxSpamDelay.Name = "textBoxSpamDelay";
            this.textBoxSpamDelay.Size = new System.Drawing.Size(367, 20);
            this.textBoxSpamDelay.TabIndex = 10;
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Location = new System.Drawing.Point(241, 289);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(69, 65);
            this.buttonPause.TabIndex = 11;
            this.buttonPause.Text = "PAUZA";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // BotUpdater
            // 
            this.BotUpdater.Tick += new System.EventHandler(this.BotUpdater_Tick);
            // 
            // thread_label
            // 
            this.thread_label.AutoSize = true;
            this.thread_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thread_label.Location = new System.Drawing.Point(316, 325);
            this.thread_label.Name = "thread_label";
            this.thread_label.Size = new System.Drawing.Size(106, 16);
            this.thread_label.TabIndex = 12;
            this.thread_label.Text = "Dodane wątki:";
            // 
            // textBoxThreads
            // 
            this.textBoxThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxThreads.Location = new System.Drawing.Point(348, 344);
            this.textBoxThreads.Multiline = true;
            this.textBoxThreads.Name = "textBoxThreads";
            this.textBoxThreads.ReadOnly = true;
            this.textBoxThreads.Size = new System.Drawing.Size(36, 17);
            this.textBoxThreads.TabIndex = 13;
            this.textBoxThreads.Text = "0";
            this.textBoxThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonListRemove
            // 
            this.buttonListRemove.Location = new System.Drawing.Point(509, 289);
            this.buttonListRemove.Name = "buttonListRemove";
            this.buttonListRemove.Size = new System.Drawing.Size(75, 65);
            this.buttonListRemove.TabIndex = 15;
            this.buttonListRemove.Text = "USUŃ";
            this.buttonListRemove.UseVisualStyleBackColor = true;
            this.buttonListRemove.Click += new System.EventHandler(this.buttonListRemove_Click);
            // 
            // listBoxThreads
            // 
            this.listBoxThreads.FormattingEnabled = true;
            this.listBoxThreads.HorizontalScrollbar = true;
            this.listBoxThreads.Location = new System.Drawing.Point(400, 35);
            this.listBoxThreads.Name = "listBoxThreads";
            this.listBoxThreads.ScrollAlwaysVisible = true;
            this.listBoxThreads.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxThreads.Size = new System.Drawing.Size(184, 238);
            this.listBoxThreads.TabIndex = 16;
            // 
            // buttonListEdit
            // 
            this.buttonListEdit.Location = new System.Drawing.Point(428, 289);
            this.buttonListEdit.Name = "buttonListEdit";
            this.buttonListEdit.Size = new System.Drawing.Size(75, 65);
            this.buttonListEdit.TabIndex = 17;
            this.buttonListEdit.Text = "EDYTUJ";
            this.buttonListEdit.UseVisualStyleBackColor = true;
            this.buttonListEdit.Click += new System.EventHandler(this.buttonListEdit_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoClickerToolStripMenuItem,
            this.ThreadsToolStripMenuItem,
            this.OptionsToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(603, 24);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip1";
            // 
            // AutoClickerToolStripMenuItem
            // 
            this.AutoClickerToolStripMenuItem.Name = "AutoClickerToolStripMenuItem";
            this.AutoClickerToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.AutoClickerToolStripMenuItem.Text = "Auto Clicker";
            this.AutoClickerToolStripMenuItem.Click += new System.EventHandler(this.AutoClickerToolStripMenuItem_Click);
            // 
            // ThreadsToolStripMenuItem
            // 
            this.ThreadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.ThreadsToolStripMenuItem.Name = "ThreadsToolStripMenuItem";
            this.ThreadsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ThreadsToolStripMenuItem.Text = "Wątki";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.SaveToolStripMenuItem.Text = "Zapisz";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.LoadToolStripMenuItem.Text = "Wczytaj";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
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
            this.LangPLToolStripMenuItem.Click += new System.EventHandler(this.LangPLToolStripMenuItem_Click);
            // 
            // LangENToolStripMenuItem
            // 
            this.LangENToolStripMenuItem.Name = "LangENToolStripMenuItem";
            this.LangENToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.LangENToolStripMenuItem.Text = "English";
            this.LangENToolStripMenuItem.Click += new System.EventHandler(this.LangENToolStripMenuItem_Click);
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
            this.MBOnToolStripMenuItem.Click += new System.EventHandler(this.MBOnToolStripMenuItem_Click);
            // 
            // MBOffToolStripMenuItem
            // 
            this.MBOffToolStripMenuItem.Name = "MBOffToolStripMenuItem";
            this.MBOffToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.MBOffToolStripMenuItem.Text = "Wyłącz";
            this.MBOffToolStripMenuItem.Click += new System.EventHandler(this.MBOffToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.HelpToolStripMenuItem.Text = "Pomoc";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.AboutToolStripMenuItem.Text = "O programie";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "XML files (*.xml)|*.xml";
            this.openFileDialog.FilterIndex = 2;
            this.openFileDialog.Title = "Load";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            this.saveFileDialog.FilterIndex = 2;
            this.saveFileDialog.Title = "Save";
            // 
            // checkBoxDeleteFinalised
            // 
            this.checkBoxDeleteFinalised.AutoSize = true;
            this.checkBoxDeleteFinalised.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBoxDeleteFinalised.Location = new System.Drawing.Point(316, 286);
            this.checkBoxDeleteFinalised.Name = "checkBoxDeleteFinalised";
            this.checkBoxDeleteFinalised.Size = new System.Drawing.Size(112, 36);
            this.checkBoxDeleteFinalised.TabIndex = 19;
            this.checkBoxDeleteFinalised.Text = "Czyść po\r\nzakończeniu";
            this.checkBoxDeleteFinalised.UseVisualStyleBackColor = true;
            this.checkBoxDeleteFinalised.CheckedChanged += new System.EventHandler(this.checkBoxDeleteFinalised_CheckedChanged);
            // 
            // SpamScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 375);
            this.Controls.Add(this.checkBoxDeleteFinalised);
            this.Controls.Add(this.buttonListEdit);
            this.Controls.Add(this.listBoxThreads);
            this.Controls.Add(this.buttonListRemove);
            this.Controls.Add(this.textBoxThreads);
            this.Controls.Add(this.thread_label);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.textBoxSpamDelay);
            this.Controls.Add(this.delay_label);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSpamNumber);
            this.Controls.Add(this.messnumb_label);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxSpamTime);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.textBoxSpamMessage);
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "SpamScriptForm";
            this.Text = "Kihau\'s Spam Script - BOT NIEAKTYWNY";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.TextBox textBoxSpamMessage;
        private System.Windows.Forms.TextBox textBoxSpamTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label messnumb_label;
        private System.Windows.Forms.TextBox textBoxSpamNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label delay_label;
        private System.Windows.Forms.TextBox textBoxSpamDelay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Timer BotUpdater;
        private System.Windows.Forms.Label thread_label;
        private System.Windows.Forms.TextBox textBoxThreads;
        private System.Windows.Forms.Button buttonListRemove;
        private System.Windows.Forms.ListBox listBoxThreads;
        private System.Windows.Forms.Button buttonListEdit;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem AutoClickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LangPLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LangENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MBoxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MBOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MBOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox checkBoxDeleteFinalised;
        private System.Windows.Forms.Label time_label;
    }
}

