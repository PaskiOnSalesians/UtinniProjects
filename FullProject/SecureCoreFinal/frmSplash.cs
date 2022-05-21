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

        // Funcio del Timer
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            picSpaceShip.Left += 10;
            //Opacity -= 0.03;

            panelPgb1.Width += 10;

            if (panelPgb1.Width >= 380)
            {
                timerSplash.Stop();
                
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
        }
    }
}
