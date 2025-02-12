using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;
using PrinterShop.Services;

namespace PrinterShop.Pages.ProductPages
{
    public class Printers3DModel : PageModel
    {

        public List<IProduct> Printers3D;

        private readonly PrinterService _printerservice;


        public Printers3DModel(PrinterService printerService)
        {
            Printers3D = printerService.Get3DPrinters().Values.ToList();
            _printerservice = printerService;

        }
        public User CurrentUser { get; set; }


        public void OnPostAddToCart(string selectedProductId)
        {


            var userEmail = HttpContext.Session.GetString("UserEmail") ?? "Guest";

            CurrentUser = _printerservice.GetUsers()[userEmail]; // Vi henter brugeren ud fra brugernavnet :)




            var product = Printers3D.FirstOrDefault(p => p.ProductId == selectedProductId);
            if (product != null)
            {
                CurrentUser.ShoppingCart.Add(product);
            }
        }



        public IActionResult OnPostTilProductSide(string id)
        {
            Printers3D = MockData.Get3DPrinters().Values.ToList();
            var printer = Printers3D.Find(p => p.ProductId == id);

            if (printer != null)
            {
                ProductSiteModel.AddingProducts(printer);
            }

            return RedirectToPage("/ProductSite");
        }



        public void OnGet()
        {
        }
    }
}
