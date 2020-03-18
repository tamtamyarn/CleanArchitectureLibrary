using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.InputModels;
using Web.Interfaces;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService service;

        public AuthorsController(IAuthorService service)
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
        public async Task<IActionResult> AddAsync(AuthorInputModel authorInputModel)
        {
            var result = await service.AddAsync(authorInputModel);
            return Ok(result);
        }
    }
}