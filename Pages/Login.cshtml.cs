using fur_ever_homes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fur_ever_homes.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LogIn LogIn { get; set; } = default!;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || LogIn == null)
            {
                return Page();
            }

            HttpContext.Session.SetString("LogInState", "true");
            return RedirectToPage("Index");
        }
    }
}
