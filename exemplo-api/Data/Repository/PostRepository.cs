using Exemplo.Domain.Entities;
using Exemplo.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Data.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly ExemploContext _context;

        public PostRepository(ExemploContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Post>> ObterPosts()
        {
            return await _context.Posts.AsNoTracking().ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
