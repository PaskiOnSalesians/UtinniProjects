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
using System.Data.SqlClient;


namespace ConsolaFTP
{
    public partial class CrystalLlistat : Form
    {
        public CrystalLlistat()
        {
            InitializeComponent();
        }

        int idOrder;

        public void agafarid(int idorder)
        {
            this.idOrder = idorder;

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
            ConnectionStringSettings cmx = ConfigurationManager.ConnectionStrings["SecureCoreServer"];
            connexio = cmx.ToString();

            return connexio;
        }

        private void frmprop()
        {
            
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("../ConsolaFTP/Llistat.rpt");

            cryRpt.RecordSelectionFormula = "{Orders.idOrder} = " + this.idOrder; 


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(BBDD()); 

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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            frmprop();
        }
    }
}
