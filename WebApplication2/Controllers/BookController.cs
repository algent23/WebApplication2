using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContex _db;

        public BookController(ApplicationDbContex db)
        {
            _db = db;
        }
        //[HttpGet]
        //public async Task <IActionResult> GetAll()
        //{
        //    return Json(new {data=_db.Book.ToListAsync()});
        //}
        ////[HttpDelete]
        ////public async Task< IActionResult> Delete(int id)
        ////{
        ////    var bookFromDb = _db.Book.FirstOrDefaultAsync(u=>u.Id==id);
        ////    if (bookFromDb==null)
        ////    {
        ////        return Json(new { success = false, message = "Error while Deleting" });
        ////    }
        ////    _db.Book.Remove(bookFromDb);
        ////    await _db.SaveChangesAsync();
        ////    return Json(new { success = true, message = "Delete successful" });

        ////}
    }
}
