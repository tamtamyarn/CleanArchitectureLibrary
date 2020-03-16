using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}