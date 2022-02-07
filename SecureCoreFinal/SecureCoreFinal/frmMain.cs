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

        string photo;
        string query;
        DataSet dts;
        int userCateogry;
        int level;

        public frmMain(string user)
        {
            InitializeComponent();
            getUsername(user);
        }

        private void getUsername(string user)
        {
            int registres;

            query = "select * from Users where Login = '" + user + "'";
            dts = _Dades.PortarPerConsulta(query, "Users");

            registres = dts.Tables[0].Rows.Count;

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                if (registres > 0)
                {
                    lblUsername.Text = "User: " + dr["UserName"].ToString();
                    userCateogry = (int)dr["idUserCategory"];
                    photo = dr["Photo"].ToString();
                    level = getAccessLevel(userCateogry);
                    //lblAccessLevel.Text = level.ToString();
                    //picUser.Image = Image.FromFile(photo);
                    generateButtons(level);
                }
            }
        }
        private int getAccessLevel(int category)
        {
            int level = 0;

            query = "select AccessLevel from UserCategories where idUserCategory = '" + category + "'";
            dts = _Dades.PortarPerConsulta(query, "UserCategories");

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                level = (int)dr["AccessLevel"];
            }

            return level;
        }
        private void generateButtons(int level)
        {
            query = "Select * from UserOptions " + " where minLevel >= '" + level + "'";

            dts = _Dades.PortarPerConsulta(query, "UserOptions");

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                LlancaApp btnLlenca = new LlancaApp();
                panelLeft.Controls.Add(btnLlenca);

                btnLlenca.Descripcio = dr["descripcio"].ToString();
                btnLlenca.Classe = dr["classe"].ToString();
                btnLlenca.Formulari = dr["formulari"].ToString();
                btnLlenca.NomTaula = dr["taula"].ToString();

                btnLlenca.Dock = DockStyle.Top;
            }
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _Dades.ConnectDB();
        }
    }
}
