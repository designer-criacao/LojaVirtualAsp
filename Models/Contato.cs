using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Loja.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "O campo Nome deve ser preenchido")]
        [MinLength(3, ErrorMessage = "O Nome precisa ter no mínimo 3 letras")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email deve ser preenchido")]
        [EmailAddress(ErrorMessage = "O seu Email precisa ser válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Texto deve ser preenchido")]
        [MinLength(10, ErrorMessage = "O Texto precisa ter no mínimo 10 letras")]
        [MaxLength(1000, ErrorMessage = "O Texto precisa ter no máximo 1.000 letras")]
        public string Texto { get; set; }
    }
}