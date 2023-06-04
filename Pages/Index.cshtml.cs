using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System;
using System.Text.Json;
using System.Diagnostics;

namespace fur_ever_homes.Pages
{
    public class IndexModel : PageModel
    {
        public readonly JsonElement root;
        public readonly Dictionary<string, string>[] dataArray;
        public IndexModel()
        {
            string uri = "display_pets.php?accountID=all&status=confirmed";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Global.URI + uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string result = reader.ReadToEnd();
            dataArray = JsonSerializer.Deserialize<Dictionary<string, string>[]>(result);
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