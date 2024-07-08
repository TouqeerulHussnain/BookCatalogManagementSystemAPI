using BookCatalogManagementSystemAPI.Core.Domain;
using BookCatalogManagementSystemAPI.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalogManagementSystemAPI.Core.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepo repo;

        public BookService(IBookRepo repo)
        {
            this.repo = repo;
        }

        public Task Create(Book book)
        {
          return  repo.Create(book);
        }

        public Task Delete(Guid id)
        {
            return repo.Delete(id);
        }

        public Task<List<Book>> Get()
        {
            return repo.Get();
        }

        

        public Task UpdateBook(Book book)
        {
            return repo.UpdateBook(book);
        }
    }
}
