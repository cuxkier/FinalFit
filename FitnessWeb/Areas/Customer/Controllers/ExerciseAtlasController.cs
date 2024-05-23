using Microsoft.AspNetCore.Mvc;

namespace Fitness.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ExerciseAtlasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
