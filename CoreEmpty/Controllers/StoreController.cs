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
            return new RedirectToActionResult("Book", "Home", new { });
            // give dummy value for routeValue here...cause not needed. Otherwise redirect with route value id="bookId" for e.g.
            // returns 302 - Found other website
            // permanent: true = returns 301 (moved permanently)
            // return LocalRedirect("url route") - only works within the same application, without needing to use action name and controller name; not as widely used. Returns 302, unless permanent: true
        }
    };
}
