using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;

namespace PrinterShop.Pages
{
    public class ProductSearchPageModel : PageModel
    {

        public List<IProduct> AllProducts = new List<IProduct>();


        public ProductSearchPageModel()
        {
            AllProducts.AddRange(MockData.Get2DPrinters().Values);
            AllProducts.AddRange(MockData.Get3DPrinters().Values);
            AllProducts.AddRange(MockData.GetAccessories().Values);
        }



        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public List<IProduct> Results { get; set; }

        public void OnGet()
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                Results = AllProducts
                    .Where(p => p.Name.Contains(SearchTerm, System.StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
        }

    }
}
