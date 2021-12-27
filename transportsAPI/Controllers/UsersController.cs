using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using transportsAPI.BL;

namespace transportsAPI.Controllers
{
    public class UsersController : ApiController
    {
        public HttpResponseMessage Get()
        {
            UsersBL userBL1 = new UsersBL();
            int count = userBL1.countusers();
            return Request.CreateResponse(HttpStatusCode.OK, count);

        }
    }
}
