using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EBSRunADminTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProcessStartInfo processStartInfo;
        private void button1_Click(object sender, EventArgs e)
        {
            yoneticiexcute(@"C:\Windows\System32\ctfmon.exe");
        }

        private void yoneticiexcute(string yol)
        {
          processStartInfo = new  ProcessStartInfo(yol, "args");
            processStartInfo.Verb = "runas";

            using (Process process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();
            }
        }
    }
}
