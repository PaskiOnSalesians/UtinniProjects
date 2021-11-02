using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCoreFinal
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            pgbLoading.Increment(4);
            Opacity -= 0.03;
            lblLoading.Text = pgbLoading.Value.ToString() + "%";

            if(Opacity == 0)
            {
                timerSplash.Stop();
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
        }
    }
}
