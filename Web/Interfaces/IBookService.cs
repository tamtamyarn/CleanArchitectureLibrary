using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.InputModels;
using Web.ViewModels;

namespace Web.Interfaces
{
    public interface IBookService
    {
        Task<BookViewModel> GetAsync(int id);
        Task<List<BookViewModel>> ListAsync();
        Task<BookViewModel> AddAsync(BookInputModel bookInputModel);
    }
}
