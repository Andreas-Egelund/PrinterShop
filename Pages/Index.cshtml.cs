using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.Models;
using System.Net;

namespace PrinterShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Dictionary<string, Printer> ourPrinters = MockData.GetPrinters();




        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        



        public IActionResult OnPostSearchFun(string Critaria)
        {

            

        }
    }
}
