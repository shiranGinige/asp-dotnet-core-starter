using System;
using System.Threading.Tasks;
using AspNetStarter.Data;
using System.Net.Http;
using Microsoft.Extensions.Options;
using AspNetStarter.Shared;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AspNetStarter.Repositories;
using AspNetStarter.Models;

namespace AspNetStarter.Services
{
    public class BlogService : IBlogService
    {
        private readonly IGenericRepository<BlogPost> _blogPostRepository;
        private readonly SomeConfig _someConfig;
        public BlogService(IGenericRepository<BlogPost> blogpostRepository, IOptions<SomeConfig> settings)
        {
            _someConfig = settings.Value;
            _blogPostRepository = blogpostRepository;
        }

        public async Task<BlogPost> Get(long blogPostId)
        {
            throw new NotImplementedException();
        }

        public async Task CreateNewPost(string currentUserId, string title)
        {
            throw new NotImplementedException();
        }


    }

}