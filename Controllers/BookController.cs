using BookCatalogManagementSystemAPI.Core.Domain;
using BookCatalogManagementSystemAPI.Core.Repository;
using BookCatalogManagementSystemAPI.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookCatalogManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookCatalogDbContext context;

        public BookController( BookCatalogDbContext context
            )
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> books()
        {
            var books = await context.Books.ToListAsync();
            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> books(Book book) {
            //Book testBook = new Book { Id =Guid.NewGuid(), AuthorName="Hamza", ISBN="isbn",Pages=60,PublicationYear=DateTime.Now, Genre="drama",Tags = [
            //    new Tag{Name="Best Selling" }
            //    ],
            //Chapters = [
            //    new Chapter{
            //        Title="Mr Chips",
            //        PageCount=5,
            //    }
            //    ]
            //};

            var books = context.Books;
            await books.AddAsync(book);
            await context.SaveChangesAsync();

            return Ok(books);
        }


        [HttpDelete]

        public async Task<IActionResult> Delete(Guid id)
        {
            var books = context.Books;
            var book = books.Where(book => book.Id == id)
                .FirstOrDefault();
            if (book != null)
            {
                context.Books.Remove(book);
            }
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Book book)
        {


            return Ok();
        }

        [HttpGet("Search")]
        public async Task<IActionResult> Search(string word)
        {

            var result = await context.Books.Where(element => element.AuthorName.Contains(word) || element.ISBN.Contains(word) || element.Title.Contains(word)).ToListAsync();

            return Ok(result);
        }
    }
}
