using HotelManage.Models.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelManage.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeBL emp = new EmployeeBL();

        public HttpResponseMessage GetAll()
        {

            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { code = 0, message = "no message", data = emp.GetAll() });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { code = 1, message = "no authorize", data = (string)null });
                }

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { code = 400, message = "fail", data = e });
            }
        }

        public HttpResponseMessage GetDetail(Guid Id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { code = 0, message = "no message", data = emp.GetDetail(Id) });

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { code = 400, message = "fail", data = e });
            }
        }
    }
}
