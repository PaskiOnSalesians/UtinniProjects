using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

using AccesDades;

namespace SecureCoreFinal
{
    public partial class frmLogin : Form
    {
        //string query;
        DataSet dts;
        DataTable dtsTable;

        Dades _Dades = new Dades();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach(DataRow dr in dts.Tables[0].Rows)
            {

            }

            /*
            if (comprobar)
            {
                this.Hide();
                frmMain frmMain = new frmMain(swTextboxUsername.Text, Int32.Parse(swTextboxPasswd.Text));
                frmMain.ShowDialog();
            }
            */
        }

        private void picTogglePass_MouseDown(object sender, MouseEventArgs e)
        {
            swTextboxPasswd.UseSystemPasswordChar = false;
        }

        private void picTogglePass_MouseUp(object sender, MouseEventArgs e)
        {
            swTextboxPasswd.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void swTextboxPasswd_Enter(object sender, EventArgs e)
        {
            swTextboxPasswd.UseSystemPasswordChar = true;
            swTextboxPasswd.SelectAll();
        }

        private void swTextboxUsername_Enter(object sender, EventArgs e)
        {
            swTextboxUsername.SelectAll();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _Dades.ConnectDB();
            dtsTable = _Dades.PortaTaula("select Login, Password, idUserCategory from Users");

            foreach(DataRow dr in dtsTable.Rows)
            {
                ShowMe.Text = dtsTable.Rows[dr].ToString() ;
            }
        }
    }
}
