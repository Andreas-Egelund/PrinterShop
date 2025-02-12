using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.InterFace;
using PrinterShop.Models;
using PrinterShop.Services;

namespace PrinterShop.Pages
{
    public class CheckOutModel : PageModel
    {
        private readonly PrinterService _printerservice;


        public CheckOutModel(PrinterService printerService)
        {
            _printerservice = printerService;
        }


        public User CurrentUser { get; set; }


        public double Total { get; set; }

        public void OnGet()
        {
            var userEmail = HttpContext.Session.GetString("UserEmail") ?? "Guest";

            CurrentUser = _printerservice.GetUsers()[userEmail]; // Vi henter brugeren ud fra brugernavnet :)


            foreach (var item in CurrentUser.ShoppingCart)
            {
                Total += item.Price;
            }

        }


        public IActionResult OnPostSubmitPayment()
        {

            var userEmail = HttpContext.Session.GetString("UserEmail") ?? "Guest";

            var users = _printerservice.GetUsers();
            if (!users.ContainsKey(userEmail))
            {
                // Handle user not found.
                return RedirectToPage("/Error");
            }

            CurrentUser = users[userEmail];

            var reciept = new Reciept
            {
                AllItems = new List<IProduct>(CurrentUser.ShoppingCart)  // Deep copy of the shopping cart.
            };

            CurrentUser.Receipts.Add(reciept);

            CurrentUser.ShoppingCart.Clear();  // This won't affect the items in reciept.AllItems anymore.

            return RedirectToPage("/Index");



        }


    }
}
