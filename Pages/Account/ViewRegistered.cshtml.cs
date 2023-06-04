using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System;
using System.Diagnostics;
using System.Text.Json;

namespace fur_ever_homes.Pages.Account
{
    public class ViewRegisteredModel : PageModel
    {
        public Dictionary<string, string>[] dataArray;

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("AccountID") == null)
            {
                return new BadRequestResult();
            }
            dataArray = Global.GetData($"display_pets.php?accountID={HttpContext.Session.GetString("AccountID")}&status=confirmed");

            return Page();
        }
    }
}
