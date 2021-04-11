using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exemplo.Domain.ViewModels
{
    public class BlogViewModel
    {
        [Key]
        public int BlogId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Url { get; set; }

        [Range(1, 5, ErrorMessage = "O campo {0} precisa ter o valor entre {1} e {2}")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public List<PostViewModel> Posts { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCadastro { get; set; }
    }
}
