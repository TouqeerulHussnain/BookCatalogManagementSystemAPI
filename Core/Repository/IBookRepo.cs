using BookCatalogManagementSystemAPI.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalogManagementSystemAPI.Core.Repository
{
    public  interface IBookRepo
    {
        
        public Task Create(Book book);
        public Task<List<Book>> Get();
        public Task<IActionResult> Update();
        public Task Delete(Guid id);
    }
}
