using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kihson_s_Spam_Script
{
    public partial class ListBoxEditorForm : Form
    {
        public ListBoxEditorForm(ListManager lists, bool working, LanguageManager lang)
        {
            InitializeComponent();
            InitializeVeriables(lists, working, lang);
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            this.Text = lang[LanguageManager.Names.TitleEdit];

            this.buttonAccept.Text = lang[LanguageManager.Names.ButtonAccept];
            this.buttonCancel.Text = lang[LanguageManager.Names.ButtonCancel];

            this.messedit_label.Text = lang[LanguageManager.Names.LabelNewMessage];
            this.timeeidt_label.Text = lang[LanguageManager.Names.LabelNewTime];
            this.numberedit_label.Text = lang[LanguageManager.Names.LabelNewNumber];
            this.delayedit_label.Text = lang[LanguageManager.Names.LabelNewDelay];
        }

        private void InitializeVeriables(ListManager lists, bool working, LanguageManager lang)
        {
            this.lists = lists;
            this.lang = lang;

            this.textBoxEditMessage.Text = lists.spamList[Index].SpamMessage;
            this.textBoxEditTime.Text = lists.spamList[Index].Time.ToString();
            this.textBoxEditNumber.Text = lists.spamList[Index].NumberMessage;
            this.textBoxEditDelay.Text = lists.spamList[Index].Delay.ToString();

            Index = lists.listBox.SelectedIndex;
            Working = working;
        }

        private ListManager lists;
        private LanguageManager lang;
        private int Index { get; set; }
        private bool Working { get; set; }


        private void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                SpamAction spamAction = new SpamAction(textBoxEditMessage.Text, textBoxEditTime.Text, textBoxEditNumber.Text, textBoxEditDelay.Text);
                if (spamAction.SpamMessage == "") throw null;

                lists.EditAllAt(Index, spamAction);
                if (Working)
                {
                    lists.threadList[Index].Start();
                    lists.threadList[Index].Suspend();
                }

                this.Close();
            }
            catch
            {
                MessageBox.Show(lang[LanguageManager.Names.MBArgError], lang[LanguageManager.Names.MBTitle], MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}