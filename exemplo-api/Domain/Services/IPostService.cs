using Exemplo.Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exemplo.Domain.Services
{
    public interface IPostService
    {
        Task<IEnumerable<PostViewModel>> ObterTodos();
    }
}
