using System.Collections.Generic;
using System.Threading.Tasks;
using Web.InputModels;
using Web.ViewModels;

namespace Web.Interfaces
{
    public interface IPublishingCompanyService
    {
        Task<List<PublishingComapnyViewModel>> ListAsync();
        Task<PublishingComapnyViewModel> GetAsync(int id);
        Task<PublishingComapnyViewModel> AddAsync(PublishingCompanyInputModel publishingCompanyInputModel);
        Task UpdateAsync(int id, PublishingCompanyInputModel publishingCompanyInputModel);
        Task DeleteAsync(int id);
    }
}
