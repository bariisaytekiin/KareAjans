using Kareajans.Common;
using Kareajans.MVC.Utils;
using KareAjans.BLL.AbstractService;
using KareAjans.BLL.Service;
using KareAjans.DAL.Context;
using KareAjans.Entity.Entities;
using KareAjans.MVC.Models;
using KareAjans.MVC.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using System.Diagnostics;
using System.Web;

namespace KareAjans.MVC.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly IMankenService _mankenService;
        private readonly IOrganizasyonService _organizasyonService;
        private readonly KareAjansContext _context;
        private readonly IOrganizasyonGiderService _organizasyonGiderService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IFotografService _fotografService;
        private readonly IAdresService _adresService;

        public HomeController(ILogger<HomeController> logger, IMankenService mankenService, IOrganizasyonService organizasyonService, KareAjansContext context, IOrganizasyonGiderService organizasyonGiderService, UserManager<IdentityUser> userManager, IOrderService orderService, IOrderDetailService orderDetailService, SignInManager<IdentityUser> signInManager, IFotografService fotografService,IAdresService adresService)
        {
            _logger = logger;
            _mankenService = mankenService;
            _organizasyonService = organizasyonService;
            _context = context;
            _organizasyonGiderService = organizasyonGiderService;
            _userManager = userManager;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _signInManager = signInManager;
            _fotografService = fotografService;
            _adresService = adresService;
        }

        public IActionResult Index()
        {
            MankenFotografVM mankenFotografVM = new MankenFotografVM();
            mankenFotografVM.Mankenler = _mankenService.GetAllManken().ToList();
            mankenFotografVM.Fotograflar = _fotografService.GetAllFotograf().ToList();

            return View(mankenFotografVM);
        }
        [HttpPost]
        public IActionResult Index(DateTime baslangic, DateTime bitis, bool? sehirdisicalisma)
        {
            var organizasyon = _organizasyonService.GetAllOrganizasyon()
            .Where(org =>
                (org.BaslangicTarihi > bitis) ||
                (org.BitisTarihi < baslangic))
            .ToList();


            var organizasyonGiderleri = _organizasyonGiderService.GetAllOrganizasyonGider();
            MankenFotografVM mankenFotografVM = new MankenFotografVM();


            List<Manken> mankens = new List<Manken>();
            List<Fotograf> fotografs = new List<Fotograf>();
            List<OrganizasyonGider> gider = new List<OrganizasyonGider>();
            mankenFotografVM.Mankenler = _mankenService.GetAllManken().ToList();
            mankenFotografVM.Fotograflar = _fotografService.GetAllFotograf().ToList();
            var a = _mankenService.GetAllManken().ToList();
            var b = _fotografService.GetAllFotograf().ToList();

            foreach (var item in organizasyonGiderleri)
            {
                var oId = organizasyon.FirstOrDefault(x => x.Id == item.OrganizasyonId);

                if (oId == null)
                {
                    mankens.AddRange(_context.Mankenler.Where(x => x.Id == item.MankenId).ToList());
                    fotografs.AddRange(_context.Fotograflar.Where(x => x.MankenId == item.MankenId).ToList());
                }

            }
            if (sehirdisicalisma != null)
            {
                foreach (var item in _mankenService.GetAllManken().ToList())
                {
                    if (item.SehirDisiCalisma != sehirdisicalisma)
                    {
                        mankens.Add(item);
                    }
                }
            }
            


            foreach (var manken in mankenFotografVM.Mankenler)
            {
                if (mankens.Where(x => x.Id == manken.Id).FirstOrDefault() != null)
                {
                    a.Remove(manken);
                }
            }
            foreach (var fotograf in mankenFotografVM.Fotograflar)
            {
                if (fotografs.Where(x => x.MankenId == fotograf.MankenId) == null)
                {
                    b.Remove(fotograf);
                }
            }

            mankenFotografVM.Mankenler = a;
            mankenFotografVM.Fotograflar = b;

            return View(mankenFotografVM);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = registerVM.Username;

                var emailControl = await _userManager.FindByEmailAsync(registerVM.Email);



                if (emailControl == null)
                {

                    user.Email = registerVM.Email;
                    var result = await _userManager.CreateAsync(user, registerVM.ConfirmPassword);
                    if (result.Succeeded)
                    {
                        if (_mankenService.GetAllManken().Where(x => x.Email == registerVM.Email).FirstOrDefault() != null)
                        {
                            var sonuc = await _userManager.AddToRoleAsync(user, "Model");
                            var id = _mankenService.GetAllManken().Where(x => x.Email == registerVM.Email).FirstOrDefault().Id;
                            var manken=_mankenService.FindManken(id);
                            manken.UserId=user.Id;
                            _mankenService.UpdateManken(manken);


                        }
                        else
                        {
                           await _userManager.AddToRoleAsync(user, "User");
                        }
                        TempData["Success"] = $"{registerVM.Username} isimli kullanıcı oluşturuldu.";
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(error.Code, error.Description);

                        }
                        return View(registerVM);
                    }

                }
                else
                {
                    TempData["Error"] = $"{registerVM.Email} email başka bir kullanıcıya ait.";
                    return View(registerVM);
                }


            }
            else { return View(registerVM); }
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginVM.Email);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

                    if (result.Succeeded)
                    {
                        var roles = await _userManager.GetRolesAsync(user);
                        if (roles.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                        else if (roles.Contains("Model"))
                        {
                            //TempData["MankenId"]
                            var id = user.Id;
                             var manken= _mankenService.GetAllManken().Where(x => x.UserId == id).Select(x => x.Id).FirstOrDefault();

                            int mankenId =manken; // Burada çerezde saklayacağınız manken ID'sini belirleyin.

                            var cookieOptions = new CookieOptions
                            {
                                Expires = DateTimeOffset.UtcNow.AddMonths(1),
                                IsEssential = true,
                                Path = "/",
                                Secure = true,
                                HttpOnly = true,
                                SameSite = SameSiteMode.Lax
                            };

                            HttpContext.Response.Cookies.Append("MankenId", mankenId.ToString(), cookieOptions);
                            TempData["MankenId"] = mankenId;
                            return RedirectToAction("Index");


                        }
                        else if (roles.Contains("Muhasebe"))
                        {
                            return RedirectToAction("Index", "Muhasebe");
                        }
                        else
                        {
                            return RedirectToAction("Index");
                        }

                    }
                    else
                    {
                        return View(loginVM);
                    }
                }
                else
                {
                    return View(loginVM);
                }

            }
            return View(loginVM);
        }

        
        [Authorize(Roles = "User")]
        public IActionResult AddToOrganization(int id)
        {


            Manken manken = _mankenService.FindManken(id);
            if (manken != null)
            {

                //Session
                Cart cartSession;

                //Serialize => Json
                if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "organizasyon") == null)
                {
                    cartSession = new Cart();
                }
                else
                {
                    cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "organizasyon");
                }



                CartItem cartItem = new CartItem();
                cartItem.Id = manken.Id;
                cartItem.MankenAdi = manken.Ad;
                cartItem.MankenSoyadi = manken.Soyad;
                cartItem.MankenBoyu = manken.Boy;
                cartItem.MankenKilosu = manken.Kilo;
                cartItem.Kategori = manken.Kategori;



                cartSession.AddItem(cartItem);
                SessionHelper.SetJsonProduct(HttpContext.Session, "organizasyon", cartSession);

            }

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "User")]
        public IActionResult MyOrganization()
        {
            if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "organizasyon") != null)
            {
                var sepet = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "organizasyon");
                return View(sepet);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        [Authorize(Roles = "User")]
        public async Task<IActionResult> CompleteOrganization(DateTime baslangic, DateTime bitis, string adres, string sehir)
        {
            Cart cart = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "organizasyon");

            if (User.Identity.IsAuthenticated)
            {
                Random rnd = new Random();

                Order order = new Order();
                var user = await _userManager.GetUserAsync(User);
                order.User = user;
                order.OrganizasyonNumarasi = DateTime.Now.Hour + "" + rnd.Next(0, 1000);
                order.BaslangicTarihi = baslangic;
                order.BitisTarihi = bitis;
                order.OrganizasyonAdresi = adres;
                order.OrganizasyonSehirAdresi = sehir;
                order.Onaylama = false;

                _orderService.CreateOrder(order);

                foreach (var item in cart._myCart)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    var manken = _mankenService.GetAllManken().Where(x => x.Id == item.Value.Id).FirstOrDefault();

                    orderDetail.Manken = manken;
                    orderDetail.Kategori = item.Value.Kategori;
                    orderDetail.Order = order;
                    _orderDetailService.CreateOrderDetail(orderDetail);

                }
                SessionHelper.RemoveSession(HttpContext.Session, "organizasyon");

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }


        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }
        [Authorize]
        public IActionResult Hakkimizda()
        {
            return View();
        }
        [Authorize]
        public IActionResult Organizasyonlar()
        {
            OrganizasyonGeliGiderVM organizasyonGeliGiderVM =new OrganizasyonGeliGiderVM();
            organizasyonGeliGiderVM.Organizasyonlar = _organizasyonService.GetAllOrganizasyon().ToList();
            organizasyonGeliGiderVM.Adresler=_adresService.GetAllAdres().ToList();
            return View(organizasyonGeliGiderVM);
        }
        [Authorize]
        public IActionResult Referanslar()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}