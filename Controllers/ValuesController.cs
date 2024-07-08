using BookCatalogManagementSystemAPI.Core.Domain;
using BookCatalogManagementSystemAPI.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalogManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBookService service;

        public ValuesController(IBookService service)
        {
            this.service = service;
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Book book)
        {
            return Ok();
        }


        [HttpDelete("Delete")]

        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(Book book)
        {


            return Ok();
        }

        [HttpGet("Search")]
        public async Task<IActionResult> Search(string word)
        {

            return Ok();
        }
    }
}
