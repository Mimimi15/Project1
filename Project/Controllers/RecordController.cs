using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Controllers
{
    public class RecordController : ApiController
    {
        [Authorize]
        public int Get()
        {
            return 1452323;
        }
    }
   
}
