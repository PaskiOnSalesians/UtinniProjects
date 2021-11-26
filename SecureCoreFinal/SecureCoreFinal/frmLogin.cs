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

        // Eventos
        #region Eventos

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _Dades.ConnectDB();
            dtsTable = _Dades.PortaTaula("select Login, Password, idUserCategory from Users");

            foreach (DataRow dr in dtsTable.Rows)
            {
                //ShowMe.Text = dtsTable.Rows[dr].ToString() ;
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            foreach (DataRow dr in dts.Tables[0].Rows)
            {

            }
        }

        // Boton de salida
        private void btnExit_Click(object sender, EventArgs e)
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
    }
}
