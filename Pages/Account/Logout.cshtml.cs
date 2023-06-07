using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fur_ever_homes.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            HttpContext.Session.Clear();

            await Task.Delay(2);
            return RedirectToPage("../Index");
        }
    }
}
