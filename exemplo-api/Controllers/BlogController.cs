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
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;
        private readonly IBlogService _blogService;

        public BlogController(ILogger<BlogController> logger,
            IBlogService blogService)
        {
            _logger = logger;
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IEnumerable<BlogViewModel>> Get()
        {
            return await _blogService.ObterTodos();
        }

        [HttpPost]
        public async Task<IActionResult> NovoBlog(BlogViewModel blogViewModel)
        {
            await _blogService.AdicionarBlog(blogViewModel);
            return Ok(true);
        }

    }
}
