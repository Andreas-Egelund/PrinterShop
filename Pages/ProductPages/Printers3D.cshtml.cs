using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.Models;

namespace PrinterShop.Pages.ProductPages
{
    public class Printers3DModel : PageModel
    {

        public Dictionary<string, Printer> Printers3D { get; set; }




        public void OnGet()
        {
        }
    }
}
