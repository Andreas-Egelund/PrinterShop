using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;

namespace PrinterShop.Pages.ProductPages
{
    public class AccessoriesModel : PageModel
    {

        public List<IProduct> Accessories = MockData.GetAccessories().Values.ToList();



    }
}
