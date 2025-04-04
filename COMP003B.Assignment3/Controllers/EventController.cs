using AspNetCoreGeneratedDocument;
using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers

{
    // The [Route("product")] attribute specifies that the controller will handle requests that start with "/event".
    [Route("event")]
    public class EventController : Controller
    {

        [HttpGet("event/register/{EventCode}")]
        public IActionResult Register(string EventCode)
        {
            //The View method returns a view result that renders a view to the response.
            return View();
        }


        [HttpGet("Event/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("Event/Register")]
        public IActionResult EventRegistration()
        {
            return View();
        }

    }

}
