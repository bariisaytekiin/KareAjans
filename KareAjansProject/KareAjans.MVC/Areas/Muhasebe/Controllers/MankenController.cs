using KareAjans.BLL.AbstractService;
using KareAjans.BLL.Service;
using KareAjans.MVC.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf;
using System.Data;
using Syncfusion.Drawing;


namespace KareAjans.MVC.Areas.Muhasebe.Controllers
{
    [Authorize(Roles = "Muhasebe")]
    [Area("Muhasebe")]
    public class MankenController : Controller
    {
        private readonly IMankenService _mankenService;
        private readonly IFotografService _fotografService;
        private readonly IOrganizasyonService _organizasyonService;
        private readonly IOrganizasyonGiderService _organizasyonGiderService;

        public MankenController(IMankenService mankenService, IFotografService fotografService, IOrganizasyonService organizasyonService, IOrganizasyonGiderService organizasyonGiderService)
        {
            _mankenService = mankenService;
            _fotografService = fotografService;
            _organizasyonService = organizasyonService;
            _organizasyonGiderService = organizasyonGiderService;
        }
        public IActionResult Index()
        {
            MankenFotografVM mankenFotografVM = new MankenFotografVM();
            mankenFotografVM.Mankenler = _mankenService.GetAllManken().ToList();
            mankenFotografVM.Fotograflar = _fotografService.GetAllFotograf().ToList();

            return View(mankenFotografVM);
        }
        public IActionResult GetManken(int id)
        {
            OrganizasyonGeliGiderVM organizasyonGeliGiderVM = new OrganizasyonGeliGiderVM();
            organizasyonGeliGiderVM.Mankenler = _mankenService.GetAllManken().ToList();
            organizasyonGeliGiderVM.Organizasyonlar = _organizasyonService.GetAllOrganizasyon().ToList();
            organizasyonGeliGiderVM.OrganizasyonGiderleri = _organizasyonGiderService.GetAllOrganizasyonGider().ToList();

            ViewBag.Manken = _mankenService.FindManken(id);

            return View(organizasyonGeliGiderVM);
        }

        private IEnumerable<object> GetEmployeeDataFromDatabase(int id)
        {
            decimal? gider = 0;
            decimal? gelir = 0;
            List<object> mankenData = new List<object>();

            foreach (var organizasyonGider in _organizasyonGiderService.GetAllOrganizasyonGider())
            {
                var gunSayisi = (_organizasyonService.GetAllOrganizasyon().Where(x => x.Id == organizasyonGider.OrganizasyonId).Select(x => x.BitisTarihi).FirstOrDefault() - _organizasyonService.GetAllOrganizasyon().Where(x => x.Id == organizasyonGider.OrganizasyonId).Select(x => x.BaslangicTarihi).FirstOrDefault()).Days + 1;



                if (organizasyonGider.MankenId == id)
                {
                    gider = (organizasyonGider.GunlukUcret * gunSayisi) + (organizasyonGider.KonaklamaUcreti * gunSayisi) + (organizasyonGider.OgunUcreti * gunSayisi);

                    gelir = organizasyonGider.Butce;

                    mankenData.Add(new { OrganizasyonId = _organizasyonService.FindOrganizasyon(organizasyonGider.OrganizasyonId).Id, OrganizasyonAdi = _organizasyonService.FindOrganizasyon(organizasyonGider.OrganizasyonId).OrganizasyonAdi, OrganizasyonBaslangicTarihi = _organizasyonService.FindOrganizasyon(organizasyonGider.OrganizasyonId).BaslangicTarihi.ToString("dd/MM/yyyy"), OrganizasyonBitisTarihi = _organizasyonService.FindOrganizasyon(organizasyonGider.OrganizasyonId).BitisTarihi.ToString("dd/MM/yyyy"), OrganizasyonGelir = gelir, MankenGider = gider });
                }

            }

            return mankenData;
        }
        public IActionResult CreatePDFDocument(int id)
        {
            var manken = _mankenService.FindManken(id);
            decimal? gider = 0;
            decimal? ödeme = 0;
            foreach (var organizasyonGider in _organizasyonGiderService.GetAllOrganizasyonGider())
            {
                var gunSayisi = (_organizasyonService.GetAllOrganizasyon().Where(x => x.Id == organizasyonGider.OrganizasyonId).Select(x => x.BitisTarihi).FirstOrDefault() - _organizasyonService.GetAllOrganizasyon().Where(x => x.Id == organizasyonGider.OrganizasyonId).Select(x => x.BaslangicTarihi).FirstOrDefault()).Days + 1;
                if (organizasyonGider.MankenId == id)
                {
                    gider = (organizasyonGider.GunlukUcret * gunSayisi) + (organizasyonGider.KonaklamaUcreti * gunSayisi) + (organizasyonGider.OgunUcreti * gunSayisi);
                    ödeme += gider;
                }
            }
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();

            // Add title to the PDF page (center-aligned title)
            PdfFont titleFont = new PdfStandardFont(PdfFontFamily.Helvetica, 18, PdfFontStyle.Bold);
            PdfTextElement titleElement = new PdfTextElement("Manken Giderleri");
            titleElement.Font = titleFont;
            titleElement.StringFormat = new PdfStringFormat() { Alignment = PdfTextAlignment.Center };
            PdfLayoutResult titleLayoutResult = titleElement.Draw(page, new Syncfusion.Drawing.PointF(page.GetClientSize().Width / 2, 50));

            // Add text to the PDF page (additional text)
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
            PdfTextElement textElement = new PdfTextElement($"Manken ID: {manken.Id}\nManken Adı: {manken.Ad}\nManken Soyadı: {manken.Soyad}\nManken Kategorisi: {manken.Kategori}\nManken Telefon No: {manken.TelefonNo}\nManken Kayıt Tarihi: {manken.CreatedDate.ToString("dd/MM/yyyy")}");
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

            PdfTextElement additionalTextElement = new PdfTextElement($"Mankene Yapılna Toplam Ödeme: {ödeme} TL");
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
