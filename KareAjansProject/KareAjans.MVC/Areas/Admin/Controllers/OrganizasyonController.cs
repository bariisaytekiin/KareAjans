using Kareajans.Common;
using Kareajans.MVC.Utils;
using KareAjans.BLL.AbstractService;
using KareAjans.BLL.Service;
using KareAjans.Entity.Entities;
using KareAjans.Entity.Enums;
using KareAjans.MVC.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KareAjans.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class OrganizasyonController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IMankenService _mankenService;
        private readonly IOrganizasyonService _organizasyonService;
        private readonly IOrganizasyonGelirService _organizasyonGelirService;
        private readonly IAdresService _adresService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IOrganizasyonGiderService _organizasyonGiderService;

        public OrganizasyonController(IOrderService orderService, IOrderDetailService orderDetailService,IMankenService mankenService,IOrganizasyonService organizasyonService,IOrganizasyonGiderService organizasyonGiderService,IOrganizasyonGelirService organizasyonGelirService,IAdresService adresService, UserManager<IdentityUser> userManager)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _mankenService = mankenService;
            _organizasyonService = organizasyonService;
            _organizasyonGelirService = organizasyonGelirService;
            _adresService = adresService;
            _userManager = userManager;
            _organizasyonGiderService = organizasyonGiderService;
            
        }
        public IActionResult Index()
        {

            return View(_orderService.GetAllOrders().ToList());
        }
        public IActionResult Details(int id)
        {
            var od=_orderDetailService.GetAllOrderDetails();
            List<OrderDetail> ordersDetail = new List<OrderDetail>();

            foreach (var item in od)
            {
                if (item.OrderId==id)
                {
                    ordersDetail.Add(item);
                }

            }

            OrderDetailMankenVM orderDetailMankenVM = new OrderDetailMankenVM();
            orderDetailMankenVM.OrderDetails = ordersDetail;
            orderDetailMankenVM.Mankenler=_mankenService.GetAllManken().ToList();
            orderDetailMankenVM.Orders=_orderService.GetAllOrders().ToList();

            return View(orderDetailMankenVM);
        }
        [HttpPost]
        public IActionResult Details(string adi,string adresacik,string adressehir,DateTime baslangic,DateTime bitis,decimal ogunucreti,decimal konaklamaucreti,decimal gunlukucret,decimal butce,int orderdetailsid)
        {
            _orderService.FindOrder(orderdetailsid).Onaylama = true;


            Adres adres = new Adres();
            adres.AcikAdres = adresacik;
            adres.Sehir = adressehir;
            
            _adresService.CreateAdres(adres);

            Organizasyon organizasyon = new Organizasyon();
            organizasyon.OrganizasyonAdi = adi;
            organizasyon.BaslangicTarihi = baslangic;
            organizasyon.BitisTarihi = bitis;
            organizasyon.AdresId = adres.Id;
            
            _organizasyonService.CreateOrganizasyon(organizasyon);

            OrganizasyonGelir organizasyonGelir = new OrganizasyonGelir();
            organizasyonGelir.Butce = butce;
            organizasyonGelir.OrganizasyonId = organizasyon.Id;
            _organizasyonGelirService.CreateOrganizasyonGelir(organizasyonGelir);

            var a=_orderDetailService.GetAllOrderDetails().Where(x=>x.OrderId==orderdetailsid).ToList();
            var ucuncuKategoriMankenSayisi = 0;
            foreach (var item in a)
            {
                switch (_mankenService.FindManken(item.MankenId).Kategori)
                {
                    case Entity.Enums.MankenKategori.Kategori1:

                        break;
                    case Entity.Enums.MankenKategori.Kategori2:

                        break;
                    case Entity.Enums.MankenKategori.Kategori3:
                        ucuncuKategoriMankenSayisi++;
                        break;

                }
            }

            foreach (var item in _orderDetailService.GetAllOrderDetails())
            {
                if(item.OrderId == orderdetailsid) 
                {
                    OrganizasyonGider organizasyonGider = new OrganizasyonGider();
                    organizasyonGider.OrganizasyonId = organizasyon.Id;
                    organizasyonGider.MankenId= item.MankenId;
                    organizasyonGider.Butce = butce;
                    organizasyonGider.OgunUcreti = 150;

                    if (konaklamaucreti!=0)
                    {
                        organizasyonGider.KonaklamaUcreti = 500;
                    }
                    switch (_mankenService.FindManken(item.MankenId).Kategori)
                    {
                        case Entity.Enums.MankenKategori.Kategori1:
                            organizasyonGider.GunlukUcret = 500;
                            break;
                        case Entity.Enums.MankenKategori.Kategori2:
                            organizasyonGider.GunlukUcret = 1000;
                            break;
                        case Entity.Enums.MankenKategori.Kategori3:
                            organizasyonGider.GunlukUcret = (butce *20)/100;
                            break;

                    }
                    organizasyonGider.KategoriUcMankenSayisi = ucuncuKategoriMankenSayisi;
                    _organizasyonGiderService.CreateOrganizasyonGider(organizasyonGider);

                }

                

            }

            return RedirectToAction("OrganizasyonIndex");
        }

        public IActionResult OrganizasyonIndex()
        {
            return View(_organizasyonService.GetAllOrganizasyon().ToList());
        }

        public IActionResult OrganizasyonDetails(int id)
        {

            var oGider = _organizasyonGiderService.GetAllOrganizasyonGider();
            List<OrganizasyonGider> organizasyonGider = new List<OrganizasyonGider>();

            foreach (var item in oGider)
            {
                if (item.OrganizasyonId == id)
                {
                    organizasyonGider.Add(item);
                }
            }
            OrganizasyonGeliGiderVM organizasyonGeliGiderVM = new OrganizasyonGeliGiderVM();
            organizasyonGeliGiderVM.OrganizasyonGiderleri = organizasyonGider;
            organizasyonGeliGiderVM.Organizasyonlar = _organizasyonService.GetAllOrganizasyon().ToList();
            organizasyonGeliGiderVM.Mankenler = _mankenService.GetAllDeletedManken().ToList();
            organizasyonGeliGiderVM.Adresler = _adresService.GetAllAdres().ToList();

            return View(organizasyonGeliGiderVM);

        }


        public IActionResult OrganizasyonOlustur(string firstName, string lastName, Cinsiyet? gender, AyakkabıNo? shoeSize, GozRengi? eyeColor, SacRengi? hairColor, Beden? bodySize, int age, byte weight, byte height, MankenKategori? professionalDegreeId, string foreignLanguage, bool? ehliyet, bool? sehirDisiCalisma,DateTime baslangic,DateTime bitis)
        {
            var organizasyon = _organizasyonService.GetAllOrganizasyon()
                        .Where(org =>
                            (org.BaslangicTarihi > bitis) ||
                            (org.BitisTarihi < baslangic))
                        .ToList();


            var organizasyonGiderleri = _organizasyonGiderService.GetAllOrganizasyonGider();
            List<Manken> mankenList = new List<Manken>();


            List<Manken> mankens = new List<Manken>();
          
            List<OrganizasyonGider> gider = new List<OrganizasyonGider>();
            mankenList = _mankenService.GetAllManken().ToList();
            
            var a = _mankenService.GetAllManken().ToList();
           

            foreach (var item in organizasyonGiderleri)
            {
                var oId = organizasyon.FirstOrDefault(x => x.Id == item.OrganizasyonId);

                if (oId == null)
                {
                    mankens.AddRange(_mankenService.GetAllManken().Where(x => x.Id == item.MankenId).ToList());
                 
                }

            }
            


            foreach (var manken in mankenList)
            {
                if (mankens.Where(x => x.Id == manken.Id).FirstOrDefault() != null)
                {
                    a.Remove(manken);
                }
            }
            mankenList = a;
            






           //var mankenList = _mankenService.GetAllManken();//to list eklendiğinde Ienumerable liste tipini liste çevirdiğimiz için diğer kriterlerde hata alıyoruz.

            if (!string.IsNullOrEmpty(firstName))
            {
                mankenList = mankenList.Where(x => x.Ad.Contains(firstName)).ToList();
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                mankenList = mankenList.Where(x => x.Soyad.Contains(lastName)).ToList();
            }
            if (gender != null)
            {
                mankenList = mankenList.Where(x => x.Cinsiyet == gender.Value).ToList();
            }
            if (shoeSize.HasValue)
            {
                mankenList = mankenList.Where(x => x.AyakkabıNo == shoeSize.Value).ToList();
            }
            if (eyeColor.HasValue)
            {
                mankenList = mankenList.Where(x => x.GozRengi == eyeColor.Value).ToList();
            }

            if (hairColor.HasValue)
            {
                mankenList = mankenList.Where(x => x.SacRengi == hairColor.Value).ToList();
            }

            if (bodySize.HasValue)
            {
                mankenList = mankenList.Where(x => x.Beden == bodySize.Value).ToList();
            }

            if (age != 0)
            {
                mankenList = mankenList.Where(x => (DateTime.Now.Year - x.DogumTarihi.Year) == age).ToList();
            }

            if (weight != 0)
            {
                mankenList = mankenList.Where(x => x.Kilo == weight).ToList();
            }

            if (height != 0)
            {
                mankenList = mankenList.Where(x => x.Boy == height).ToList();
            }

            if (!String.IsNullOrEmpty(foreignLanguage))
            {
                mankenList = mankenList.Where(x => x.YabanciDil.Contains(foreignLanguage)).ToList();
            }

            if (ehliyet != null)
            {
                mankenList = mankenList.Where(x => x.Ehliyet == ehliyet).ToList();
            }


            if (sehirDisiCalisma != null)
            {
                mankenList = mankenList.Where(x => x.SehirDisiCalisma == sehirDisiCalisma).ToList();
            }

            return View(mankenList);
        }

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

            return RedirectToAction("OrganizasyonOlustur");
        }

       
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

    }
}
