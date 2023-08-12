using KareAjans.BLL.AbstractService;
using KareAjans.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KareAjans.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IOrderService _orderService;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IOrderService orderService, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _orderService = orderService;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        public IActionResult MyOrganizasyon(string id)
        {
            List<Order> orders = new List<Order>();

            if(_orderService.GetAllOrders().Where(x=>x.UserId==id).FirstOrDefault() != null)
            {
                foreach (var item in _orderService.GetAllOrders().ToList())
                {
                    if (item.UserId==id)
                    {

                        orders.Add(item);

                    }
                }
            }
          
            return View(orders);
        }

        public async Task<IActionResult> Logout()
        {
            
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        
    }
}
