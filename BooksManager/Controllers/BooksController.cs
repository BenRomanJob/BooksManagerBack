using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?Linkid=397860

namespace BooksManager.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private BooksContext _context;

        public BooksController(BooksContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            IEnumerable<Book> books = _context.books.Where(book => book.isActive).ToList();
            return books;
        }

        [HttpPost]
        [Route("Update")]
        public IEnumerable<Book> UpdateBooks([FromBody] IEnumerable<Book> books)
        {
            _context.books.UpdateRange(books);
            _context.SaveChanges();
            return _context.books.Where(book => book.isActive).ToList();
        }

    }
}
