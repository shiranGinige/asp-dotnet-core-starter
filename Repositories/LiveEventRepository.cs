using System.Collections.Generic;
using System.Linq;
using AspNetStarter.Models;
using AspNetStarter.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace AspNetStarter.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BlogPostRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<BlogPost>> ListAll()
        {
            return await _dbContext.BlogPosts.ToListAsync();
        }

        public async Task Add(BlogPost liveEvent)
        {
            _dbContext.BlogPosts.Add(liveEvent);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<BlogPost> Get(long blogposId)
        {
            return await _dbContext.BlogPosts.FirstOrDefaultAsync(a => a.Id == blogposId);

        }
    }
}