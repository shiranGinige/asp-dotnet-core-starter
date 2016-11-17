using System;
using System.Threading.Tasks;
using AspNetStarter.Data;
using System.Net.Http;
using Microsoft.Extensions.Options;
using AspNetStarter.Shared;
using AspNetStarter.Shared.Wowza;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AspNetStarter.Repositories;

namespace AspNetStarter.Services
{
    public class BlogService : IBlogService
    {

        private readonly IBlogPostRepository _blogPostRepository;
        private readonly SomeConfig _someConfig;
        public BlogService(IBlogPostRepository blogpostRepository, IOptions<SomeConfig> settings)
        {
            // _context = context;
            _someConfig = settings.Value;
            _blogPostRepository = blogpostRepository;

          
        }

        public async Task<string> Create(string currentUserId)
        {
         throw new NotImplementedException();

        }


        public async Task<BlogPost> Get(string streamId)
        {
            throw new NotImplementedException();
        }



    }

}