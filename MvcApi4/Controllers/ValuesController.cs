using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApi4.Controllers
{
    public class ValuesController : ApiController
    {
        //[HttpGet]
        //[Route("api/v1/cash-management/tenders")]
        //public HttpResponseMessage Tenders()
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, "Tenders()");
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //}


        // GET api/values
        public IEnumerable<string> Get()
        {
            var section = ConfigurationManager.GetSection("server") as NameValueCollection;
            var value = section["url"];

            return new string[] { "value1", "value2", value };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}