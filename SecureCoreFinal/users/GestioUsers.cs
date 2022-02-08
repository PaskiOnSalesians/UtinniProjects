using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;
using AccesDades;
using System.Data.SqlClient;

using formsAuxiliars;

namespace users
{
    public partial class GestioUsers: frmSimple
    {
        public GestioUsers(string taula)
        {
            InitializeComponent();
            nomTaula = taula;
        }

        string server;
        string database;
        string user;
        string passwd;
        ReportDocument cryRpt;
        string impresora;

        private string BBDD()
        {
            string connexio;
            ConnectionStringSettings cmx = ConfigurationManager.ConnectionStrings["SecureCore"];
            connexio = cmx.ToString();

            return connexio;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //try
            //{
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load("TarjaUser.rpt");



                // establir connexio i ruta de les dades

                cryRpt.RecordSelectionFormula = "{Users.UserName} = " + swTextbox_codi; // posar id del clan

                //Passar credencials per codi

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(BBDD()); //Posar la connexio per la BBDD

                server = builder.DataSource;
                database = builder.InitialCatalog;
                user = builder.UserID;
                passwd = builder.Password;

                ConnectionInfo crConnectionInfo = new ConnectionInfo();

                crConnectionInfo.ServerName = server;
                crConnectionInfo.DatabaseName = database;
                crConnectionInfo.UserID = user;
                crConnectionInfo.Password = passwd;



                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                Tables CrTables = cryRpt.Database.Tables;
                foreach (Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();


            //}
            //catch (Exception)
            //{

            //    throw;
            //}




            //string cnx = null;

            //ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["SecureCore"];

            //if (settings != null)

            //    cnx = settings.ConnectionString;

            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cnx);

            //server = builder.DataSource;
            //database = builder.InitialCatalog;
            //user = builder.UserID;
            //passwd = builder.Password;

            //this.Hide();
            //FitxaUser frm = new FitxaUser();
            //frm.ShowDialog();

        }

        //this.Hide();
        //FitxaUser frm = new FitxaUser();
        //frm.ShowDialog();

            
//}

//string server;
//string database;
//string user;
//string passwd;
//ReportDocument cryRpt;
//string impresora;

private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //Passar el nom de llistat al visor

           
        }

        private void swTextbox_codi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
