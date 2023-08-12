using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KareAjans.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {


        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;



        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {

            var users = _userManager.Users.ToList();

            return View(users);
        }

        public async Task<IActionResult> AddToRole(string id)
        {

            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                await _userManager.RemoveFromRoleAsync(user, "User");
                var result = await _userManager.AddToRoleAsync(user, "Muhasebe");
                if (result.Succeeded)
                {
                    TempData["Success"] = "İşlem başarılı";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Error"] = "hata meydana geldi";
                    return View();
                }
            }
            else
            {
                return View();
            }


        }


        [Authorize(Roles = "Admin")]
        public IActionResult CreateRole()
        {
            return View();
        }
    }
}
