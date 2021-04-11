using Exemplo.Data;
using Exemplo.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exemplo.Domain.Repository
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Task<IEnumerable<Blog>> ObterBlogs();
    }
}
