using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System;
using System.Text.Json;

namespace fur_ever_homes.Pages
{
    public class IndexModel : PageModel
    {
        private readonly JsonElement root;
        public IndexModel()
        {
            root = Global.GetData("display_pets.php?accountID=all&status=confirmed");
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