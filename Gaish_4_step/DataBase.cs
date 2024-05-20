using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Gaish_4_step
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DEKSTOP-ND\SQLEXPRESS;Initial Catalog=Gaish_4_step;Integrated Security=True");
        // DESKTOP-7QTLDNV && DEKSTOP-ND
        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
