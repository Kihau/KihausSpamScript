using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Kihson_s_Spam_Script
{
    public partial class SpamScriptForm : Form
    {
        public SpamScriptForm()
        {
            InitializeComponent();
            lists = new ListManager(listBoxThreads);
            BotUpdater.Start();

            lang = new English();
            MBoxState = true;
            UpdateLanguage();
        }

        private LanguageManager lang;
        private ListManager lists;

        private static bool Paused { get; set; }
        private static bool Working { get; set; }
        private bool MBoxState { get; set; } 

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (lists.threadList.Count != 0 && !Working)
            {
                Working = true;
                GetReadyToSpam();
                for (int i = 0; i < lists.threadList.Count; i++)
                {
                    Thread.Sleep(lists.spamList[i].Delay);
                    lists.threadList[i].Start();
                }
            }
            // Gdy program działa nie ustawiać messageboxów (bot może przypadkowo je klikać przez metodę SendKey.SendWait("{Enter}"))
            else if (!Working) ShowMessageBox(lang[LanguageManager.Names.MBNoThreads]);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (Working)
            {

                foreach (Thread thread in lists.threadList)
                {
                    if (Paused) thread.Resume();
                    thread.Abort();
                }

                Working = Paused = false;
                lists.ClearAll();
                ClearMessageBoxes();
            }
            else ShowMessageBox(lang[LanguageManager.Names.MBNoThreads]);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxSpamMessage.Text != "" && !Working)
            {
                try
                {
                    lists.AddToAll(new SpamAction(textBoxSpamMessage.Text, textBoxSpamTime.Text, textBoxSpamNumber.Text, textBoxSpamDelay.Text));
                }
                catch
                {
                    ShowMessageBox(lang[LanguageManager.Names.MBArgError]);
                }
                ClearMessageBoxes();
            }
            // Gdy program działa nie ustawiać messageboxów (bot może przypadkowo je klikać przez metodę SendKey.SendWait("{Enter}"))
            else if (!Working) ShowMessageBox(lang[LanguageManager.Names.MBMissingData]);
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (Working)
            {
                if (!Paused)
                    PauseThreads();
                else
                {
                    GetReadyToSpam();
                    ResumeThreads();
                }
                Paused = !Paused;
            }
        }

        private void buttonListRemove_Click(object sender, EventArgs e)
        {
            if (listBoxThreads.SelectedIndex != -1 && (Paused || !Working))
                RemoveSelectedInListBox();
            else if (Working && !Paused)
                ShowMessageBox(lang[LanguageManager.Names.MBBotActiveError]);
            else ShowMessageBox(lang[LanguageManager.Names.MBListSelectError]);
        }

        private void buttonListEdit_Click(object sender, EventArgs e)
        {
            if (listBoxThreads.SelectedItems.Count == 1 && (Paused || !Working))
            {
                BotUpdater.Stop();
                ListBoxEditorForm editWindow = new ListBoxEditorForm(lists, Working, lang);
                editWindow.ShowDialog();
                BotUpdater.Start();
            }
            else if (listBoxThreads.SelectedItems.Count != 1)
                ShowMessageBox(lang[LanguageManager.Names.MBListSelectError]);
            else ShowMessageBox(lang[LanguageManager.Names.MBBotActiveError]);
        }

        private void BotUpdater_Tick(object sender, EventArgs e)
        {
            UpdateComponents();
            UpdateTitle();
        }

        // Add to some sort of a MenuBarManager
        private void MBOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MBoxState = true;
        }

        private void MBOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MBoxState = false;
        }

        private void LangENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang = new English();
            UpdateLanguage();
        }

        private void LangPLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang = new Polish();
            UpdateLanguage();
        }

        private void AutoClickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var clicker = new AutoClicker.AutoClickerForm();
            clicker.Closed += (s, args) => this.Close();
            clicker.Show();
        }
    }
}