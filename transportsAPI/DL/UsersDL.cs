using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace transportsAPI.DL
{
    public class UsersDL
    {
        public static string cs = ConfigurationManager.ConnectionStrings["transportsdb"].ConnectionString;
        public static SqlConnection con = new SqlConnection(cs);
        public int getCount()
        {
            return 674;
        }
        //get parameters and store proc
        public DataTable getData(string usp, string uParam)
        {
            DataSet ds = new DataSet();
            try
            {
                string parm = uParam.Replace("&", "&amp;");
                SqlParameter sparam;
                SqlDataAdapter da;

                con.Open();
                SqlCommand com = new SqlCommand(usp, con);
                com.CommandType = CommandType.StoredProcedure;

                if(parm.Length!=0)
                {
                    sparam = new SqlParameter("@xmlparm", parm);
                    sparam.Direction = ParameterDirection.Input;
                    sparam.DbType = DbType.String;
                    com.Parameters.Add(sparam);
                }
                da = new SqlDataAdapter(com);
                da.Fill(ds, usp);

            }
            catch(Exception e)
            { throw e; }
            finally
            {
                con.Close(); con.Dispose();
            }
            return ds.Tables[0];
        }






    }
}