using fur_ever_homes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace fur_ever_homes.Pages.Account
{
    public class ViewRegisteredAdminModel : PageModel
    {
        public Dictionary<string, string>[] dataArray;

        [BindProperty]
        public PetCard PetCard { get; set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("AccountID") == null)
            {
                return new BadRequestResult();
            }

            PetCard = new PetCard();

            dataArray = Global.GetData($"display_pets.php?accountID=all&status=confirmed");

            return Page();
        }

        public IActionResult OnPost()
        {
            string uri = $"change_pet_status.php?petID={PetCard.PetID}&status=unconfirmed";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            dataArray = Global.GetData($"display_pets.php?accountID=all&status=confirmed");

            return Page();
        }
    }
}
