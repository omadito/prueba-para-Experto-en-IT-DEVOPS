using Prueba_para_Experto_en_IT___DEVOPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_para_Experto_en_IT___DEVOPS.Controllers
{
    public class holaController : ApiController
    {
        hola hello = new hola();

        public hola GetHola()
        {
            return (hello);
        }

    }
}
