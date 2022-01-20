using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using transportsAPI.DL;
using transportsAPI.Models;

namespace transportsAPI.BL
{
    public class transportsBL
    {
        public int[] counttrans()
        {

            transportsDL tranDL1 = new transportsDL();
            DataTable dt = tranDL1.GetData1("spUserTransports");
            //logics
            int[] arr = new int[dt.Rows.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                DataRow r = dt.Rows[i];
                arr[i] = ((int)r["transportid"]);
            }
            return arr;
        }

        //public List<transports> counttrans2()
        //{
            
        //transportsDL tranDL1 = new transportsDL();
        //    DataTable dt = tranDL1.GetData2("spGetTransportsOfUser", "<parameters><userid>" + id + "</userid></parameters>");

        //    var result = (from rw in dt.Select()
        //                  select new transports
        //                  {
        //                      transportid = Convert.ToInt32(rw["id"]),
        //                      userid = Convert.ToInt32(rw["name"]),

        //                  }).ToList();


        //    return result;


        //}
    }   }