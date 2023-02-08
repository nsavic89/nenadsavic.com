using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using nenadsavic.com.Models;
using nenadsavic.com.Data;
using System.Runtime.Serialization;

namespace nenadsavic.com.Pages
{
    public class ContactModel : PageModel
    {

        // Contact form input fields
        [BindProperty]
        public Contact Contact { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            // Make a database record for the received message
            using var db = new DataContext();
            db.Add(Contact);
            db.SaveChanges();
        }
    }
}
