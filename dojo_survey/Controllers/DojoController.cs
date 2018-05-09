using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class DojoController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult Landing()
        {   

            return View("index");
        }

        [HttpPostAttribute]
        [Route("success")]
        public IActionResult Success(string FirstName, string LastName, string Language, string Location)
        {
            ViewBag.FirstName = FirstName;
            ViewBag.LastName = LastName;
            ViewBag.Language = Language;
            ViewBag.Location = Location;
            return View("success");
        }
        
    }
}