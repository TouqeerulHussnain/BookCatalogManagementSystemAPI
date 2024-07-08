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
            return repo.Create();
        }

        public Task<IActionResult> Delete()
        {
            return repo.Delete();
        }

        public Task<IActionResult> Get()
        {
            return repo.Get();
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
