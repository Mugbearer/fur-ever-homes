using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System;
using System.Diagnostics;
using System.Text.Json;
using fur_ever_homes.Models;

namespace fur_ever_homes.Pages.Account
{
    public class ViewRegisteredModel : PageModel
    {
        public Dictionary<string, string>[] dataArray;

        [BindProperty]
        public PetCard PetCard { get; set; } = default!;

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("AccountID") == null)
            {
                return new BadRequestResult();
            }
            dataArray = Global.GetData($"display_pets.php?accountID={HttpContext.Session.GetString("AccountID")}&status=confirmed");

            return Page();
        }

        public IActionResult OnPost()
        {
            string uri = $"change_pet_status.php?petID={PetCard.PetID}&status=unconfirmed";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();


            dataArray = Global.GetData($"display_pets.php?accountID={HttpContext.Session.GetString("AccountID")}&status=confirmed");

            return Page();
        }
    }
}
