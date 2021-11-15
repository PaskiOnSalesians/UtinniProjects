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
        string idUserCategory;
        string accessLevel;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void conectarBBDD()
        {
            string cnx;
            cnx = "Data Source=DESKTOP-HC4ANHR\\SQLEXPRESS_ORIOL;Initial Catalog=SecureCore;Integrated Security=True";
            conn = new SqlConnection(cnx);
        }

        private string getAccessLevel(string idUserCategory)
        {
            string level = "";

            query = "Select * from UserCategories " + " where idUserCategory = '" + idUserCategory;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            dts = new DataSet();
            adapter.Fill(dts, "UserCategories");
            conn.Close();

            foreach (DataRow pRow in dts.Tables["UserCategories"].Rows)
            {
                level = pRow["AccessLevel"].ToString();
            }

            return level;
        }

        private bool comprobarLogin()
        {
            bool login = false;

            query = "Select * from Users " + " where Login = '" + swTextboxUsername.Text + "' AND Password ='" + swTextboxPasswd.Text + "'";
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            dts = new DataSet();
            adapter.Fill(dts, "Users");
            conn.Close();

            int registres = dts.Tables[0].Rows.Count;
            if(registres > 0)
            {
                login = true;
                foreach (DataRow pRow in dts.Tables["Users"].Rows)
                {
                    idUserCategory = pRow["idUserCategory"].ToString();
                }

                if(idUserCategory != null)
                {
                    accessLevel = getAccessLevel(idUserCategory);
                    MessageBox.Show(accessLevel);
                }
            }

            return login;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (comprobarLogin())
            {
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
            }
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
        }
    }
}
