using Exemplo.Data;
using Exemplo.Data.Repository;
using Exemplo.Domain.Repository;
using Exemplo.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Exemplo
{
    public static class DependencyInjection
    {

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ExemploContext>();

            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IBlogRepository, BlogRepository>();

            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IPostRepository, PostRepository>();
        }
        
    }
}
