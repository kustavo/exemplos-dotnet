using AutoMapper;
using Exemplo.Domain.Entities;
using Exemplo.Domain.ViewModels;

namespace Domain.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<BlogViewModel, Blog>()
                .ConstructUsing(p => new Blog(p.Url, p.Rating, p.DataCadastro));

            CreateMap<PostViewModel, Post>()
                .ConstructUsing(c => new Post(c.PostId, c.Title, c.Content, c.BlogId, c.DataCadastro));
        }
    }
}


