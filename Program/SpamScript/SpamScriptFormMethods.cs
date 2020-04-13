using System.Windows.Forms;
using System.Threading;

namespace KihsonsBot.SpamScript
{
    public partial class SpamScriptForm
    {
        private void ClearMessageBoxes()
        {
            textBoxSpamMessage.Clear();
            textBoxSpamNumber.Clear();
            textBoxSpamTime.Clear();
            textBoxSpamDelay.Clear();
        }

        private void UpdateLanguage()
        {
            this.buttonAdd.Text = lang[LanguageManager.Names.ButtonAdd];
            this.buttonPause.Text = lang[LanguageManager.Names.ButtonPause];
            this.buttonListEdit.Text = lang[LanguageManager.Names.ButtonEdit];
            this.buttonListRemove.Text = lang[LanguageManager.Names.ButtonRemove];

            this.text_label.Text = lang[LanguageManager.Names.LabelMessage];
            this.time_label.Text = lang[LanguageManager.Names.LabelTime];
            this.messnumb_label.Text = lang[LanguageManager.Names.LabelNumber];
            this.delay_label.Text = lang[LanguageManager.Names.LabelDelay];
            this.thread_label.Text = lang[LanguageManager.Names.LabelThreads];

            this.ThreadsToolStripMenuItem.Text = lang[LanguageManager.Names.MenuThreads];
            this.SaveToolStripMenuItem.Text = lang[LanguageManager.Names.MenuSave];
            this.LoadToolStripMenuItem.Text = lang[LanguageManager.Names.MenuLoad];

            this.OptionsToolStripMenuItem.Text = lang[LanguageManager.Names.MenuOptions];
            this.LanguagesToolStripMenuItem.Text = lang[LanguageManager.Names.MenuLanguages];
            this.MBoxesToolStripMenuItem.Text = lang[LanguageManager.Names.MenuMB];
            this.MBOnToolStripMenuItem.Text = lang[LanguageManager.Names.MenuMBShow];
            this.MBOffToolStripMenuItem.Text = lang[LanguageManager.Names.MenuMBHide];

            this.HelpToolStripMenuItem.Text = lang[LanguageManager.Names.MenuHelp];
            this.AboutToolStripMenuItem.Text = lang[LanguageManager.Names.MenuAbout];
        }

        private void ShowMessageBox(string text)
        {
            if (MBoxState)
            {
                MessageBox.Show(text, lang[LanguageManager.Names.MBTitle], MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartThreads()
        {
            for (int i = 0; i < lists.threadList.Count; i++)
            {
                UpdateTitle();
                Thread.Sleep(lists.spamList[i].Delay);
                lists.threadList[i].Start();
            }
        }

        private void StopThreads()
        {
            // Stopping threads
            foreach (Thread thread in lists.threadList)
            {
                if (IsPaused) thread.Resume();
                thread.Abort();
            }

            // Removing / readding threads
            if (lists.RemoveFinalised) lists.ClearAll();
            else for (int i = 0; i < lists.spamList.Count; i++)
                    lists.EditAllAt(i, lists.spamList[i]);
        }

        private void ResumeThreads()
        {
            for (int i = 0; i < lists.threadList.Count; i++)
            {
                // Nie trzeba sprawdzać - nie da się uśpić zakończonego wątku(chyba)
                if (lists.threadList[i].IsAlive)
                {
                    Thread.Sleep(lists.spamList[i].Delay);
                    lists.threadList[i].Resume();
                }
            }
        }

        private void PauseThreads()
        {
            for (int i = 0; i < lists.threadList.Count; i++)
            {
                if (lists.threadList[i].IsAlive)
                    lists.threadList[i].Suspend();
            }
        }

        private void GetReadyToSpam()
        {
            BotUpdater.Stop();
            for (int i = 3; i >= 1; i--)
            {
                this.Text = lang[LanguageManager.Names.TitlePreparing] + i;
                Thread.Sleep(1000);
            }
            BotUpdater.Start();
        }

        private void UpdateTitle()
        {
            if (IsRunning)
            {
                if (IsPaused)
                {
                    this.Text = lang[LanguageManager.Names.TitlePaused];
                    buttonPause.Text = lang[LanguageManager.Names.ButtonResume];
                }
                else
                {
                    this.Text = lang[LanguageManager.Names.TitleActive];
                    buttonPause.Text = lang[LanguageManager.Names.ButtonPause];
                }
            }
            else
            {
                this.Text = lang[LanguageManager.Names.TitleInactive];
                buttonPause.Text = lang[LanguageManager.Names.ButtonPause];
            }
        }

        private void UpdateListBox()
        {
            // Updating list here
            if (listBoxThreads.Items.Count > 0)
            {
                for (int i = 0; i < lists.spamList.Count; i++)
                {
                    if (lists.spamList[i].NumberMessage != "") //&& Int64.Parse(x.NumberMessage) > 0)
                    {
                        //lists.spamList[i].UpdateNumberMessage();
                        lists.listBox.Items[i] = lists.CreateListBoxString(new SpamAction
                            (
                            lists.spamList[i].SpamMessage,
                            lists.spamList[i].Time.ToString(),
                            lists.spamList[i].Number.ToString(),
                            lists.spamList[i].Delay.ToString())
                            );
                    }
                }
            }
        }

        private void UpdateProgramState()
        {
            // Checking and removing inactive threads here
            for (int i = 0; i < lists.threadList.Count && lists.RemoveFinalised; i++)
            {
                if (!lists.threadList[i].IsAlive)
                    lists.RemoveAllAt(i);
            }

            // Updating program state
            if (lists.threadList.Count == 0)
            {
                buttonPause.Enabled = false;
                IsRunning = IsPaused = false;
            }
            else buttonPause.Enabled = true;
        }

        private void RemoveSelectedInListBox()
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBoxThreads);
            selectedItems = listBoxThreads.SelectedItems;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                if (lists.threadList[i].IsAlive)
                {
                    lists.threadList[i].Resume();
                    lists.threadList[i].Abort();
                }
                lists.RemoveAllAt(i);
            }
        }
    }
}