using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBookRepository
    {
        Task<Book> GetAsync(int id);
        Task<List<Book>> ListAsync();
        Task<Book> AddAsync(Book book);
    }
}
