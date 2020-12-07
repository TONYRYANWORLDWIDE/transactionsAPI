using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace transactionsAPI.Controllers
{
    
    public class ServiceTestController : ControllerBase
    {
        private readonly TestService _testService;
        public ServiceTestController(TestService testService)
        {
            _testService = testService;
        }

        [Route("testroute")]
        public string TestRoute()
        {
            return _testService.ReturnString();
        }
        
    }
}