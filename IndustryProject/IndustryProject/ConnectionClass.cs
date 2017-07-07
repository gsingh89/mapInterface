using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IndustryProject
{
    class ConnectionClass
    {
        public void Initialize()
        {
            String conString = "Data Source=Localhost;Initial Catalog=dbIndigenousPlaceNames;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM NAMES JOIN NAME_PLACES ON NAMES.NAME_ID = NAME_PLACES.NAME_ID JOIN PLACES ON NAME_PLACES.PLACE_ID = PLACES.PLACE_ID JOIN MULTIMEDIA_ASSETS ON MULTIMEDIA_ASSETS.PLACE_ID = PLACES.PLACE_ID JOIN FEATURE_TYPES.FEAT_CODE = PLACES.FEAT_CODE", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dataTab = new DataTable("dbIndigenousPlaceNames");
            adapt.Fill(dataTab);
            con.Close();

            if (dataTab.Rows.Count > 0)
            {
                
            }
        }

    }
}
