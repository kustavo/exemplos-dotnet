using Exemplo.Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exemplo.Domain.Services
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogViewModel>> ObterTodos();
        Task AdicionarBlog(BlogViewModel blogViewModel);
    }
}
