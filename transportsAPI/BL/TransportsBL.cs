using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using transportsAPI.DL;

namespace transportsAPI.BL
{
    public class transportsBL
    {
        public int counttrans()
        {
            
            transportsDL tranDL1 = new transportsDL();
            int g = tranDL1.GetData1("spUserTransports");
            //logics

            return g;
        }
    }
}