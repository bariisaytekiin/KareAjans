using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KareAjans.MVC.Areas.Model.Controllers
{
    [Authorize(Roles = "Model")]
    [Area("Model")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
