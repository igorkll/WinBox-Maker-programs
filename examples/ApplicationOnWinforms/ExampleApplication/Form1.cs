using System.Diagnostics;

namespace ExampleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progress0_Click(object sender, EventArgs e)
        {
            progress.Value = 0;
        }

        private void progress100_Click(object sender, EventArgs e)
        {
            progress.Value = 100;
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void reboot_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }
    }
}
