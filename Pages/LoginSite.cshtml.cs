using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.Models;
using PrinterShop.Services;

namespace PrinterShop.Pages
{
    public class LoginSiteModel : PageModel
    {

        public Dictionary<string, User> UserDict;

        public LoginSiteModel(PrinterService printerService)
        {
            UserDict = printerService.GetUsers();
        }


        public string ErrorMessage { get; set; }

        public void OnGet()
        {
            // Check if user is already logged in and redirect if necessary
            var userName = HttpContext.Session.GetString("UserName");
            if (!string.IsNullOrEmpty(userName) && userName != "Guest")
            {
                Response.Redirect("/Index");
            }
        }

        public IActionResult OnPostLogin(string email, string password)
        {
            // Simulate a simple user lookup
            var user = UserDict.Values.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                // Store the logged-in user in session
                HttpContext.Session.SetString("UserEmail", user.Email);
                HttpContext.Session.SetString("UserName", user.Name);
                return RedirectToPage("/Index");
            }
            else
            {
                // Set error message and stay on the login page
                ErrorMessage = "Invalid email or password.";
                return Page();
            }
        }

        public IActionResult OnPostLogout()
        {
            // Clear the session completely
            HttpContext.Session.Clear();

            // Set the user as "Guest"
            HttpContext.Session.SetString("UserName", "Guest");

            // Redirect to the home page or any other desired page
            return RedirectToPage("/Index");
        }


        public IActionResult OnPostCreateUser(string name, string email, string password)
        {
            // Check if user already exists
            if (UserDict.Values.Any(u => u.Email == email))
            {
                ErrorMessage = "User with this email already exists.";
                return Page();
            }

            // Create a new user
            var newUser = new User(name, email, password);


            // Add the user to the dictionary
            UserDict.Add(newUser.Email, newUser);

            // Store the logged-in user in session
            HttpContext.Session.SetString("UserEmail", newUser.Email);
            HttpContext.Session.SetString("UserName", newUser.Name);

            // Redirect to the home page or any other desired page
            return RedirectToPage("/Index");
        }





    }
}
