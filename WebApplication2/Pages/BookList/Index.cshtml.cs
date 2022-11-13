using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Model;

namespace WebApplication2.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContex db;
        public IndexModel(ApplicationDbContex db)
        {
            this.db = db;
        }
        public IEnumerable <Book> Books { get; set; }
        public async Task OnGet()
        {
            Books=await this.db.Book.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = await this.db.Book.FindAsync(id);
        if (book == null)
            {
                return NotFound();
            }
            this.db.Book.Remove(book);
            await this.db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
