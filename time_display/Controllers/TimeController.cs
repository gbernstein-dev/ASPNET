using System;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class TimeController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult Index()
        {
            
            return View();
        }
        
    }
}