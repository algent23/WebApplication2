using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
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
        [BindProperty]
public Book Book { get; set; }
        public void OnGet()
        {

        }
        public async  Task<IActionResult>OnPost()
        {
            if (ModelState.IsValid)
            {
              await  this.db.Book.AddAsync(Book);
                await this.db.SaveChangesAsync(); 
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
