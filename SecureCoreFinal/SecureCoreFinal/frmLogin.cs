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

namespace SecureCoreFinal
{
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        string query;
        DataSet dts;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void conectarBBDD()
        {
            string cnx;
            cnx = "Data Source=DESKTOP-HC4ANHR\\SQLEXPRESS_ORIOL;";
            conn = new SqlConnection(cnx);
        }

        private DataSet consultaBBDD()
        {
            query = "select * from users";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            dts = new DataSet();
            adapter.Fill(dts, "users");
            conn.Close();

            return dts;
        }

        private bool comprobarLogin()
        {
            dts = consultaBBDD();
            return false;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool comprobar;

            comprobar = comprobarLogin();

            if (comprobar)
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
            }

            
            SHA256 mySHA256 = SHA256.Create();
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
            conectarBBDD();
            consultaBBDD();
        }
    }
}
