using Exemplo.Data;
using Exemplo.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exemplo.Domain.Repository
{
    public interface IPostRepository : IRepository<Post>
    {

        Task<IEnumerable<Post>> ObterPosts();
    }
}
