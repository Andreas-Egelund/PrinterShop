using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrinterShop.Pages
{
    public class ProductSearchPageModel : PageModel
    {

        public List<string> AllProducts = new List<> 









        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public List<string> Results { get; set; }

        public void OnGet()
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                Results = Products
                    .Where(p => p.Contains(SearchTerm, System.StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
        }

    }
}
