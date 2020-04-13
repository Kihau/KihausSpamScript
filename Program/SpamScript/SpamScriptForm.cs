using System;
using System.Windows.Forms;

namespace KihsonsBot.SpamScript
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

        private static bool IsPaused { get; set; }
        private static bool IsRunning { get; set; }
        private bool MBoxState { get; set; }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (lists.threadList.Count != 0 && !IsRunning)
            {
                IsRunning = true;
                GetReadyToSpam();
                StartThreads();
            }
            else if (!IsRunning) ShowMessageBox(lang[LanguageManager.Names.MBNoThreads]);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                StopThreads();
                ClearMessageBoxes();
                IsRunning = IsPaused = false;
            }
            else ShowMessageBox(lang[LanguageManager.Names.MBNoThreads]);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxSpamMessage.Text != "" && !IsRunning)
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
            else if (!IsRunning) ShowMessageBox(lang[LanguageManager.Names.MBMissingData]);
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                if (!IsPaused)
                    PauseThreads();
                else
                {
                    GetReadyToSpam();
                    UpdateTitle();
                    ResumeThreads();
                }
                IsPaused = !IsPaused;
            }
        }

        private void buttonListRemove_Click(object sender, EventArgs e)
        {
            if (listBoxThreads.SelectedIndex != -1 && (IsPaused || !IsRunning))
                RemoveSelectedInListBox();
            else if (IsRunning && !IsPaused)
                ShowMessageBox(lang[LanguageManager.Names.MBBotActiveError]);
            else ShowMessageBox(lang[LanguageManager.Names.MBListSelectError]);
        }

        private void buttonListEdit_Click(object sender, EventArgs e)
        {
            if (listBoxThreads.SelectedItems.Count == 1 && (IsPaused || !IsRunning))
            {
                BotUpdater.Stop();
                ListBoxEditorForm editWindow = new ListBoxEditorForm(lists, IsRunning, lang);
                editWindow.ShowDialog();
                BotUpdater.Start();
            }
            else if (listBoxThreads.SelectedItems.Count != 1)
                ShowMessageBox(lang[LanguageManager.Names.MBListSelectError]);
            else ShowMessageBox(lang[LanguageManager.Names.MBBotActiveError]);
        }

        private void checkBoxDeleteFinalised_CheckedChanged(object sender, EventArgs e)
        {
            lists.RemoveFinalised = !lists.RemoveFinalised;
        }

        private void BotUpdater_Tick(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                UpdateProgramState();
                UpdateListBox();
            }
            UpdateTitle();
        }
    }
}