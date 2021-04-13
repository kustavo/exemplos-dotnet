using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Exemplo.Domain.Entities;
using Exemplo.Domain.ViewModels;

namespace Domain.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Post, PostViewModel>();

            CreateMap<Blog, BlogViewModel>();
        }
    }
}
