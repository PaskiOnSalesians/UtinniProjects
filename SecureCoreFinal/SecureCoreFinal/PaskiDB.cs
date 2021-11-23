namespace SecureCoreFinal
{
    // Usings for Default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Usings by User
    using Microsoft.VisualBasic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Collections;
    using System.Configuration;
    using Microsoft.VisualBasic.CompilerServices;

    class PaskiDB
    {
        public SqlConnection con;
        public string conString;

        // Funcio per a connectar-se
        public void Connect(string conStr)
        {
            this.con = new SqlConnection(this.conString);
            this.con.Open();
            this.con.InitializeLifetimeService();
        }

        // Funció per agafar la taula
        public DataTable PortarTaula(string taula, string query, string conStr)
        {
            DataTable data = null;

            try
            {
                this.Connect(conStr);
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from " + taula + " where 1=1 " + query, this.con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                data = new DataTable();
                adapter.FillSchema(data, SchemaType.Source);
                adapter.Fill(data);
            }
            catch (Exception _exception)
            {
                Exception ex = _exception;
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
            finally
            {
                if (this.con != null)
                {
                    this.con.Close();
                    this.con.Dispose();
                }
            }

            return data;
        }

        // Funció de consulta
        public DataSet PortarPerConsulta(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            con.Open();
            DataSet dts = new DataSet();
            adapter.Fill(dts, "UserCategories");
            con.Close();

            return dts;
        }
    }
}
