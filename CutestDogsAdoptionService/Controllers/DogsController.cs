using Microsoft.AspNetCore.Mvc;

namespace CutestDogsAdoptionService.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
