using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace CompuTrabajo.Test.Repository.ConnectionBuilder
{
    public interface ISQLConnectionBuilder
    {
        SqlConnection buildConnection();
    }
}
