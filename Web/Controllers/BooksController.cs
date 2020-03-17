using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.InputModels;
using Web.Interfaces;

namespace Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService service;

        public BooksController(IBookService service)
        {
            this.service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return Ok(await service.GetAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            return Ok(await service.ListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(BookInputModel bookInputModel)
        {
            return Ok(await service.AddAsync(bookInputModel));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, BookInputModel bookInputModel)
        {
            await service.UpdateAsync(id, bookInputModel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await service.DeleteAsync(id);
            return NoContent();
        }
    }
}