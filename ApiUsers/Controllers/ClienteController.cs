using ApiUsers.Models;
using ApiUsers.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiUsers.Controllers
{
    [Authorize]
    public class ClienteController : ApiController
    {
        static ICliente c = new RCliente();
        private Model1 conn = new Model1();
        //Metodo Get
        public HttpResponseMessage GetAll()
        {
            conn.Configuration.ProxyCreationEnabled = false;
            var items = c.GetAll();
            if (items.Count() == 0)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay registros");
            }
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }
    }
}
