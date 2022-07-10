using Microsoft.AspNetCore.Mvc;

namespace E_Ticketing.Controllers
{
    public class VehicleCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
