using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace AccesDades
{
    public class Dades
    {
        private string _ConnectionString;
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }



    }
}
