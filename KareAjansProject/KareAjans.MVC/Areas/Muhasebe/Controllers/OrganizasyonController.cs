using KareAjans.BLL.AbstractService;
using KareAjans.BLL.Service;
using KareAjans.Entity.Entities;
using KareAjans.MVC.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Grid;


namespace KareAjans.MVC.Areas.Muhasebe.Controllers
{
    [Authorize(Roles = "Muhasebe")]
    [Area("Muhasebe")]
    public class OrganizasyonController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IMankenService _mankenService;
        private readonly IOrganizasyonService _organizasyonService;
        private readonly IOrganizasyonGiderService _organizasyonGiderService;
        private readonly IAdresService _adresService;

        public OrganizasyonController(IOrderService orderService, IOrderDetailService orderDetailService, IMankenService mankenService, IOrganizasyonService organizasyonService, IOrganizasyonGiderService organizasyonGiderService, IAdresService adresService)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _mankenService = mankenService;
            _organizasyonService = organizasyonService;
            _organizasyonGiderService = organizasyonGiderService;
            _adresService = adresService;
        }
        public IActionResult Index()
        {

            return View(_organizasyonService.GetAllOrganizasyon().ToList());
        }
        public IActionResult OrganizasyonGider()
        {
            return View();
        }
        public IActionResult OrganizasyonGelir()
        {
            return View();
        }
        public IActionResult Details(int id)
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
        private IEnumerable<object> GetEmployeeDataFromDatabase(int id)
        {
            
            List<object> organizasyonData = new List<object>();

            foreach (var organizasyonGider in _organizasyonGiderService.GetAllOrganizasyonGider())
            {
                var gunSayisi = (organizasyonGider.Organizasyon.BitisTarihi - organizasyonGider.Organizasyon.BaslangicTarihi).Days + 1;
                if (organizasyonGider.OrganizasyonId == id)
                {
                    if (_mankenService.GetAllManken().Where(x => x.Id == organizasyonGider.MankenId).Select(x => x.Kategori).FirstOrDefault() == KareAjans.Entity.Enums.MankenKategori.Kategori3)
                    {
                        organizasyonData.Add(new { Manken = _mankenService.FindManken(organizasyonGider.MankenId).Ad, Kategori = _mankenService.FindManken(organizasyonGider.MankenId).Kategori, YemekUcreti = organizasyonGider.OgunUcreti * gunSayisi, KonaklamaUCreti = organizasyonGider.KonaklamaUcreti * gunSayisi, GunlukUcret = organizasyonGider.GunlukUcret });
                    }
                    else
                    {
                        organizasyonData.Add(new { Manken = _mankenService.FindManken(organizasyonGider.MankenId).Ad, Kategori = _mankenService.FindManken(organizasyonGider.MankenId).Kategori, YemekUcreti = organizasyonGider.OgunUcreti * gunSayisi, KonaklamaUCreti = organizasyonGider.KonaklamaUcreti * gunSayisi, GunlukUcret = organizasyonGider.GunlukUcret * gunSayisi });
                    }

                }

            }

            return organizasyonData;
        }
        public IActionResult CreatePDFDocument(int id,decimal? gelir,decimal? gider)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();

            // Add title to the PDF page (center-aligned title)
            PdfFont titleFont = new PdfStandardFont(PdfFontFamily.Helvetica, 18, PdfFontStyle.Bold);
            PdfTextElement titleElement = new PdfTextElement("Organizasyon Giderleri");
            titleElement.Font = titleFont;
            titleElement.StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Center };
            PdfLayoutResult titleLayoutResult = titleElement.Draw(page, new Syncfusion.Drawing.PointF(page.GetClientSize().Width / 2, 50));

            // Add text to the PDF page (additional text)
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
            PdfTextElement textElement = new PdfTextElement($"Organizasyon ID:{_organizasyonService.FindOrganizasyon(id).Id} \nOrgnizasyon Adı:{_organizasyonService.FindOrganizasyon(id).OrganizasyonAdi}\nOrganizasyon Başlangic Tarihi:{_organizasyonService.FindOrganizasyon(id).BaslangicTarihi.ToString("dd/MM/yyyy")} \nOrganizasyon Bitis Tarihi:{_organizasyonService.FindOrganizasyon(id).BitisTarihi.ToString("dd/MM/yyyy")}\nOrganizasyon Sehri:{_adresService.GetAllAdres().Where(x => x.Id == _organizasyonService.GetAllOrganizasyon().Where(x => x.Id == id).Select(x => x.AdresId).FirstOrDefault()).Select(x => x.Sehir).FirstOrDefault()}\nOrganizasyon Adresi:{_adresService.GetAllAdres().Where(x => x.Id == _organizasyonService.GetAllOrganizasyon().Where(x => x.Id == id).Select(x => x.AdresId).FirstOrDefault()).Select(x => x.AcikAdres).FirstOrDefault()} ");
            textElement.Font = font;
            PdfLayoutResult textLayoutResult = textElement.Draw(page, new Syncfusion.Drawing.PointF(10, titleLayoutResult.Bounds.Bottom + 20));

            // Create a PdfGrid.
            PdfGrid pdfGrid = new PdfGrid();

            // Replace this part with your database query to get the data dynamically.
            var dataFromDatabase = GetEmployeeDataFromDatabase(id); // Replace this with your actual method to get data from the database

            // Assign data source.
            pdfGrid.DataSource = dataFromDatabase;

            // Draw grid to the page of PDF document.
            PdfLayoutResult gridLayoutResult = pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, textLayoutResult.Bounds.Bottom + 20));

            PdfTextElement additionalTextElement = new PdfTextElement($"Toplam Gelir: {gelir} TL\nToplam Gider: {gider} TL\nKÂR: {gelir - gider} TL");
            additionalTextElement.Font = font;

            // Calculate the width of the additional text.
            SizeF textSize = font.MeasureString(additionalTextElement.Text);
            float additionalTextWidth = textSize.Width;

            // Calculate the available space on the right side of the page.
            float availableSpace = page.GetClientSize().Width - additionalTextWidth - 10;

            // Adjust the text position if it exceeds available space.
            float textX = availableSpace >= 0 ? availableSpace : 10;
            float textY = gridLayoutResult.Bounds.Bottom + 20;

            // Draw the additional text on the page
            additionalTextElement.Draw(page, new Syncfusion.Drawing.PointF(textX, textY));

            // Write the PDF document to stream.
            MemoryStream stream = new MemoryStream();
            document.Save(stream);
            stream.Position = 0;
            document.Close(true);

            // Defining the ContentType for pdf file.
            string contentType = "application/pdf";

            // Define the file name.
            string fileName = "Output.pdf";

            // Return the PDF as a FileContentResult.
            return File(stream, contentType, fileName);

        }

    }
}
