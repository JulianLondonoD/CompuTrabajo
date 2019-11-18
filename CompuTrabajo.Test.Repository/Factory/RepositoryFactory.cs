using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;
using CompuTrabajo.Test.Repository.ConnectionBuilder;

namespace CompuTrabajo.Test.Repository.Factory
{
    public class RepositoryFactory : RepositoryFactoryAbstract
    {
        private static ISQLConnectionBuilder _connectionBuilder;

        public RepositoryFactory() 
        {
            _connectionBuilder = new SQLConnectionBuilder();
        }

        public static int ExecuteNonQuery(string query, string[] queryParams)
        {

            SqlConnection con = null;
            try
            {
                con = _connectionBuilder.buildConnection();
                con.Open();
                var command = new SqlCommand(query, con);

                for (int i = 0; i < queryParams.Length; i++)
                {
                    command.Parameters.Add(new SqlParameter((i + 1).ToString(CultureInfo.InvariantCulture),
                                                               queryParams[i]));
                }

                return command.ExecuteNonQuery();
            }
            finally
            {
                closeConnection(con);
            }
        }

        public static DataTable GetQueryResult(string query, string[] queryParams)
        {
            var tableResponse = new DataTable();
            SqlConnection con = null;
            try
            {
                con = _connectionBuilder.buildConnection();
                con.Open();
                var command = new SqlCommand(query, con);
                for (int i = 0; i < queryParams.Length; i++)
                {
                    command.Parameters.Add(new SqlParameter((i + 1).ToString(CultureInfo.InvariantCulture),
                                                               queryParams[i]));
                }

                var adaptador = new SqlDataAdapter(command);

                adaptador.Fill(tableResponse);

                return tableResponse;
            }
            finally
            {
                closeConnection(con);
            }
        }

        private static void closeConnection(SqlConnection con)
        {
            if (con != null && con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        public override IEmployeesRepository GetEmployeesRepository()
        {
            return new EmployeesRepository();
        }
    }
}
