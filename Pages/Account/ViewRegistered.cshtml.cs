using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Text.Json;

namespace fur_ever_homes.Pages.Account
{
    public class ViewRegisteredModel : PageModel
    {
        public readonly Dictionary<string, string>[] dataArray;

        public ViewRegisteredModel()
        {
            dataArray = Global.GetData($"display_pets.php?accountID={HttpContext.Session.GetString("AccountID")}&status=confirmed");
        }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("AccountID") == null)
            {
                return new BadRequestResult();
            }
            return Page();
        }
    }
}
