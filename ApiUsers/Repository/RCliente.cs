using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiUsers.Models;

namespace ApiUsers.Repository
{
    public class RCliente : ICliente
    {
        public IEnumerable<Cliente> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Cliente.ToList();
            }
            
        }
    }
}