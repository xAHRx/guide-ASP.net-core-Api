using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Books.Data.Services;
using My_Books.Data.ViewsModels;

namespace My_Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPost]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }
    }
}
