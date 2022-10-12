using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace login_form_final
{
    class connection_DB
    {

        public SqlConnection Load_Connection()
        {

            SqlConnection cnn = new SqlConnection();
            string strConnect;
            try
            {
                strConnect = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ToString();
                cnn.ConnectionString = strConnect;
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {

                return cnn;
            }
        }




        public DataTable Get_DataTable(string strSQL, SqlConnection cnn)
        {
            SqlDataAdapter SqlAdp = new SqlDataAdapter(strSQL, cnn);
            DataTable dtb = new DataTable();
            SqlAdp.Fill(dtb);
            return dtb;
        }


        public string Excute_DataTable(string strSQL, SqlConnection cnn)
        {
            try
            {
                int x = 0;
                //SqlDataAdapter SqlAdp = new SqlDataAdapter(strSQL, cnn);
                SqlCommand cmd = new SqlCommand(strSQL, cnn);
                x = cmd.ExecuteNonQuery();
                return "";

            }
            catch (Exception ex)
            {

                return strSQL;
            }

        }



    }
}
