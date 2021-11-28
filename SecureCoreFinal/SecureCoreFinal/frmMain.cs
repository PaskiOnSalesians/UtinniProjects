using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UsControl;
using AccesDades;

namespace SecureCoreFinal
{
    public partial class frmMain : Form
    {
        Dades _Dades = new Dades();

        string query;
        DataSet dts;

        public frmMain(string username)
        {
            InitializeComponent();

            getUsername(username);
        }

        private void getUsername(string user)
        {
            int registres;

            query = "select UserName from Users where Login = '" + user + "'";
            dts = _Dades.PortarPerConsulta(query, "Users");

            registres = dts.Tables[0].Rows.Count;

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                if (registres > 0)
                {
                    //lblUsername.Text = dts.Tables[0].Rows.;
                }
            }
        }

        private void generateButtons(int level)
        {
            query = "Select * from UserOptions " + " where minLevel <= '" + level + "'";

            dts = _Dades.PortarPerConsulta(query);

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                LlancaApp btnLlenca = new LlancaApp();
                panelLeft.Controls.Add(btnLlenca);

                btnLlenca.Descripcio = dr["descripcio"].ToString();
                btnLlenca.Classe = dr["classe"].ToString();
                btnLlenca.Formulari = dr["formulari"].ToString();

                btnLlenca.Dock = DockStyle.Top;
            }
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(string username, object sender, EventArgs e)
        {
            _Dades.ConnectDB();
        }
    }
}
