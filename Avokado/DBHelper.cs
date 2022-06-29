using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Avokado
{
    class DBHElper
    {
        static public SqlConnection sqlConnection = null;
        static public void openConnection(ref SqlConnection sqlConnection)
        {
            string conString = $"Data Source=ngknn.ru;Initial Catalog=Avokado;User ID=31П;Password=12357";
            sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
        }
    }
}
