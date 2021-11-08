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

        int x = 0;

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            picSpaceShip.Left += 9;
            //Opacity -= 0.03;

            panelPgb1.Width += 9;
            panelPgb2.Width += 9;

            if (panelPgb1.Width >= 360)
            {
                timerSplash.Stop();
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
        }
    }
}
