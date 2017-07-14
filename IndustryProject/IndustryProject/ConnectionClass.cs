using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IndustryProject
{
    public static class ConnectionClass
    {
        static String conString;
        static SqlConnection con;

        public static void Initialize()
        {
            conString = "Data Source=Localhost;Initial Catalog=dbIndigenousPlaceNames;Integrated Security=True";
            con = new SqlConnection(conString);

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet getSQLData(string SQLQueryText)
        {
            SqlCommand SQLQuery = new SqlCommand(SQLQueryText, con);
            SqlDataAdapter adapter = new SqlDataAdapter(SQLQuery);
            DataSet queryResult = new DataSet();
            //adapter.Fill(queryResult);

            return queryResult;
        }

        public static void myClose()
        {
            con.Close();
        }
    }
}
