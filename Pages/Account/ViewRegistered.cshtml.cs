using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace fur_ever_homes.Pages.Account
{
    public class ViewRegisteredModel : PageModel
    {
        private readonly JsonElement root;

        public ViewRegisteredModel()
        {
            root = Global.GetData("display_pets.php?accountID=all&status=confirmed");
        }

        public void OnGet()
        {
        }
    }
}
