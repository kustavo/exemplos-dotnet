using System;

namespace Exemplo.Domain.Entities
{
    public class Post : IAggregateRoot
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public DateTime DataCadastro { get; private set; }
        public Blog Blog { get; set; }

        protected Post()
        {

        }

        public Post(int postId, string title, string content, int blogId, DateTime dataCadastro)
        {
            Title = title;
            Content = content;
            BlogId = blogId;
            DataCadastro = dataCadastro;
        }
    }
}