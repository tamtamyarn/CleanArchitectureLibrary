using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class PublishingCompanyRepository : IPublishingCompanyRepository
    {
        private readonly AppDbContext context;

        public PublishingCompanyRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<PublishingCompany> AddAsync(PublishingCompany publishingCompany)
        {
            context.publishingCompanies.Add(publishingCompany);
            await context.SaveChangesAsync();
            return publishingCompany;
        }

        public async Task DeleteAsync(PublishingCompany publishingCompany)
        {
            context.publishingCompanies.Remove(publishingCompany);
            await context.SaveChangesAsync();
        }

        public async Task<PublishingCompany> GetAsync(int id)
        {
            return await context.publishingCompanies.FindAsync(id);
        }

        public async Task<List<PublishingCompany>> ListAsync()
        {
            return await context.publishingCompanies.ToListAsync();
        }

        public async Task UpdateAsync(PublishingCompany publishingCompany)
        {
            context.publishingCompanies.Update(publishingCompany);
            await context.SaveChangesAsync();
        }
    }
}
