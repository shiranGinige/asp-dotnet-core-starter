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
        Task CreateNewPost(string currentUserId,string title);
        Task<BlogPost> Get(long postId);

    }
}
