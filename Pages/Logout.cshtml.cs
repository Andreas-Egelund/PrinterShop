using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrinterShop.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnPost()
        {
            // Clear the session completely
            HttpContext.Session.Clear();

            // Set the user as "Guest"
            HttpContext.Session.SetString("UserName", "Guest");

            // Redirect to the home page or any other desired page
            return RedirectToPage("/Index");
        }
    }
}
