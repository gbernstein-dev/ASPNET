using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult Home()
        {    
            return View("home");
        }

        [HttpGetAttribute]
        [Route("projects")]
        public IActionResult Projects()
        {
            return View("projects");
        }

        [HttpGetAttribute]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View("contact");
        }
        
    }
}