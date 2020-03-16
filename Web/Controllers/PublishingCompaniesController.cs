using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.InputModels;
using Web.Interfaces;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishingCompaniesController : ControllerBase
    {
        private readonly IPublishingCompanyService service;

        public PublishingCompaniesController(IPublishingCompanyService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            return Ok(await service.ListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return Ok(await service.GetAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(PublishingCompanyInputModel publishingCompanyInputModel)
        {
            var result = await service.AddAsync(publishingCompanyInputModel);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, PublishingCompanyInputModel publishingCompanyInputModel)
        {
            if (await service.GetAsync(id) == null)
            {
                return NotFound();
            }

            await service.UpdateAsync(id, publishingCompanyInputModel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (await service.GetAsync(id) == null)
            {
                return NotFound();
            }

            await service.DeleteAsync(id);
            return NoContent();
        }
    }
}