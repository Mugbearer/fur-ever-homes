using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System;
using System.Text.Json;
using System.Diagnostics;
using fur_ever_homes.Models;

namespace fur_ever_homes.Pages
{
    public class IndexModel : PageModel
    {
        public readonly Dictionary<string, string>[] dataArray;

        [BindProperty]
        public PetCard PetCard { get; set; }

        public IndexModel()
        {
            dataArray = Global.GetData("display_pets.php?accountID=all&status=confirmed");
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (HttpContext.Session.GetString("AccountID") == null)
            {
                return RedirectToPage("LogIn");
            }
            
            string uri = $"request_adoption.php?petID={PetCard.PetID}&accountID={HttpContext.Session.GetString("AccountID")}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            return Page();
        }
    }
}