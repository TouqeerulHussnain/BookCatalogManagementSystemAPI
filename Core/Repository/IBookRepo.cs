using BookCatalogManagementSystemAPI.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalogManagementSystemAPI.Core.Repository
{
    public  interface IBookRepo
    {
        
        public Task Create(Book book);
        public Task<List<Book>> Get();
        public Task UpdateBook(Book book);
        public Task Delete(Guid id);
    }
}
