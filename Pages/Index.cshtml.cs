using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;
using PrinterShop.Services;
using System.Net;

namespace PrinterShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        public Dictionary<string,IProduct> Printers3D;




        public IndexModel(ILogger<IndexModel> logger, PrinterService printerService)
        {
            _logger = logger;
            Printers3D = printerService.Get3DPrinters();
        }



        public string UserName { get; set; }


        public void OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName") ?? "Guest";
        }


    }
}
