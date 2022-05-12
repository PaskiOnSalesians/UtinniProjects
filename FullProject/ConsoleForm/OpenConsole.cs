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
        string path;

        public OpenConsole(string taula)
        {
            InitializeComponent();
        }

        private void btn_console_Click(object sender, EventArgs e)
        {
            //Process.Start(path + "\\dll\\ConsolaFTP.exe");

            string consolaftp = path + "\\ConsolaFTP.exe";

            Console.WriteLine(consolaftp);

            //Process.Start(Path.GetFullPath(consolaftp)); // @"C:\\Users\\ribes\\Desktop\\projectefinal\\Utinni-Projectes\\SecureCoreFinal"
            Process.Start(consolaftp); // @"C:\\Users\\ribes\\Desktop\\projectefinal\\Utinni-Projectes\\SecureCoreFinal"
            
        }

        private void OpenConsole_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath;
            Console.WriteLine(path);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
