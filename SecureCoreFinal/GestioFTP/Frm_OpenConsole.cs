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

namespace GestioFTP
{
    public partial class Frm_OpenConsole : Form
    {
        string path;
        public Frm_OpenConsole()
        {
            InitializeComponent();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_console_Click(object sender, EventArgs e)
        {
            Process.Start(path + "\\ConsolaFTP\\bin");
        }

        private void Frm_OpenConsole_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath;
        }
    }
}
