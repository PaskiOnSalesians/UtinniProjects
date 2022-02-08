using AccesDades;
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

namespace formsAuxiliars
{
    public partial class openConsole : Form
    {
        string path;

        public openConsole()
        {
            InitializeComponent();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_console_Click(object sender, EventArgs e)
        {
            Process.Start(path + "\\dll\\ConsolaFTP.exe");
        }

        private void openConsole_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath;
        }
    }
}
