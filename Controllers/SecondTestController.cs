using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace transactionsAPI.Controllers
{
    
   
    public class SecondTestController : ControllerBase
    {
        [Route("test1/action1")]
        public string Action1()
        {
            return Request.Form["val1"] + " " + Request.Form["val2"];
        }
        [Route("test1/action2")]
        public string Action2()
        {
            return Request.Query["val1"] + " " + Request.Query["val2"];
        }

        [Route("test1/action3")]
        public async Task<string> Action3()
        {
            byte[] bt = new byte[(int)Request.ContentLength];
            await Request.Body.ReadAsync(bt, 0, (int)Request.ContentLength);
            return System.Text.Encoding.UTF8.GetString(bt);

        }
    }
}