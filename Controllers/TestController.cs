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
    //[Route("[Controller]/[Action]")]
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


        //public string Action1()
        //{
        //    return "Test Controller Action 1";
        //}
        //public string Action2()
        //{
        //    return "Test Controller Action 2";
        //}
        //public string Action3()
        //{
        //    return "Test Controller Action 3";
        //}

        //[Route("api/test1")]
        //public string Test1()
        //{
        //    string testcookie = Request.Cookies["testcookie"];
        //    string testheader = Request.Headers["testheader"];
        //    string user_agent = Request.Headers["User-Agent"];
        //    return testcookie + " " + testheader + " " +  user_agent;
        //}

        //[Route("api/test2")]
        //public string Test2()
        //{
        //    Response.Cookies.Append("newcookie", "cookie value", new Microsoft.AspNetCore.Http.CookieOptions() {Expires = DateTime.UtcNow.AddDays(30) });
        //    Response.Headers.Add("newheader", "header Value");
        //    return "";
        //}

        public class testresponsemodel
        {
            public string val1 { get; set; }
            public int val2 { get; set; }
        }
        [Route("test1")]

        public testresponsemodel Test1()
        {

            return new testresponsemodel() { val1 = "test value1", val2 = 100 };
        }

        [Route("test3")]
        public FileStreamResult test3()
        {
            var mstr = new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes("test text"));
            return new FileStreamResult(mstr , "file/text");
        }
        

    }
}