using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Common.Entities;
using HotelManage.Models;
using HotelManage.Models.Dictionary;

namespace HotelManage.Controllers
{
    public class RoomController : ApiController
    {
        RoomBL r = new RoomBL();

        public HttpResponseMessage GetAll()
        {

            try
            {
                var lstRoom = r.GetAll();
                if (User.Identity.IsAuthenticated)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { code = 0, message = "no message", data = lstRoom });
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
                return Request.CreateResponse(HttpStatusCode.OK, new { code = 0, message = "no message", data = r.GetDetail(Id) });

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { code = 400, message = "fail", data = e });
            }
        }

    }
}