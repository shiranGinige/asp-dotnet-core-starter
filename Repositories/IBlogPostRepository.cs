using System.Collections.Generic;
using AspNetStarter.Models;
using System.Threading.Tasks;

namespace AspNetStarter.Repositories
{
    public interface IBlogPostRepository
    {
        Task<IEnumerable<BlogPost>> ListAll();
        Task Add(BlogPost blogPost);
        Task<BlogPost> Get(long blogPostId);

    }
}