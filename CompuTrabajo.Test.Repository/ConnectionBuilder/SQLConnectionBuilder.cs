using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data.SqlClient;

namespace CompuTrabajo.Test.Repository.ConnectionBuilder
{
    public class SQLConnectionBuilder: ISQLConnectionBuilder
    {
        private static string _strConnection;

        public SQLConnectionBuilder() 
        { 
            _strConnection = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
        }

        public SqlConnection buildConnection()
        {
            return new SqlConnection(_strConnection);
        }
    }
}
