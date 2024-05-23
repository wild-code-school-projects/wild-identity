using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAuth.Controllers
{
    [Authorize]
    public class PrivateZoneController : Controller
    {
        public IActionResult Index()
        {
            return Content("Bienvenue dans la zone priver !");
        }
    }
}
