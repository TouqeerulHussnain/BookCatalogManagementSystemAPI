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

        public Task<IActionResult> Create()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Update()
        {
            return repo.Update();
        }

        public Task<IActionResult> Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
