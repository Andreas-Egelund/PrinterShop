using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Models;
using PrinterShop.Services;

namespace PrinterShop.Pages
{
    public class UserInfoPageModel : PageModel
    {

        private readonly PrinterService _printerservice;



        public UserInfoPageModel(PrinterService printerService)
        {
            _printerservice = printerService;
        }


        public User CurrentUser { get; set; }


        public void OnGet()
        {

            var userEmail = HttpContext.Session.GetString("UserEmail") ?? "Guest";

            CurrentUser = _printerservice.GetUsers()[userEmail]; // Vi henter brugeren ud fra brugernavnet :)





        }
    }
}
