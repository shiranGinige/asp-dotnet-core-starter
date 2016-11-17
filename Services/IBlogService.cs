using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AspNetStarter.Models;

namespace AspNetStarter.Services
{
    public interface IBlogService
    {
        Task<string> CreateNewPost(string currentUserId,string name);
        Task<BlogPost> Get(string postId);

    }
}
