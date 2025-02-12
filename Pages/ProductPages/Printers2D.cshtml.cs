using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;
using PrinterShop.Services;

namespace PrinterShop.Pages.ProductPages
{
    public class Printers2DModel : PageModel
    {

        public List<IProduct> Printers2D;

        private readonly PrinterService _printerservice;

        public Printers2DModel(PrinterService printerService)
        {
            Printers2D = printerService.Get2DPrinters().Values.ToList();
            _printerservice = printerService;
        }

        public User CurrentUser { get; set; }

        public void OnPostAddToCart(string selectedProductId)
        {


            var userEmail = HttpContext.Session.GetString("UserEmail") ?? "Guest";

            CurrentUser = _printerservice.GetUsers()[userEmail]; // Vi henter brugeren ud fra brugernavnet :)




            var product = Printers2D.FirstOrDefault(p => p.ProductId == selectedProductId);
            if (product != null)
            {
                CurrentUser.ShoppingCart.Add(product);
            }
        }





        public void OnGet()
        {
        }
    }
}
