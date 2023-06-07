using fur_ever_homes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace fur_ever_homes.Pages.Account
{
    public class ViewAdoptionRequestsModel : PageModel
    {
        public Dictionary<string, string>[] adoptionArray;

        [BindProperty]
        public PetCard PetCard { get; set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("AccountID") == null)
            {
                return new BadRequestResult();
            }

            PetCard = new PetCard();

            adoptionArray = Global.GetData($"display_adoptions.php?accountID={HttpContext.Session.GetString("AccountID")}");

            return Page();
        }

        public IActionResult OnPost()
        {
            string uri = $"change_adoption_status.php?petID={PetCard.PetID}&status=approved";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            adoptionArray = Global.GetData($"display_adoptions.php?accountID={HttpContext.Session.GetString("AccountID")}");

            return Page();
        }
    }
}
