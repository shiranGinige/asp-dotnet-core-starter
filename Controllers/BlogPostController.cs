using System.Threading.Tasks;
using AspNetStarter.Services;
using Microsoft.AspNetCore.Mvc;
using AspNetStarter.Repositories;
using Microsoft.AspNetCore.Authorization;
using AspNetStarter.Models;

namespace AspNetStarter.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class BlogPostController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogPostController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("{blogpostId}")]
        public async Task<BlogPost> Get(long blogpostId)
        {
            return await _blogService.Get(blogpostId);
        }

        [HttpPost("create")]
        public async Task Create()
        {
            await _blogService.CreateNewPost(this.User.GetUserId() , "Doom!");
        }
     
    }


}
