using fur_ever_homes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Text.Json;

namespace fur_ever_homes.Pages.Account
{
    public class RegisterPetModel : PageModel
    {
        [BindProperty]
        public RegisterPet RegisterPet { get; set; } = default!;

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("AccountID") == null)
            {
                return new BadRequestResult();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string uri = $"register_pet.php?accountID={HttpContext.Session.GetString("AccountID")}&name={RegisterPet.Name}&" +
                $"sex={RegisterPet.Sex}&birthdate={RegisterPet.Birthdate}&breed={RegisterPet.Breed}&" +
                $"imageURL{RegisterPet.ImageURL}&description={RegisterPet.Description}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);

            return RedirectToPage("Index");
        }
    }
}
