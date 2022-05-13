using Application1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Application1.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]

        public AddressModel Address { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            
            return RedirectToPage("/Index", new { Address.City});
        }
    }
}
