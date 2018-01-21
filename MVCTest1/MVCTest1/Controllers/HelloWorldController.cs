using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCTest1.Controllers
{
    public class HelloWorldController : ApiController
    {// 
        // GET: /HelloWorld/ 
 
        public string Index() 
        { 
            return "This is my <b>default</b> action..."; 
        } 
 
        // 
        // GET: /HelloWorld/Welcome/ 
  
    }
}
