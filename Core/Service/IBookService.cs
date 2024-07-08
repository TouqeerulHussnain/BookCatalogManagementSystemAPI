using BookCatalogManagementSystemAPI.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalogManagementSystemAPI.Core.Service
{
    public interface IBookService
    {
        public Task Create(Book book);
        public Task<List<Book>> Get();
        public Task UpdateBook(Book book);
        public Task Delete(Guid id);
    }
}
