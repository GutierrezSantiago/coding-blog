using Microsoft.EntityFrameworkCore;
using PeerToPeer.API.Data;
using PeerToPeer.API.Models.Domain;
using PeerToPeer.API.Repositories.Interface;

namespace PeerToPeer.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
