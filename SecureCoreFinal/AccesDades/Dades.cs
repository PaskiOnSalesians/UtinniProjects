using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace AccesDades
{
    using System.Data;
    using System.Data.OleDb;
    using System.Data.SqlClient;

    using System.Configuration;
    using Microsoft.VisualBasic.CompilerServices;

    public class Dades
    {
        public SqlConnection con;
        public string conString;

        // Connectar a la Base de Dades
        #region Connectar
        public void ConnectDB()
        {
            this.conString = this.CadenaConnexio(); // Trae la cadena
            this.con = new SqlConnection(this.conString); // Nos genera la conexión
            this.con.Open(); // Obrim al connexió
            //this.con.InitializeLifetimeService();
        }
        #endregion

        // Obtenir la cadena de connexió de App.config
        #region Cadena Connexió
        private string CadenaConnexio()
        {
            string cadena = "";
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["SecureCorePaski"];
            
            if(settings != null)
            {
                cadena = settings.ConnectionString.ToString();
            }

            return cadena;
        }
        #endregion

        // Portar la Taula de la Base de Dades
        #region PortaTaula
        private DataTable PortaTaula(string taula, string query)
        {
            DataTable taulaData = null;

            this.ConnectDB();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from " + taula + " " + query, this.con);
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);

            taulaData = new DataTable();

            adapter.FillSchema(taulaData, SchemaType.Source);
            adapter.Fill(taulaData);

            // Borrar este intento
            #region Intento TryCatch
            /*
            catch (Exception exc)
            {
                Exception exc2 = exc;
                ProjectData.SetProjectError(exc2);
                Exception exception = exc2;
                ProjectData.ClearProjectError();
            }*/
            #endregion // Borrar 

            if (this.con != null)
            {
                this.con.Close();
                this.con.Dispose();
            }

            return taulaData;
        }
        #endregion

        // Portar una consulta i retornar les Dades per DataSet
        #region PortarPerConsulta

        public DataSet PortarPerConsulta(string query)
        {
            this.ConnectDB();
            SqlDataAdapter adapter = new SqlDataAdapter(query, this.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Taula");
            return dataSet;
        }

        public DataSet PortarPerConsulta(string query, string nomtaula)
        {
            this.ConnectDB();
            DataSet dataSet = new DataSet();
            new SqlDataAdapter(query, this.con).Fill(dataSet, nomtaula);
            return dataSet;
        }

        #endregion

        // Actualitzar la Base de Dades
        #region Actualitzar
        public void Actualitzar(string query, string taula, DataSet _dts)
        {
            this.ConnectDB();
            SqlDataAdapter adapter = new SqlDataAdapter(query, this.con);

            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);

            if (_dts.HasChanges())
            {
                adapter.Update(_dts, taula);
            }

            if(this.con != null)
            {
                this.con.Close();
                this.con.Dispose();
            }
        }
        #endregion

        // Executar
    }
}
