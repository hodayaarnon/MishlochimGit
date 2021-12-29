using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using transportsAPI.BL;
using transportsAPI.DL;
using transportsAPI.Models;

namespace transportsAPI.Controllers
{
    public class UsersController : ApiController
    {
         UsersDL dl1 = new UsersDL();

            //GET: /api/Users
            [HttpGet]
        //public IEnumerable<users> Get()
        //{

        //    try
        //    {
        //        DataTable dt = dl1.getData("SPgetusers", "<parameters></parameters>");
        //        var result = (from rw in dt.Select()
        //                      select new users
        //                      {
        //                          userid = Convert.ToInt32(rw["userid"]),
        //                          userlastname = Convert.ToString(rw["userlastname"]),
        //                          userfirstname = Convert.ToString(rw["userfirstname"]),

        //                      }).ToList();
        //        return result;
        //    }
        //    catch (Exception err)
        //    {
        //        throw err;
        //    }
        //}

        ////GET: api/Products/5
        //[HttpGet("{userid}")]
        //public ActionResult<Products> Get(string id)
        //{
        //    try
        //    {
        //        DataTable dt = dal.GetData("spGetProductById", "<parameters><id>" + id + "</id></parameters>");
        //        var result = new Products
        //        {
        //            id = Convert.ToString(dt.Rows[0]["id"])
        //            name = Convert.ToString(dt.Rows[0]["name"])
        //            description = Convert.ToString(dt.Rows[0]["description"])
        //            price = Convert.ToDouble(dt.Rows[0]["price"])
        //        }
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ////POST: api/Products
        //[HttpPost]
        //public void Post(string value)
        //{
        //    string preParm = value;
        //    try
        //    {
        //        dal.SetData("spCreateProductById", preParm);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ////PUT: api/Products/5
        //[HttpPut("{id}")]
        //public void Put(string id, string value)
        //{
        //    string preParm = value;
        //    try
        //    {
        //        dal.SetData("spUpdateProduct", preParm);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ////DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(string id)
        //{
        //    string preParm = "<parameters><id>" + id + "</id></parameters>";
        //    try
        //    {
        //        dal.SetData("spDeleteProduct", preParm);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
        //    }
        //}










        public HttpResponseMessage Get()
        {
            UsersBL userBL1 = new UsersBL();
            int count = userBL1.countusers();
            return Request.CreateResponse(HttpStatusCode.OK, count);

        }




    }
}
