using System.Threading.Tasks;
using AspNetStarter.Services;
using Microsoft.AspNetCore.Mvc;
using AspNetStarter.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace AspNetStarter.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class StreamController : Controller
    {
        private readonly IStreamManagementService _streamManagementService;

        public StreamController(IStreamRepository streamRepo, IStreamManagementService streamManagementService)
        {
         
            _streamManagementService = streamManagementService;
        }

        [HttpGet("{streamId}")]
        public async Task<string> Get(string streamId)
        {
            var user = User.Identity;
            return await _streamManagementService.Get(streamId);
        }

        [HttpPost("create")]
        public async Task<string> Create()
        {
            return await _streamManagementService.Create(this.User.GetUserId());
        }


        [HttpPost("start/{streamId}")]
        public async Task<string> Start(string streamId)
        {
            return await _streamManagementService.Start(streamId);
        }

        [HttpPost("stop/{streamId}")]
        public async Task<string> Stop(string streamId)
        {
            return await _streamManagementService.Stop(streamId);
        }


        [HttpPost("delete/{streamId}")]
        public async Task<string> Delete(string streamId)
        {
            return await _streamManagementService.Delete(streamId);
        }

        [HttpGet("all")]
        public async Task<string> GetAll()
        {
            return await _streamManagementService.GetAll();
        }

    }


}
