using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Auth0RazorPages.Pages
{
    public class ProfileModel : PageModel
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Picture { get; set; }
        public void OnGet()
        {
            UserName = User.FindFirst(ClaimTypes.Name)?.Value;
            Email = User.FindFirst(ClaimTypes.Email)?.Value;
            Picture = User.FindFirst("picture")?.Value;
        }
    }
}
