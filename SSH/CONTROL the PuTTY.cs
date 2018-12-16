using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)] public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")] public static extern bool SetForegroundWindow(IntPtr hWnd);

        private void button1_Click(object sender, EventArgs e)
        {
            PuTTY_ConfigWindow();
            Security_Alert();
            PuTTY_CONSOLE();
        }

        void PuTTY_ConfigWindow()
        {
            IntPtr WindowHandle = FindWindow("PuTTYConfigBox", null);

            if (WindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("ERROR");
                return;
            }

            SetForegroundWindow(WindowHandle);
            SendKeys.Send("10.10.10.10");
        }

        void Security_Alert()
        {
            IntPtr WindowHandle = FindWindow(null, "PuTTY Security Alert");

            if (WindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("ERROR");
                return;
            }

            SetForegroundWindow(WindowHandle);
            SendKeys.Send("{ENTER}");
        }

        void PuTTY_CONSOLE()
        {
            IntPtr WindowHandle = FindWindow("PuTTY", null);

            if (WindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("ERROR");
                return;
            }

            SetForegroundWindow(WindowHandle);
            SendKeys.Send("{ENTER}");
        }
    }
}
