using AspNetCoreGeneratedDocument;
using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers

{
    // The [Route("product")] attribute specifies that the controller will handle requests that start with "/event".

    public class EventController : Controller
    {

        [HttpGet("event/register/{EventCode}")]
        public IActionResult Register([FromRoute] string EventCode)
        {
            //The View method returns a view result that renders a view to the response.
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm] EventRegistration model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Success", model);
        }

        [HttpGet]
        public  IActionResult Success(EventRegistration model)
        { return View(model); }



    }

}
