using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using transportsAPI.BL;
using transportsAPI.Models;

namespace transportsAPI.Controllers
{

    

    public class TransportsController : ApiController
    {

        transportsBL transBL1 = new transportsBL();

       
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                transportsBL trBL1 = new transportsBL();
                int[] arr = trBL1.counttrans();
                return Request.CreateResponse(HttpStatusCode.OK, arr);
           }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
