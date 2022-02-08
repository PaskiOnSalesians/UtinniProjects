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

namespace users
{
    public partial class FitxaUser : Form
    {
        public FitxaUser()
        {
            InitializeComponent();
        }
        string cmx = "";
        string server;
        string database;
        string user;
        string passwd;
        ReportDocument cryRpt;
        string impresora;

        private void connectar ()
        {
            //ConnectionStringSettings cmx = ConnectionStringSettings.ConnectionStrings[""];
            //string conexio = cmx.ToString();
            //return conexio;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //Passar el nom de llistat al visor

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("TarjaUser.rpt");



            // establir connexio i ruta de les dades

            cryRpt.RecordSelectionFormula = "User.idUser"; // posar id del clan"{Orders.idOrder} = " + this.idOrder;

            //Passar credencials per codi

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cmx);

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
        }
    }
}
