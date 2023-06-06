using fur_ever_homes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace fur_ever_homes.Pages.Account
{
    public class ViewUnregisteredModel : PageModel
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

            dataArray = Global.GetData($"display_pets.php?accountID={HttpContext.Session.GetString("AccountID")}&status=unconfirmed");

            return Page();
        }

        public IActionResult OnPost()
        {
            string uri = "delete_pet.php?petID=" + PetCard.PetID;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            dataArray = Global.GetData($"display_pets.php?accountID={HttpContext.Session.GetString("AccountID")}&status=unconfirmed");

            return Page();
        }
    }
}
