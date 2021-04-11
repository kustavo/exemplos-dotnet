using AutoMapper;
using Exemplo.Domain.Repository;
using Exemplo.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Domain.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<PostViewModel>>(await _postRepository.ObterPosts());
        }
    }
}
