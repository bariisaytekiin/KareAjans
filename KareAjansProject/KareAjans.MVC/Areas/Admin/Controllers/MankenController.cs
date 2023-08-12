using KareAjans.BLL.AbstractService;
using KareAjans.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using KareAjans.Common;
using Microsoft.AspNetCore.Hosting;
using KareAjans.MVC.Models.ViewModel;
using KareAjans.Entity.Enums;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using System.Net;


namespace KareAjans.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class MankenController : Controller
    {
        private readonly IMankenService _mankenService;
        private readonly IFotografService _fotografService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IYorumService _yorumService;

        public MankenController(IMankenService mankenService, IFotografService fotografService, IWebHostEnvironment webHostEnvironment, IYorumService yorumService)
        {
            _mankenService = mankenService;
            _fotografService = fotografService;
            _webHostEnvironment = webHostEnvironment;
            _yorumService = yorumService;
        }
        public IActionResult Index()
        {
            MankenFotografVM mankenFotografVM = new MankenFotografVM();
            mankenFotografVM.Mankenler = _mankenService.GetAllManken().ToList();
            mankenFotografVM.Fotograflar = _fotografService.GetAllFotograf().ToList();

            return View(mankenFotografVM); //Tolist vermediğimiz için hata verdi.Genel tipi verdi.
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Manken manken, IEnumerable<IFormFile> mankenImage)
        {

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
            return RedirectToAction("Index", "Manken");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _mankenService.FindManken(id);

            _mankenService.DeleteManken(deleted);
            return RedirectToAction("Index", "Manken");
        }

        public IActionResult Update(int id)
        {
            var uptated = _mankenService.GetAllManken().Where(x => x.Id == id).FirstOrDefault();
            return View(uptated);
        }
        [HttpPost]
        public IActionResult Update(Manken manken)
        {
            _mankenService.UpdateManken(manken);
            return RedirectToAction("Index", "Admin");
        }

        public IActionResult GetManken(int id)
        {
            MankenFotografVM mankenFotografVM = new MankenFotografVM();
            mankenFotografVM.Mankenler = _mankenService.GetAllManken().ToList();
            mankenFotografVM.Fotograflar = _fotografService.GetAllFotograf().ToList();
            ViewBag.Manken = _mankenService.FindManken(id);
            ViewBag.Yorumlar = _yorumService.GetAllYorum().ToList();
            return View(mankenFotografVM);
        }


        public IActionResult Search(string firstName, string lastName, Cinsiyet? gender, AyakkabıNo? shoeSize, GozRengi? eyeColor, SacRengi? hairColor, Beden? bodySize, int age, byte weight, byte height, MankenKategori? professionalDegreeId, string foreignLanguage, bool? ehliyet, bool? sehirDisiCalisma)
        {
            var mankenler = _mankenService.GetAllManken();//to list eklendiğinde Ienumerable liste tipini liste çevirdiğimiz için diğer kriterlerde hata alıyoruz.

            if (!string.IsNullOrEmpty(firstName))
            {
                mankenler = mankenler.Where(x => x.Ad.Contains(firstName));
            }

            if (!string.IsNullOrEmpty(lastName))
            {
                mankenler = mankenler.Where(x => x.Soyad.Contains(lastName));
            }
            if (gender != null)
            {
                mankenler = mankenler.Where(x => x.Cinsiyet == gender.Value);
            }
            if (shoeSize.HasValue)
            {
                mankenler = mankenler.Where(x => x.AyakkabıNo == shoeSize.Value);
            }
            if (eyeColor.HasValue)
            {
                mankenler = mankenler.Where(x => x.GozRengi == eyeColor.Value);
            }

            if (hairColor.HasValue)
            {
                mankenler = mankenler.Where(x => x.SacRengi == hairColor.Value);
            }

            if (bodySize.HasValue)
            {
                mankenler = mankenler.Where(x => x.Beden == bodySize.Value);
            }

            if (age != 0)
            {
                mankenler = mankenler.Where(x => (DateTime.Now.Year - x.DogumTarihi.Year) == age);
            }

            if (weight != 0)
            {
                mankenler = mankenler.Where(x => x.Kilo == weight);
            }

            if (height != 0)
            {
                mankenler = mankenler.Where(x => x.Boy == height);
            }

            if (!String.IsNullOrEmpty(foreignLanguage))
            {
                mankenler = mankenler.Where(x => x.YabanciDil.Contains(foreignLanguage));
            }

            if (ehliyet != null)
            {
                mankenler = mankenler.Where(x => x.Ehliyet == ehliyet);
            }


            if (sehirDisiCalisma != null)
            {
                mankenler = mankenler.Where(x => x.SehirDisiCalisma == sehirDisiCalisma);
            }

            return View(mankenler.ToList());
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
            return RedirectToAction("Index", "Manken");

        }

        public IActionResult DeleteImages(string imageUrls)
        {
            var fotograf = _fotografService.GetAllFotograf().Where(x => x.Url == imageUrls).FirstOrDefault();
            var result = _fotografService.DeleteFotograf(fotograf);

            return RedirectToAction("Index", "Manken");
        }

        public IActionResult YorumEkle(string comment, int id)
        {
            Yorum yorum = new Yorum();
            yorum.Mesaj = comment;
            yorum.MankenId = id;

            _yorumService.CreateYorum(yorum);

            return RedirectToAction("Index", "Manken");
        }
        public IActionResult YorumSil(int id)
        {
            var yorum = _yorumService.GetAllYorum().Where(x => x.Id == id).FirstOrDefault();


            _yorumService.DeleteYorum(yorum);

            return RedirectToAction("Index", "Manken");
        }


        private List<string> GetImageUrlsForManken(int mankenId)
        {
            var manken = _mankenService.FindManken(mankenId);

            List<string> result = new List<string>();

            foreach (var item in _fotografService.GetAllFotograf())
            {
                if (item.MankenId == mankenId)
                {
                    result.Add(item.Url);
                }
            }
            return result;
        }

        public IActionResult CreatePDFDocument(int id)
        {

            var manken = _mankenService.FindManken(id);

            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.Pages.Add();
            PdfGraphics graphics = page.Graphics;

            // Page Title
            PdfFont titleFont = new PdfStandardFont(PdfFontFamily.Helvetica, 18, PdfFontStyle.Bold);
            PdfTextElement titleElement = new PdfTextElement("Organizasyon Giderleri");
            titleElement.Font = titleFont;
            titleElement.StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Center };
            PdfLayoutResult titleLayoutResult = titleElement.Draw(page, new Syncfusion.Drawing.PointF(page.GetClientSize().Width / 2, 50));

            string imageFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/manken");
            var imageUrls = GetImageUrlsForManken(id);

            float xPosition = 10; // Initial X position for the images
            float yPosition = titleLayoutResult.Bounds.Bottom + 20; // Initial Y position for the images

            foreach (var imageUrl in imageUrls)
            {
                string imagePath = Path.Combine(imageFolderPath, imageUrl);
                FileStream imageStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                PdfBitmap image = new PdfBitmap(imageStream);

                if (xPosition + 200 > page.GetClientSize().Width) // Check if the image exceeds the page width
                {
                    // Move to the next row
                    xPosition = 10;
                    yPosition += 120;
                }

                // Draw the image on the page
                graphics.DrawImage(image, new Syncfusion.Drawing.RectangleF(xPosition, yPosition, 200, 100));

                xPosition += 220; // Increase X position for the next image
            }

            // Move to the next row for text
            xPosition = 10;
            yPosition += 120;

            // Additional Text
            string additionalText = $"Ad= {manken.Ad}\nSoyadı={manken.Soyad}\nCinsiyet={manken.Cinsiyet}\nDoğum Tarihi={manken.DogumTarihi.ToString("dd/MM/yyyy")}\nBoy={manken.Boy}\nKilo={manken.Kilo}\nBeden={manken.Beden}\nSaç Rengi={manken.SacRengi}\nGöz Rengi={manken.GozRengi}\nEhliyet={manken.Ehliyet}\nŞehir Dışı Çalışma={manken.SehirDisiCalisma}\nTelefon No={manken.TelefonNo}\nEmail={manken.Email}";
            PdfTextElement additionalTextElement = new PdfTextElement(additionalText);
            additionalTextElement.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);

            float additionalTextYPosition = yPosition + 20; // Y position for the additional text
            PdfLayoutResult additionalTextLayoutResult = additionalTextElement.Draw(page, new Syncfusion.Drawing.PointF(10, additionalTextYPosition));

            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            stream.Position = 0;
            doc.Close(true);

            string contentType = "application/pdf";
            string fileName = "Output.pdf";

            return File(stream, contentType, fileName);
        }
    }
}

