using first.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace first.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : Controller
    {
        
     
        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            return Json(new {data= _db.Book.ToList()});
        }
    }
}
