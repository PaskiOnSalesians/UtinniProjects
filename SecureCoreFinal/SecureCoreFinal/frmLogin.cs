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

namespace SecureCoreFinal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            SqlConnection conn;
            string cnx;
            cnx = "Data Source=DESKTOP-HC4ANHR\\SQLEXPRESS_ORIOL;";
            conn = new SqlConnection(cnx);


            SqlDataAdapter adapter;
            string query;
            query = "select * from users";

            adapter = new SqlDataAdapter(query, conn);
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
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
    }
}
