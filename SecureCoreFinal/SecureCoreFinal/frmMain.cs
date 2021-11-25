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

        private void conectarBBDD()
        {
            _Dades.ConnectDB();
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

        public frmMain(string username, int num)
        {
            InitializeComponent();
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
