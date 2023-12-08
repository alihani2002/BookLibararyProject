using BookLibarary.Repos;
using Microsoft.AspNetCore.Mvc;

namespace BookLibarary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepos _bookRepos;
        public BookController(IBookRepos bookRepos) 
        {
         _bookRepos = bookRepos;
        }
        public IActionResult Index()
        {
            return View(_bookRepos.GetAll().ToList());
        }
        public IActionResult Details(int id) 
        {
            try
            {
                if (_bookRepos.GetAll().Count() == 0)
                    return NotFound();

                var book = _bookRepos.GetById(id);
                if (book is null)
                    return NotFound();

                return View(book);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
