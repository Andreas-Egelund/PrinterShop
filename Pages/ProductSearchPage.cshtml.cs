using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;
using PrinterShop.Services;

namespace PrinterShop.Pages
{
    public class ProductSearchPageModel : PageModel
    {

        public List<IProduct> AllProducts = new List<IProduct>();

        private readonly PrinterService _printerservice;



        public ProductSearchPageModel(PrinterService printerService)
        {
            AllProducts.AddRange(printerService.Get2DPrinters().Values);
            AllProducts.AddRange(printerService.Get3DPrinters().Values);
            AllProducts.AddRange(printerService.GetAccessories().Values);
            _printerservice = printerService;
        }



        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public List<IProduct> Results { get; set; }



        public User CurrentUser { get; set; }


        public void OnGet()
        {



            if (!string.IsNullOrEmpty(SearchTerm))
            {
                
                Results = AllProducts
                .Where(p => p.Name.Contains(SearchTerm, System.StringComparison.OrdinalIgnoreCase) ||
                            p.Description.Contains(SearchTerm, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
            }



        }


        public void OnPostAddToCart(string selectedProductId)
        {


            var userEmail = HttpContext.Session.GetString("UserEmail") ?? "Guest";

            CurrentUser = _printerservice.GetUsers()[userEmail]; // Vi henter brugeren ud fra brugernavnet :)




            var product = AllProducts.FirstOrDefault(p => p.ProductId == selectedProductId);
            if (product != null)
            {
                CurrentUser.ShoppingCart.Add(product);
            }
        }



    }
}
