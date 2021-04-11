using AutoMapper;
using Exemplo.Domain.Repository;
using Exemplo.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Domain.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BlogViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<BlogViewModel>>(await _blogRepository.ObterBlogs());
        }
    }
}
