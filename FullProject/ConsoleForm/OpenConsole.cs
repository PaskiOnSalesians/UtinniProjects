using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace ConsoleForm
{
    public partial class OpenConsole : Form
    {
        public OpenConsole(string taula)
        {
            InitializeComponent();
        }

        private void btn_console_Click(object sender, EventArgs e)
        {
            string consolaftp = Application.StartupPath + "\\ConsolaFTP.exe";

            ProcessStartInfo startConsole = new ProcessStartInfo(Path.GetFullPath(consolaftp));
            startConsole.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(startConsole);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
