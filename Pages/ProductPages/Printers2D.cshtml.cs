using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;

namespace PrinterShop.Pages.ProductPages
{
    public class Printers2DModel : PageModel
    {

        public List<IProduct> Printers2D = MockData.Get2DPrinters().Values.ToList();




        public void OnGet()
        {
        }
    }
}
