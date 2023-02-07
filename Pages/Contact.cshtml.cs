using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace nenadsavic.com.Pages
{
    public class ContactModel : PageModel
    {

        // Contact form input fields
        [BindProperty]
        public string? Subject { get; set; }

        [BindProperty]
        public string? Email { get; set; }

        [BindProperty]
        public string? Message { get; set; }


        public void OnGet()
        {
        }


        public void OnPost()
        {
            // Make a database record for the received message
        }
    }
}
