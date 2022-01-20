using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace transportsAPI.DL
{
    public class transportsDL
    {

        public static string cs = ConfigurationManager.ConnectionStrings["transportsdb"].ConnectionString;
        public static SqlConnection Connection = new SqlConnection(cs);

        //get stored procedure and parameters
        public int GetData()
        {
            string query = "select * from transports";
            SqlCommand com = new SqlCommand(query, Connection);
            Connection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows.Count;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Connection.Close();
            }

        }

        public DataTable GetData1(string pSp)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter adapter;

                Connection.Open();
                SqlCommand command = new SqlCommand(pSp, Connection);
                command.CommandType = CommandType.StoredProcedure;

               
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, pSp);
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }
            return ds.Tables[0];
        }

        public DataTable GetData2(string pSp, string pParam)
        {
            
            DataSet ds = new DataSet();
            try
            {
                string parm = pParam.Replace("&", "&amp;");
                SqlParameter param;
                SqlDataAdapter adapter;

                Connection.Open();
                SqlCommand command = new SqlCommand(pSp, Connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parm.Length != 0)
                {
                    param = new SqlParameter("@xmlparm", parm);
                    param.Direction = ParameterDirection.Input;
                    param.DbType = DbType.String;
                    command.Parameters.Add(param);
                }
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, pSp);
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }
            return ds.Tables[0];
            
        }

    }
}