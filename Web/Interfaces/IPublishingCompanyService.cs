using System.Collections.Generic;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Interfaces
{
    public interface IPublishingCompanyService
    {
        Task<List<PublishingComapnyViewModel>> ListAsync();
    }
}
