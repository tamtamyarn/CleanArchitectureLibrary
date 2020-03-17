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
            //var publishingComapny = mapper.Map<PublishingCompany>(publishingCompanyInputModel);
            //var result = await repository.AddAsync(publishingComapny);
            //var publishingCompanyViewModel = mapper.Map<PublishingComapnyViewModel>(result);
            //return publishingCompanyViewModel;

            var author = mapper.Map<Author>(authorInputModel);
            var result = await repository.AddAsync(author);
            var authorViewModel = mapper.Map<AuthorViewModel>(result);
            return authorViewModel;
        }

        public Task<AuthorViewModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuthorViewModel>> ListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
