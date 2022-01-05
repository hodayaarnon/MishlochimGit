using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using transportsAPI.DL;

namespace transportsAPI.BL
{
    public class UsersBL
    {
        public int countusers()
        {
            //UsersDL userDL1 = new UsersDL();

            //DataTable dt = userDL1.getCount();
            //if(dt.Rows.Count>0)
            //return dt.Rows.Count;
            //return -1;
            UsersDL userDL1 = new UsersDL();
            int g = userDL1.getCount();
            //logic

            return g;
        }
      

    }
}