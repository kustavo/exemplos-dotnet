using Exemplo.Domain.Services;
using Exemplo.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exemplo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;
        private readonly IPostService _postService;

        public PostController(ILogger<PostController> logger,
            IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        [HttpGet]
        public async Task<IEnumerable<PostViewModel>> Get()
        {
            return await _postService.ObterTodos();
        }
    }
}
