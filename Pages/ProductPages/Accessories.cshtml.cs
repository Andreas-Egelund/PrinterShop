using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;
using PrinterShop.Services;

namespace PrinterShop.Pages.ProductPages
{
    public class AccessoriesModel : PageModel
    {
        public List<IProduct> Accessories;

        private readonly PrinterService _printerservice;

        public AccessoriesModel(PrinterService printerService)
        {
            Accessories = printerService.GetAccessories().Values.ToList();
            _printerservice = printerService;
        }


        public User CurrentUser { get; set; }

        public void OnPostAddToCart(string selectedProductId)
        {


            var userEmail = HttpContext.Session.GetString("UserEmail") ?? "Guest";

            CurrentUser = _printerservice.GetUsers()[userEmail]; // Vi henter brugeren ud fra brugernavnet :)




            var product = Accessories.FirstOrDefault(p => p.ProductId == selectedProductId);
            if (product != null)
            {
                CurrentUser.ShoppingCart.Add(product);
            }
        }





        void onGet()
        {

        }




    }
}
