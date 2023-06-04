using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System;
using System.Text.Json;
using System.Diagnostics;

namespace fur_ever_homes.Pages
{
    public class IndexModel : PageModel
    {
        public readonly Dictionary<string, string>[] dataArray;

        public IndexModel()
        {
            dataArray = Global.GetData("display_pets.php?accountID=all&status=confirmed");
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return Page();
        }
    }
}