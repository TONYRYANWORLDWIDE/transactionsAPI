using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace transactionsAPI.Controllers
{
    [Route("httpmethodroutes")]
    public class ThirdTestController : Controller
    {
        
        [HttpGet]
        public string Action_Get()
        {
            return "get method";
        }

        [HttpPut]
        public string Action_Put()
        {
            return "put method";
        }
    }
}
