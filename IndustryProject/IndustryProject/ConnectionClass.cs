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
        static List<SqlParameter> parameters;

        public static void Initialize()
        {
            parameters = new List<SqlParameter>();
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

        public static void AddParam(string paramName, string paramValue)
        {
            SqlParameter newParameter = new SqlParameter(paramName, paramValue);
            parameters.Add(newParameter);
        }

        public static void ClearParameters()
        {
            parameters = new List<SqlParameter>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SQLQueryText"></param>
        /// <returns></returns>
        public static DataSet getSQLData(string SQLQueryText)
        {
            SqlCommand SQLQuery = new SqlCommand(SQLQueryText, con);

            foreach (var param in parameters)
            {
                SQLQuery.Parameters.Add(param);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(SQLQuery);
            DataSet queryResult = new DataSet();
            
            adapter.Fill(queryResult);
            ClearParameters();

            return queryResult;
        }

        public static void myClose()
        {
            con.Close();
        }
    }
}