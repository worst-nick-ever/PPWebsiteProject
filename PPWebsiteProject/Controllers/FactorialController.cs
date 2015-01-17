using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PPProjectRESTService.Controllers
{
    public class FactorialController : ApiController
    {
        [HttpGet]
        [ActionName("GetFactorial")]
        public HttpResponseMessage GetFactorial([FromUri]int id)
        {
            if (id <= 0 || id > 100)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid input");
            }

            double factorial = 1;

            for (int i = 1; i <= id; i++)
            {
                factorial *= i;
            }

            return Request.CreateResponse(HttpStatusCode.OK, factorial.ToString("F"));
        }
    }
}