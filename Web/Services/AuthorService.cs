using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.InputModels;
using Web.Interfaces;
using Web.ViewModels;

namespace Web.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository repository;
        private readonly IMapper mapper;

        public AuthorService(IAuthorRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<AuthorViewModel> AddAsync(AuthorInputModel authorInputModel)
        {
            var author = mapper.Map<Author>(authorInputModel);
            var result = await repository.AddAsync(author);
            var authorViewModel = mapper.Map<AuthorViewModel>(result);
            return authorViewModel;
        }

        public async Task DeleteAsync(int id)
        {
            var author = await repository.GetAsync(id);
            await repository.DeleteAsync(author);
        }

        public async Task<AuthorViewModel> GetAsync(int id)
        {
            var author = await repository.GetAsync(id);
            var authorViewModel = mapper.Map<AuthorViewModel>(author);
            return authorViewModel;
        }

        public async Task<List<AuthorViewModel>> ListAsync()
        {
            var authors = await repository.ListAsync();
            var authorsViewModel = mapper.Map<List<AuthorViewModel>>(authors);
            return authorsViewModel;
        }

        public async Task UpdateAsync(int id, AuthorInputModel authorInputModel)
        {
            var author = mapper.Map<Author>(authorInputModel);
            author.AuthorId = id;
            await repository.UpdateAsync(author);
        }
    }
}
