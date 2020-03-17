using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<Author> GetAsync(int id)
        {
            return await context.Authors.FindAsync(id);
        }

        public async Task<List<Author>> ListAsync()
        {
            return await context.Authors.ToListAsync();
        }
    }
}
