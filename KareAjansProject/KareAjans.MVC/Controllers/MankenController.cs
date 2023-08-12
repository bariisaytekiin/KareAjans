using KareAjans.BLL.AbstractService;
using KareAjans.BLL.Service;
using KareAjans.Entity.Enums;
using KareAjans.MVC.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KareAjans.MVC.Controllers
{
    public class MankenController : Controller
    {
        private readonly IMankenService _mankenService;
        private readonly IFotografService _fotografService;

        public MankenController(IMankenService mankenService,IFotografService fotografService)
        {
            _mankenService = mankenService;
            _fotografService = fotografService;
        }
        [Authorize]
        public IActionResult Index(int? yas,Cinsiyet? cinsiyet )
        {
            MankenFotografVM mankenFotografVM = new MankenFotografVM();
            if (yas !=null)
            {
                mankenFotografVM.Mankenler = _mankenService.GetAllManken().Where(x=>x.DogumTarihi.Year>=2005).ToList();
            }
            if (cinsiyet == KareAjans.Entity.Enums.Cinsiyet.Erkek)
            {
                mankenFotografVM.Mankenler = _mankenService.GetAllManken().Where(x => x.Cinsiyet== KareAjans.Entity.Enums.Cinsiyet.Erkek).ToList();
            }
            if (cinsiyet == KareAjans.Entity.Enums.Cinsiyet.Kadın)
            {
                mankenFotografVM.Mankenler = _mankenService.GetAllManken().Where(x => x.Cinsiyet == KareAjans.Entity.Enums.Cinsiyet.Kadın).ToList();
            }
            if(yas==null && cinsiyet==null)
            {
                mankenFotografVM.Mankenler = _mankenService.GetAllManken().ToList();
            }

            mankenFotografVM.Fotograflar = _fotografService.GetAllFotograf().ToList();

            return View(mankenFotografVM);
        }
        [Authorize]
        public IActionResult Details(int id)
        {
            MankenFotografVM mankenFotografVM = new MankenFotografVM();
            mankenFotografVM.Mankenler = _mankenService.GetAllManken().ToList();
            mankenFotografVM.Fotograflar = _fotografService.GetAllFotograf().ToList();
            ViewBag.Manken = _mankenService.FindManken(id);

            return View(mankenFotografVM);
            
        }
    }
}
