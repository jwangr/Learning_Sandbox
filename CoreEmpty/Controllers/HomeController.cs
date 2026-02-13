using Microsoft.AspNetCore.Mvc;
using CoreEmpty.Models;

namespace CoreEmpty.Controllers // follows ProjectName.Controller but u can do whatever
{
    [Controller] // not obligatory, but okay practice
    public class HomeController : Controller // _controller is automatically identified by ASP.NET core as a controller 
    // public class -> can be instantiated by ASP Core
    // Optional: Controller class (from AspNetCore.Mvc)

    {
        // Define action methods
        [Route("sayhello")] // The route is an attribute. Can add multiple routes for same action method
        [Route("sayhello2")] // The route is an attribute. Can add multiple routes for same action method
        [Route("/")] // This is the default url
        public string Index() // by convention, default route will open this action method
        {
            // returns action result

            return "Hello it's your empty web API";
        }

        [Route("contact-us")]
        public string Contact()
        {
            return "Contact us now!";
        }

        [Route("about")]
        public ContentResult About() // can return content result
        {
            return Content("This is the response body and next argument is the content-MIME type", "text/plain");
        }

        [Route("person")]

        // Using a person model from CoreEmpty.Models
        public JsonResult Person()
        {
            // Initialise new person, with unique Guid
            Person person = new() { Id = Guid.NewGuid(), FirstName = "John", LastName = "Smith", Age = 25 };
            
            // return new JsonResult(person);
            return Json(person); // this is the short-hand way
        }
    };
}
