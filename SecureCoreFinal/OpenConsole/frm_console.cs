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

namespace OpenConsole
{
    public partial class frm_console : Form
    {
        string path;

        public frm_console()
        {
            InitializeComponent();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_console_Click(object sender, EventArgs e)
        {
            Process.Start(path + "\\dll\\consola_ftp.exe");
        }

        private void frm_console_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath;
        }
    }
}
