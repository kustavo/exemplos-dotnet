using AutoMapper;
using Exemplo.Domain.Entities;
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

        public async Task AdicionarBlog(BlogViewModel blogViewModel)
        {
            var produto = _mapper.Map<Blog>(blogViewModel);
            _blogRepository.Adicionar(produto);

            await _blogRepository.UnitOfWork.Commit();
        }
    }
}
