using AutoMapper;
using Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<List<PublishingComapnyViewModel>> ListAsync()
        {
            var publishingCompanies = await repository.ListAsync();
            var publishingCompaniesViewModel = mapper.Map<List<PublishingComapnyViewModel>>(publishingCompanies);
            return publishingCompaniesViewModel;
        }
    }
}
