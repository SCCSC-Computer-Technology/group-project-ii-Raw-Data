using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RawDataWebapp.Models;
using System.Threading.Tasks;

namespace RawDataWebapp.Pages
{
    public class LoginModel : PageModel
    {
        public string Title { get; set; }

        private readonly UserService _userService;

        public LoginModel(UserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> OnPostLoginAsync()
        {
            // Redirect to the Index page upon clicking the login button
            return RedirectToPage("/Index2");
        }
    }
}
