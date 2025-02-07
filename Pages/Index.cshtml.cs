using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;
using System.Net;

namespace PrinterShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<IProduct> Printers3D = MockData.Get3DPrinters().Values.ToList();




        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        

    }
}
