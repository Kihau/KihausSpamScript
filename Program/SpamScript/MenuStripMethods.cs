using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KihsonsBot.SpamScript
{
    public partial class SpamScriptForm
    {
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

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsRunning && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XDocument doc = new XDocument();
                XElement config = new XElement("config");
                XElement element = new XElement("thread");

                foreach (var x in lists.spamList)
                {
                    element.Add(new XElement("message", x.SpamMessage));
                    element.Add(new XElement("time", x.Time));
                    element.Add(new XElement("number", x.NumberMessage));
                    element.Add(new XElement("delay", x.Delay));
                    config.Add(new XElement(element));
                    element.RemoveAll();
                }

                doc.Add(config);
                doc.Save(saveFileDialog.FileName);
            }
            else { } //exception
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsRunning && openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XDocument doc = XDocument.Load(openFileDialog.FileName);

                lists.ClearAll();
                foreach (XElement x in doc.Element("config").Elements("thread"))
                    lists.AddToAll(new SpamAction
                        (
                        x.Element("message").Value,
                        x.Element("time").Value,
                        x.Element("number").Value,
                        x.Element("delay").Value
                        ));
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarForms.HelpForm form = new MenuBarForms.HelpForm();
            form.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarForms.AboutProgramForm form = new MenuBarForms.AboutProgramForm();
            form.ShowDialog();
        }
    }
}
