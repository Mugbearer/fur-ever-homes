using fur_ever_homes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace fur_ever_homes.Pages.Account
{
    public class ViewUnregisteredAdminModel : PageModel
    {
        public Dictionary<string, string>[] dataArray;

        [BindProperty]
        public PetCard PetCard { get; set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("AccountID") == null || HttpContext.Session.GetString("IsAdmin") == null)
            {
                return new BadRequestResult();
            }

            dataArray = Global.GetData($"display_pets.php?accountID=all&status=unconfirmed");

            return Page();
        }

        public IActionResult OnPost()
        {
            string uri = $"change_pet_status.php?petID={PetCard.PetID}&status=confirmed";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            return Page();
        }
    }
}
