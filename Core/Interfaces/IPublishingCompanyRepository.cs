using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPublishingCompanyRepository
    {
        Task<PublishingCompany> GetAsync(int id);
        Task<List<PublishingCompany>> ListAsync();
        Task<PublishingCompany> AddAsync(PublishingCompany publishingCompany);
        Task UpdateAsync(PublishingCompany publishingCompany);
        Task DeleteAsync(PublishingCompany publishingCompany);
    }
}
