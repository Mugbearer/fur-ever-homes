using fur_ever_homes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Metrics;
using System.Net;
using System.Text.Json;

namespace fur_ever_homes.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LogIn LogIn { get; set; } = default!;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string uri = $"log_in.php?username={LogIn.Username}&password={LogIn.Password}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = Global.ResponseIntoString(response);

            if (responseString == "Username does not exist")
            {
                ModelState.AddModelError("LogIn.Username", responseString);
            }
            else if (responseString == "Invalid password")
            {
                ModelState.AddModelError("LogIn.Password", responseString);
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }

            request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var result = reader.ReadToEnd();
            using JsonDocument doc = JsonDocument.Parse(result);
            JsonElement root = doc.RootElement;


            HttpContext.Session.SetString("AccountID", root.GetProperty("account_id").ToString());
            HttpContext.Session.SetString("IsAdmin", root.GetProperty("is_admin").ToString());
            return RedirectToPage("Index");
        }
    }
}
