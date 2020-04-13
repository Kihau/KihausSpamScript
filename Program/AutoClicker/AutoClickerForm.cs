using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace KihsonsBot.AutoClicker
{
    public partial class AutoClickerForm : Form
    {
        public AutoClickerForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private void AutoClickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var spambot = new SpamScript.SpamScriptForm();
            spambot.Closed += (s, args) => this.Close();
            spambot.Show();
        }

        bool isRunning = false;

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;  
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (isRunning)
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    DoMouseClick();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
