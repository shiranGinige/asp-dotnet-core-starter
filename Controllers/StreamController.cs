using System.Threading.Tasks;
using AspNetStarter.Services;
using Microsoft.AspNetCore.Mvc;
using AspNetStarter.Repositories;
using Microsoft.AspNetCore.Authorization;

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
        public async Task<BlogPost> Get(string blogpostId)
        {
            return await _blogService.Get(blogpostId);
        }

        [HttpPost("create")]
        public async Task<string> Create()
        {
            return await _blogService.Create(this.User.GetUserId() , "Doom!");
        }
     
    }


}
