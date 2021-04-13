using System;
using System.Collections.Generic;

namespace Exemplo.Domain.Entities
{
    public class Blog : IAggregateRoot
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public DateTime DataCadastro { get; private set; }
        public List<Post> Posts { get; set; }

        protected Blog()
        {

        }

        public Blog(string url, int rating, DateTime dataCadastro)
        {
            Url = url;
            Rating = rating;
            DataCadastro = dataCadastro;
        }
    }
}