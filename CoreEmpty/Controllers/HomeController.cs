using Microsoft.AspNetCore.Mvc;

namespace CoreEmpty.Controllers // follows ProjectName.Controller but u can do whatever
{
    public class HomeController : Controller // _controller is automatically identified by ASP.NET core as a controller 
    // // public class -> can be instantiated by ASP Core
    {
        // Define action methods
        [Route("sayhello")] // The route is an attribute. Can add multiple routes for same action method
        [Route("sayhello2")] // The route is an attribute. Can add multiple routes for same action method
        [Route("/")] // This is the default url
        public string Index () // by convention, default route will open this action method
        {
            // returns action result

            return "Hello it's your empty web API";
        }

        [Route("contact-us")]
        public string Contact ()
        {
            return "Contact us now!";
        }

        [Route("about")]
        public string About ()
        {
            return "About us is here!";
        }
    }
}