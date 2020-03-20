using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppDbContext context;

        public AuthorRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Author> AddAsync(Author author)
        {
            context.Authors.Add(author);
            await context.SaveChangesAsync();
            return author;
        }

        public async Task DeleteAsync(Author author)
        {
            context.Remove(author);
            await context.SaveChangesAsync();
        }

        public async Task<Author> GetAsync(int id)
        {
            return await context.Authors
                //.AsNoTracking()
                .SingleOrDefaultAsync(a => a.AuthorId == id);
        }

        public async Task<List<Author>> ListAsync()
        {
            return await context.Authors.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(Author author)
        {
            context.Authors.Update(author);
            await context.SaveChangesAsync();
        }
    }
}
