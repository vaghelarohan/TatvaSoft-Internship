using Microsoft.AspNetCore.Mvc;
using BookApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        // In-memory book list
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "The Hobbit", Author = "J.R.R. Tolkien" },
            new Book { Id = 2, Title = "1984", Author = "George Orwell" }
        };

        // GET: api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return books;
        }

        // GET: api/books/1
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();
            return book;
        }

        // POST: api/books
        [HttpPost]
        public ActionResult<Book> Post(Book book)
        {
            book.Id = books.Max(b => b.Id) + 1;
            books.Add(book);
            return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
        }

        // PUT: api/books/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            return NoContent();
        }

        // DELETE: api/books/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            books.Remove(book);
            return NoContent();
        }
    }
}
