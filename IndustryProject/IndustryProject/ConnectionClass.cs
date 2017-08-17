using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace IndustryProject
{
    /// <summary>
    /// Class to handle an interaction between the database and this application.
    /// </summary>
    public static class ConnectionClass
    {
        static String conString;
        static SqlConnection con;

        //Parameterization necessary against bad injections.
        static List<SqlParameter> parameters;

        /// <summary>
        /// Initialize connection.
        /// </summary>
        public static void Initialize()
        {
            parameters = new List<SqlParameter>();
            conString = ConfigurationManager.ConnectionStrings["IndustryProject"].ConnectionString;
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

        /// <summary>
        /// Parameters are going to act like vehicles for carrying user entered data.
        /// </summary>
        /// <param name="paramName">Parameter name later used with @ sign</param>
        /// <param name="paramValue">Actual value in ""</param>
        public static void AddParam(string paramName, string paramValue)
        {
            SqlParameter newParameter = new SqlParameter(paramName, paramValue);
            parameters.Add(newParameter);
        }

        /// <summary>
        /// Method to flush.
        /// </summary>
        public static void ClearParameters()
        {
            parameters = new List<SqlParameter>();
        }

        /// <summary>
        /// Method to have a carrier ready that can take a SELECT query in as a String.
        /// </summary>
        /// <param name="SQLQueryText"></param>
        /// <returns></returns>
        public static DataSet getSQLData(string SQLQueryText)
        {
            SqlCommand SQLQuery = new SqlCommand(SQLQueryText, con);

            if (parameters.Count() != 0 || parameters != null)
            {
                foreach (var param in parameters)
                {
                    SQLQuery.Parameters.Add(param);
                } 
            }

            //Adapter interacts with data and returnable query.
            SqlDataAdapter adapter = new SqlDataAdapter(SQLQuery);
            DataSet queryResult = new DataSet();
            
            adapter.Fill(queryResult);
            ClearParameters();

            return queryResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void myClose()
        {
            con.Close();
        }
    }
}