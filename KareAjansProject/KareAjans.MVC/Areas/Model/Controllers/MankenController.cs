using KareAjans.BLL.AbstractService;
using KareAjans.Common;
using KareAjans.Entity.Entities;
using KareAjans.MVC.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KareAjans.MVC.Areas.Model.Controllers
{
    [Authorize(Roles = "Model")]
    [Area("Model")]
    public class MankenController : Controller
    {
        private int GetMankenIdFromCookie(HttpContext httpContext)
        {
            if (httpContext.Request.Cookies.TryGetValue("MankenId", out string mankenIdCookie))
            {
                if (int.TryParse(mankenIdCookie, out int mankenId))
                {
                    return mankenId;
                }
            }

            return 0; // Varsayılan değer veya hata durumu
        }

        private readonly IMankenService _mankenService;
        private readonly IFotografService _fotografService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MankenController(IMankenService mankenService, IFotografService fotografService, UserManager<IdentityUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _mankenService = mankenService;
            _fotografService = fotografService;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetManken()
        {
            int mankenId = GetMankenIdFromCookie(HttpContext);

            MankenFotografVM mankenFotografVM = new MankenFotografVM();
            var manken = _mankenService.FindManken(mankenId);
            mankenFotografVM.Mankenler = _mankenService.GetAllManken().ToList();
            mankenFotografVM.Fotograflar = _fotografService.GetAllFotograf().ToList();

            ViewBag.Manken = manken;
            var user = await _userManager.FindByIdAsync(manken.UserId);

            var userRole = await _userManager.GetRolesAsync(user);
            var roleName = userRole.FirstOrDefault();


            IdentityUser ıdentityUser = new IdentityUser();
            ıdentityUser.UserName = user.UserName;
            ViewBag.User = ıdentityUser;
            ViewBag.UserRole = roleName;
            return View(mankenFotografVM);

        }

        public IActionResult UpdateImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateImage(int id, IEnumerable<IFormFile> mankenImage)
        {
            var manken = _mankenService.FindManken(id);

            foreach (var image in mankenImage)
            {
                string webRootPath = _webHostEnvironment.WebRootPath;
                string path = "";
                path = Path.Combine(webRootPath, "images\\manken");
                string result = ImageUploader.UploadImage(path, image);
                Fotograf fotograf = new Fotograf();
                fotograf.Url = result;
                fotograf.MankenId = manken.Id;

                //todo: result bize "0" veya "1" değerini de dönebilir. Bu durumda karar yapısı kullanarak işlemleri ayırabilirsiniz.
                _fotografService.CreateFotograf(fotograf);
                manken.Fotograflar.Add(fotograf);

            }

            _mankenService.CreateManken(manken);
            return RedirectToAction("Index", "Home");

        }

        public IActionResult DeleteImages(string imageUrls)
        {
            var fotograf = _fotografService.GetAllFotograf().Where(x => x.Url == imageUrls).FirstOrDefault();
            var result = _fotografService.DeleteFotograf(fotograf);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int id)
        {

            var updated = _mankenService.FindManken(id);
            return View(updated);
        }
        [HttpPost]
        public IActionResult Update(Manken manken)
        {

            var userId=_mankenService.GetAllManken().Where(x=>x.Id==manken.Id).Select(x=>x.UserId).FirstOrDefault();
            manken.UserId = userId;
            _mankenService.UpdateManken(manken);
            return RedirectToAction("Index", "Home");
        }
    }
}
