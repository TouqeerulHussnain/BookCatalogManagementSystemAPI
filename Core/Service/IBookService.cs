using Microsoft.AspNetCore.Mvc;

namespace BookCatalogManagementSystemAPI.Core.Service
{
    public interface IBookService
    {
        public Task<IActionResult> Get();
        public Task<IActionResult> Update(Guid id);
        public Task<IActionResult> Delete();
        public Task<IActionResult> Create();
    }
}
