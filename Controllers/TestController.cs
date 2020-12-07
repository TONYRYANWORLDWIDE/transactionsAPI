using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace transactionsAPI.Controllers
{
    //[Route("/basicstringroute")]
    //[ApiController]
    [Route("[Controller]/[Action]")]
    public class TestController : ControllerBase
    {
        //[Route("/basicstringroute")]
        //public string BasicStringAction()
        //{
        //    return "Text Response";
        //}

        //[Route("/basicintroute")]
        //public int BasicIntAction()
        //{
        //    return 100;
        //}

        
        public string Action1()
        {
            return "Test Controller Action 1";
        }
        public string Action2()
        {
            return "Test Controller Action 2";
        }
        public string Action3()
        {
            return "Test Controller Action 3";
        }
    }
}