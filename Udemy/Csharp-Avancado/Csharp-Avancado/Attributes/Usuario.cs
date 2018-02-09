using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Attributes
{
    class Usuario
    {
        [Required(ErrorMessage ="O campo 'Nome' é Obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Campo Obrigatorio")]
        [EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(10, MinimumLength = 6)]
        [MyValidator(ErrorMessage ="Senha deve possuir 5")]
        public string Senha { get; set; }

    }
}
