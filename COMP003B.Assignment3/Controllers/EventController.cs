using AspNetCoreGeneratedDocument;
using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers

{
    // The [Route("product")] attribute specifies that the controller will handle requests that start with "/event".
    [Route("event")]
    public class EventController : Controller
    {

        [HttpGet("register/{EventCode}")]
        public IActionResult Register(string EventCode)
        {
            //The View method returns a view result that renders a view to the response.
            return View();
        }


        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("Success")]
        public IActionResult EventRegistration()
        {
            if (!ModelState.IsValid)
            {
                return View("Success");
            }

            return RedirectToAction("Success");
        }

        [HttpGet("Success")]
        public IActionResult Success()
        { return View(); }




    }

}
