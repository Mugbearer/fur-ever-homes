using fur_ever_homes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace fur_ever_homes.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public SignUp SignUp { get; set; } = default!;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || SignUp == null)
            {
                return Page();
            }
            
            string uri = $"sign_up.php?username={SignUp.Username}&password={SignUp.Password}&firstName={SignUp.FirstName}" +
                $"&lastName={SignUp.LastName}&emailAddress={SignUp.EmailAddress}&contactNum={SignUp.ContactNumber}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GlobalSettings.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = GlobalSettings.ResponseIntoString(response);

            if (responseString.Contains("Email is already taken"))
            {
                ModelState.AddModelError("SignUp.EmailAddress", "Email is already taken");
            }
            if (responseString.Contains("Username is already taken"))
            {
                ModelState.AddModelError("SignUp.Username", "Username is already taken");
            }
            if (!ModelState.IsValid || SignUp == null)
            {
                return Page();
            }

            return RedirectToPage("Index");
        }
    }
}
