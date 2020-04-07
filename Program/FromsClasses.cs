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
    public class ListManager
    {
        public ListManager(ListBox listBox)
        {
            this.listBox = listBox;
        }

        public ListBox listBox;
        public List<Thread> threadList = new List<Thread>();
        public List<SpamAction> spamList = new List<SpamAction>();
        //private string LBString { get; set; }

        public void AddToAll(SpamAction spamAction)
        {
            spamList.Add(spamAction);
            threadList.Add(new Thread(new ThreadStart(spamAction.SendMessage)));
            listBox.Items.Add(CreateListBoxString(spamAction));
        }

        public void EditAllAt(int index, SpamAction spamAction)
        {
            spamList[index] = spamAction;

            // destroy previous thread here
            if (threadList[index].IsAlive)
            {
                threadList[index].Resume();
                threadList[index].Abort();
            }
            threadList[index] = new Thread(new ThreadStart(spamAction.SendMessage));
            listBox.Items[index] = CreateListBoxString(spamAction);
        }

        public string CreateListBoxString(SpamAction spamAction)
        {
            String[] strings = new string[] { spamAction.Time.ToString(), spamAction.NumberMessage, spamAction.Delay.ToString() };
            string liststring = spamAction.SpamMessage;
            foreach (String s in strings)
            {
                liststring += ", ";
                if (s == "") liststring += "none";
                else liststring += s;
            }
            return liststring;
        }

        public void RemoveAllAt(int index)
        {
            threadList.RemoveAt(index);
            spamList.RemoveAt(index);
            listBox.Items.RemoveAt(index);
        }

        public void ClearAll()
        {
            threadList.Clear();
            spamList.Clear();
            listBox.Items.Clear();
        }
    }

    public class SpamAction
    {
        public SpamAction(string spammessage, string time, string number, string delay)
        {
            this.SpamMessage = spammessage;
            this.NumberMessage = number;

            if (time != "")
                this.Time = Int64.Parse(time);
            else this.Time = 0;

            if (number != "")
                this.Number = Int64.Parse(number);

            if (delay != "")
                Delay = Int32.Parse(delay);
            else Delay = 0;
        }

        public string SpamMessage { get; private set; }
        public Int64 Time { get; private set; }
        public string NumberMessage { get; private set; }
        public Int32 Delay { get; private set; }
        public Int64 Number { get; private set; }

        public void SendMessage()
        {
            while ((NumberMessage == "" || Number > 0)/*&& Working*/)
            {
                try
                {
                    Thread.Sleep((int)Time);
                    SendKeys.SendWait(SpamMessage);
                    SendKeys.SendWait("{Enter}");
                }
                catch { }

                if (NumberMessage != "" && Number > 0)
                    --Number;
            }
        }

        public void UpdateNumberMessage()
        {
            NumberMessage = Number.ToString();
        }

        public void SetNewDelay(string newdelay)
        {
            if (newdelay != "")
                Delay = Int32.Parse(newdelay);
            else Delay = 0;
        }
    }

    public abstract class LanguageManager
    {
        public virtual string this[Names names]
        {
            get { return null; }
        }

        // Add more enums (MB enum, Title enum ect)
        public enum Names
        {
            MBTitle, MBNoThreads, MBArgError, MBMissingData, MBBotActiveError, MBListSelectError,
            TitleActive, TitleInactive, TitlePaused, TitlePreparing, TitleEdit,
            ButtonAdd, ButtonPause, ButtonResume, ButtonEdit, ButtonRemove, ButtonAccept, ButtonCancel,
            LabelMessage, LabelTime, LabelNumber, LabelDelay, LabelThreads,
            LabelNewMessage, LabelNewTime, LabelNewNumber, LabelNewDelay,
            MenuThreads, MenuOptions, MenuLanguages, MenuMB, MenuMBShow, MenuMBHide, MenuHelp, MenuAbout
        }
    }

    public class Polish : LanguageManager
    {
        public override String this[Names e]
        {
            get { return names[(int)e]; }
        }

        private readonly String[] names = new string[]
        { 
            "O CHUJ",
            "Nie możesz rozpocząć/zakończyć działania programu bez wątków!",
            "Wprowadzone dane są niepoprawne!",
            "Nie wprowadziłeś wymaganych danych!",
            "Nie można usuwać wykonać akcji, skrypt jest aktywny!",
            "Wybrano nieprawidłową ilość elementów!",

            "Kihau\'s Spam Script - BOT AKTYWNY",
            "Kihau\'s Spam Script - BOT NIEAKTYWNY",
            "Kihau\'s Spam Script - BOT ZAPAUZOWANY",
            "Kihau\'s Spam Script - SPAMOWANIE ZA: ",
            "Kihau\'s Spam Script - OKNO EDYCJI",

            "DODAJ",
            "PAUZA",
            "WZNÓW",
            "EDYTUJ",
            "USUŃ",
            "AKCEPTUJ",
            "ANULUJ",

            "Wiadomość, którą chcesz spamować:",
            "Częstotliwość wysyłania (w ms):",
            "Ilość wiadomości do wysłania:",
            "Opóżnienie:",
            "Dodane wątki:",

            "Nowa wiadomość do spamowania:",
            "Nowa częstotliwość spamowania:",
            "         Nowa ilość wiadomości:",
            "              Nowe opóźnienie:",

            "Wątki",
            "Opcje",
            "Języki",
            "MessageBoxy", "Pokaż", "Ukryj", 
            "Pomoc",
            "O programie",

        };
    }

    public class English : LanguageManager
    {
        public override String this[Names e]
        {
            get { return names[(int)e]; }
        }

        private readonly String[] names = new string[]
        {
            "OH FUCK",
            "You cannot start/stop the bot without any threads!",
            "Given arguments are incorrect!",
            "Cannot add a thread, requierd arguments are missing!",
            "Cannot process the action, script is active!",
            "Incorrect number of elements selected!",

            "Kihau\'s Spam Script - BOT IS ACTIVE",
            "Kihau\'s Spam Script - BOT IS INACTIVE",
            "Kihau\'s Spam Script - BOT IS PAUSED",
            "Kihau\'s Spam Script - SPAMMING STARTS IN: ",
            "Kihau\'s Spam Script - EDIT WINDOW",

            "ADD",
            "PAUSE",
            "RESUME",
            "EDIT",
            "REMOVE",
            "ACCEPT",
            "CANCEL",

            "Message you want to be spammed:",
            "Spamming frequency (in ms):",
            "Number of messages to send:",
            "    Delay:",
            "Listed threads:",

            "         New message to spam:",
            "         New frequency (in ms):",
            "      New number of messages:",
            "                   New delay:",

            "Threads",
            "Options",
            "Languages",
            "MessageBoxes", "Show", "Hide",
            "Help",
            "About",
        };
    }
}