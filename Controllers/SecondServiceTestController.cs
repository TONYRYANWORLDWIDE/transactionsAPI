using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace transactionsAPI.Controllers
{

    public class SecondServiceTestController : ControllerBase
    {
        [Route("/testfromservice")]
        public int ReturnInt([FromServices]TestService service)
        {
            return service.ReturnInteger();
        }
    }
}