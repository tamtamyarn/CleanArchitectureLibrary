using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.InputModels;
using Web.ViewModels;

namespace Web.Interfaces
{
    public interface IAuthorService
    {
        Task<AuthorViewModel> GetAsync(int id);
        Task<List<AuthorViewModel>> ListAsync();
        Task<AuthorViewModel> AddAsync(AuthorInputModel authorInputModel);
        Task UpdateAsync(int id, AuthorInputModel authorInputModel);
        Task DeleteAsync(int id);
    }
}
