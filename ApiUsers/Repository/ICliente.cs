using ApiUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUsers.Repository
{
    public interface ICliente
    {
        IEnumerable<Cliente> GetAll();
    }
}
