using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Model;

namespace WebApplication2.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContex db;
        public CreateModel(ApplicationDbContex db)
        {
            this.db = db;
        }
public Book Book { get; set; }
        public void OnGet()
        {
        }
    }
}
