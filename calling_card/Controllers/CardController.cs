using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class CardController : Controller
    {

    [HttpGet]
    [Route("{name_input}/{last_input}/{age_input}/{color_input}")]
    public JsonResult DisplayInt(string name_input, string last_input, int age_input, string color_input)
    {
      var AnonObject = new {
            FirstName = name_input,
            LastName = last_input,
            Age = age_input,
            FavColor = color_input
                          };
      return Json(AnonObject);
    }
  }
}