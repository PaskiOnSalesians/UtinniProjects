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
        string query;
        DataSet dts = null;
        //DataTable dtsTable;

        Dades _Dades = new Dades();

        public frmLogin()
        {
            InitializeComponent();
        }

        // Eventos
        #region Eventos

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _Dades.ConnectDB();
            //dtsTable = _Dades.PortaTaula("select * from Users");
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Acceder al TextBox del usuario
        private void swTextboxUsername_Enter(object sender, EventArgs e)
        {
            swTextboxUsername.SelectAll();
        }

        // Acceder al TextBox de la contraseña
        private void swTextboxPasswd_Enter(object sender, EventArgs e)
        {
            swTextboxPasswd.UseSystemPasswordChar = true;
            swTextboxPasswd.SelectAll();
        }

        #endregion

        // Funciones Estéticas
        #region Funciones Estéticas

        // Mostrar la contraseña
        private void picTogglePass_MouseDown(object sender, MouseEventArgs e)
        {
            swTextboxPasswd.UseSystemPasswordChar = false;
        }

        // Esconder de nuevo la contraseña
        private void picTogglePass_MouseUp(object sender, MouseEventArgs e)
        {
            swTextboxPasswd.UseSystemPasswordChar = true;
        }

        #endregion

        // Funciones de Botones
        #region Botones

        // Boton de Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int registres;

            query = "select Login, Password from Users where Login = '" + swTextboxUsername.Text +
                    "' and Password='" + swTextboxPasswd.Text + "'";

            dts = _Dades.PortarPerConsulta(query, "Users");

            registres = dts.Tables[0].Rows.Count;

            if (registres > 0)
            {
                this.Hide();
                frmMain frm = new frmMain(swTextboxUsername.Text);
                frm.ShowDialog();
            }
        }

        // Boton de salida
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion        
    }
}
