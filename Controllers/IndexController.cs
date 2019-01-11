using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}