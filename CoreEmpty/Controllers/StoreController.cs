using Microsoft.AspNetCore.Mvc;

namespace CoreEmpty.Controllers // follows ProjectName.Controller but u can do whatever
{
    [Controller] // not obligatory, but okay practice
    public class StoreController : Controller
    // public class -> can be instantiated by ASP Core
    {
        [Route("store/books")]
        // With query parameters: /book?bookid={int}&isLoggedIn={true}
        public IActionResult Book()
        {
            return new RedirectToActionResult("Book", "Home", new {} ); // give dummy value for routeValue here...cause not needed
        }
    };
}
