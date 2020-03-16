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
    }
}