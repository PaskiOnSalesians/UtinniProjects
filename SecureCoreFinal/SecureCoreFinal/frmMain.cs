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
    public partial class frmMain : Form
    {
<<<<<<< Updated upstream
        public frmMain()
=======
        SqlConnection conn;
        SqlDataAdapter adapter;
        string query;
        DataSet dts;

        private void conectarBBDD()
        {
            string cnx;
            cnx = "Data Source=WHITEWOLF\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=True";
            conn = new SqlConnection(cnx);
        }

        private void generateButtons(int level)
        {

            query = "Select * from UserOptions " + " where minLevel <= '" + level + "'";
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            dts = new DataSet();
            adapter.Fill(dts, "UserOptions");
            conn.Close();


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
>>>>>>> Stashed changes
        {
            InitializeComponent();
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
