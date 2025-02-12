using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.InterFace;
using PrinterShop.Models;
using PrinterShop.Services;
using System.Security.Cryptography.X509Certificates;

namespace PrinterShop.Pages
{
    public class ShoppingCartModel : PageModel
    {
        public PrinterService _printerservice;





        public ShoppingCartModel(PrinterService printerService)
        {
            _printerservice = printerService;
            Printers2d = _printerservice.Get2DPrinters().Values.ToList();
        }




        public User CurrentUser { get; set; }

        public List<IProduct> Printers2d { get; set; }

        public double Total { get; set; }


        public void OnGet()
        {


            var userEmail = HttpContext.Session.GetString("UserEmail") ?? "Guest";

            CurrentUser = _printerservice.GetUsers()[userEmail]; // Vi henter brugeren ud fra brugernavnet :)


            foreach (var item in CurrentUser.ShoppingCart)
            {
                Total += item.Price;
            }

        }
    }
}
