using CoreEmpty.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CoreEmpty.Controllers // follows ProjectName.Controller but u can do whatever
{
    [Controller] // not obligatory, but okay practice
    public class StoreController : Controller
    // public class -> can be instantiated by ASP Core
    {
        [Route("store/books/{bookId?}/{isLoggedIn?}")]
        // With query parameters: /book?bookid={int}&isLoggedIn={true}
        // Note route parameters used - have higher priority than query parameters

        public IActionResult Book([FromRoute] int? bookId, [FromQuery] bool? isLoggedIn, Book book)
        // bookId only retrieved from route
        // isLoggedIn only retrieved from query

        {
            if (bookId.HasValue == false)
            {
                return BadRequest("Book id is not supplied");
            }

            if (bookId <= 0)
            {
                return BadRequest("Supply valid book id");
            }
            if (isLoggedIn == false)
            {
                return StatusCode(401); // automatically specified unauthorised user
            }

            return Content($"Book is found: {book}");
        }
    };
}
