using BookCatalogManagementSystemAPI.Core.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookCatalogManagementSystemAPI.Core.Repository
{
    public class BookRepo : IBookRepo
    {
        private readonly BookCatalogDbContext context;

        public BookRepo(BookCatalogDbContext context)
        {
            this.context = context;
        }
        public async Task Create(Book book)
        {
            var books = context.Books;
            await books.AddAsync(book);
            await context.SaveChangesAsync();
        }

        

        public async Task Delete(Guid id)
        {
            var books = context.Books;
            var book = books.Where(book => book.Id == id)
                .FirstOrDefault();
            if (book != null)
            {
                context.Books.Remove(book);
            }
            await context.SaveChangesAsync();
        }

        public async Task<List<Book>> Get()
        {
            var books = await context.Books.ToListAsync();
            return books;
        }

        public async Task UpdateBook(Book book)
        {
           var updatedBook = context.Books.Where(element=>element.Id == book.Id).FirstOrDefault();
            if (updatedBook != null) { 
                updatedBook.Id = book.Id;
                updatedBook.Title = book.Title;
                updatedBook.AuthorName = book.AuthorName;
                updatedBook.PublicationYear = book.PublicationYear;
                updatedBook.Genre = book.Genre;
                updatedBook.ISBN = book.ISBN;
                updatedBook.Tags = book.Tags;
                updatedBook.Chapters = book.Chapters;
                updatedBook.Pages = book.Pages;

                context.Books.Update(updatedBook);
            }
             await context.SaveChangesAsync();
            
        }
    }
}
