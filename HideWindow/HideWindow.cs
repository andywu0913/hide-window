using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace HideWindow
{
    public partial class HideWindow : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
        static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        IntPtr targetWindow = IntPtr.Zero;

        public HideWindow()
        {
            InitializeComponent();

            Process[] procs = Process.GetProcesses();

            foreach (Process proc in procs)
            {
                if (proc.ProcessName == "notepad")
                {
                    //MessageBox.Show(proc.StartInfo.WindowStyle.ToString());
                    //proc.Kill();           
                }
            }
        }

        private void button_hide_Click(object sender, EventArgs e)
        {
            targetWindow = FindWindow(textBox_windowName.Text, null);
            if (targetWindow != IntPtr.Zero)
            {
                ShowWindow(targetWindow, 0);
                textBox_windowName.Enabled = false;
            }
            else
                MessageBox.Show("Window Not Found");
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            if (targetWindow != IntPtr.Zero)
            {
                ShowWindow(targetWindow, 1);
                textBox_windowName.Enabled = true;
            }
            else
                MessageBox.Show("Window Not Found");
        }
    }
}
