namespace MvcApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Why, howdy neighbour");
        }
    }
}