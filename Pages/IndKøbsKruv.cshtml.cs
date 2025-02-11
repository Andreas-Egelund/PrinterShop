using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;

namespace PrinterShop.Pages
{
    public class IndKøbsKruvModel : PageModel
    {
        public Dictionary<string, IProduct> IndKøbsKurv = new Dictionary<string, IProduct>();


        public void OnGet()
        {
            IndKøbsKurv = MockData.GetAccessories();

        }
    }

}
