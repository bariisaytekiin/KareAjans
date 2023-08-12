using KareAjans.BLL.AbstractService;
using KareAjans.BLL.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KareAjans.MVC.Areas.Muhasebe.Controllers
{
    [Authorize(Roles = "Muhasebe")]
    [Area("Muhasebe")]
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IMankenService _mankenService;
        private readonly IOrganizasyonGelirService _organizasyonGelirService;
        private readonly IOrganizasyonGiderService _organizasyonGiderService;
        private readonly IOrganizasyonService _organizasyonService;

        public HomeController(IOrderService orderService, IOrderDetailService orderDetailService,IMankenService mankenService,IOrganizasyonGelirService organizasyonGelirService,IOrganizasyonGiderService organizasyonGiderService,IOrganizasyonService organizasyonService)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _mankenService = mankenService;
            _organizasyonGelirService = organizasyonGelirService;
            _organizasyonGiderService = organizasyonGiderService;
            _organizasyonService = organizasyonService;
        }
        public IActionResult Index()
        {
            ViewBag.Manken=_mankenService.GetAllManken().Count();//manken sayısı
            ViewBag.OrganizasyonToplamGelir = _organizasyonGelirService.GetAllOrganizasyonGelir().Sum(x => x.Butce);

            decimal toplamGider=0;

            foreach (var item in _organizasyonGiderService.GetAllOrganizasyonGider())
            {
                toplamGider += item.OgunUcreti * item.GunSayisi;
                toplamGider += item.KonaklamaUcreti * item.GunSayisi;
                if (_mankenService.GetAllManken().Where(x=>x.Id==item.MankenId).Select(x=>x.Kategori).FirstOrDefault() ==Entity.Enums.MankenKategori.Kategori3)
                {
                    toplamGider += item.GunlukUcret;
                }
                else
                {
                    toplamGider += item.GunlukUcret * item.GunSayisi;
                }

            }


            ViewBag.OrganizasyonToplamGider=toplamGider;
            ViewBag.ToplamOrganizasyon=_organizasyonService.GetAllOrganizasyon().Count();

            return View(_orderService.GetAllOrders().OrderByDescending(x => x.CreatedDate).ToList());
        }
    }
}
