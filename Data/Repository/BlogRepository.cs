using Exemplo.Domain.Entities;
using Exemplo.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Data.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ExemploContext _context;

        public BlogRepository(ExemploContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Blog>> ObterBlogs()
        {
            return await _context.Blogs.AsNoTracking().ToListAsync();
        }
 
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
