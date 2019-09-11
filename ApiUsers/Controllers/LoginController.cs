using ApiUsers.Models;
using ApiUsers.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiUsers.Controllers
{
    [AllowAnonymous]
    public class LoginController : ApiController
    {
        private Model1 db = new Model1();
        [HttpPost]
        public HttpResponseMessage Logueo(Users Login)
        {
            if (Login == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Ingrese un usuario correcto");
            }
            //var usuario = db.Users.Find(Login.username);
            var usuario = db.Users.SingleOrDefault(p => p.username.Equals(Login.username));
            
            if (usuario==null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Ingrese un usuario correcto");
            }
            var pass = usuario.pass;
            bool isPass = (Login.pass==pass);
            if (isPass)
            {
                var token = TokenGenerator.GenerateTokenJwt(Login.username);
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Usuario o contraseña es incorrecta");
            }
        }
    }
}
