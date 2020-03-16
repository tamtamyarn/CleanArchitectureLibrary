using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.InputModels;
using Web.Interfaces;
using Web.ViewModels;

namespace Web.Services
{
    public class PublishingCompanyService : IPublishingCompanyService
    {
        private readonly IPublishingCompanyRepository repository;
        private readonly IMapper mapper;

        public PublishingCompanyService(IPublishingCompanyRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<PublishingComapnyViewModel> AddAsync(PublishingCompanyInputModel publishingCompanyInputModel)
        {
            var publishingComapny = mapper.Map<PublishingCompany>(publishingCompanyInputModel);
            var hoge = await repository.AddAsync(publishingComapny);
            var publishingCompanyViewModel = mapper.Map<PublishingComapnyViewModel>(hoge);
            return publishingCompanyViewModel;
        }

        public async Task DeleteAsync(int id)
        {
            var publicshingCompany = await repository.GetAsync(id);
            await repository.DeleteAsync(publicshingCompany);
        }

        public async Task<PublishingComapnyViewModel> GetAsync(int id)
        {
            var publishingCompany = await repository.GetAsync(id);
            var publishingCompanyViewModel = mapper.Map<PublishingComapnyViewModel>(publishingCompany);
            return publishingCompanyViewModel;
        }

        public async Task<List<PublishingComapnyViewModel>> ListAsync()
        {
            var publishingCompanies = await repository.ListAsync();
            var publishingCompaniesViewModel = mapper.Map<List<PublishingComapnyViewModel>>(publishingCompanies);
            return publishingCompaniesViewModel;
        }

        public async Task UpdateAsync(int id, PublishingCompanyInputModel publishingCompanyInputModel)
        {
            var publishingComapny = mapper.Map<PublishingCompany>(publishingCompanyInputModel);
            publishingComapny.PublishingCompanyId = id;
            await repository.UpdateAsync(publishingComapny);
        }
    }
}
