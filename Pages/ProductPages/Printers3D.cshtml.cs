using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;

namespace PrinterShop.Pages.ProductPages
{
    public class Printers3DModel : PageModel
    {

        public List<IProduct> Printers3D = MockData.Get3DPrinters().Values.ToList();




        public void OnGet()
        {
        }
    }
}
