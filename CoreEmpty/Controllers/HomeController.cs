using Microsoft.AspNetCore.Mvc;
using CoreEmpty.Models;

namespace CoreEmpty.Controllers // follows ProjectName.Controller but u can do whatever
{
    [Controller] // not obligatory, but okay practice

    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                List<string> errorsList = [];
                foreach (var value in ModelState.Values)
                {

                    foreach (var error in value.Errors)
                    {
                        errorsList.Add(error.ErrorMessage);
                    }
                }
                string errorMsg = string.Join("\n", errorsList);
                return BadRequest("Uh oh\n" + errorMsg);
            }

            return Content($"{person}");
        }
    }
}
