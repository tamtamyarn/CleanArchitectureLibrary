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
            context.PublishingCompanies.Add(publishingCompany);
            await context.SaveChangesAsync();
            return publishingCompany;
        }

        public async Task DeleteAsync(PublishingCompany publishingCompany)
        {
            context.PublishingCompanies.Remove(publishingCompany);
            await context.SaveChangesAsync();
        }

        public async Task<PublishingCompany> GetAsync(int id)
        {
            return await context.PublishingCompanies.AsNoTracking().SingleOrDefaultAsync(p => p.PublishingCompanyId == id);
        }

        public async Task<List<PublishingCompany>> ListAsync()
        {
            return await context.PublishingCompanies.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(PublishingCompany publishingCompany)
        {
            context.PublishingCompanies.Update(publishingCompany);
            await context.SaveChangesAsync();
        }
    }
}
