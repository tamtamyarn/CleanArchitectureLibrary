using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext context;

        public BookRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Book> AddAsync(Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();
            return book;
        }

        public async Task<Book> GetAsync(int id)
        {
            return await context.Books.Include(b => b.PublishingCompany).SingleOrDefaultAsync(b => b.PublishingCompany.PublishingCompanyId == id);
        }

        public async Task<List<Book>> ListAsync()
        {
            return await context.Books.Include(b => b.PublishingCompany).ToListAsync();
        }
    }
}
