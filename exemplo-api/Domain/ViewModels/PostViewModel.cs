using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exemplo.Domain.ViewModels
{
    public class PostViewModel
    {
        [Key]
        public int PostId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int BlogId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Content { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCadastro { get; set; }
    }

}
