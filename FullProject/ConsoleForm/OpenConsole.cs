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

namespace ConsoleForm
{
    public partial class OpenConsole : Form
    {
        string path;

        public OpenConsole(string taula)
        {
            InitializeComponent();
        }

        private void btn_console_Click(object sender, EventArgs e)
        {
            //Process.Start(path + "\\dll\\ConsolaFTP.exe");
            Process.Start(@"C:\\Users\\ribes\\Desktop\\projectefinal\\Utinni-Projectes\\SecureCoreFinal\\dll\\ConsolaFTP.exe");
        }

        private void OpenConsole_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
