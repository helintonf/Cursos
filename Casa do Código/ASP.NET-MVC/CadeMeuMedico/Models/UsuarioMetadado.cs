using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuarios
    {

    }

    class UsuarioMetadado
    {
        [Required(ErrorMessage ="Obrigatorio informar o Nome")]
        [StringLength(80,ErrorMessage ="o Nome deve possuir no maximo 80 caracteres")]
        public string Nome { set; get; }

        [Required(ErrorMessage = "Obrigatorio informar o Login")]
        [StringLength(30,ErrorMessage ="o Login deve possuir no maximo 30 caracteres")]
        public string Login { set; get; }

        [Required(ErrorMessage ="Obrigatorio informar a Senha")]
        [StringLength(100,ErrorMessage ="A Senha deve possuir no maximo 100 caracteres")]
        public string Senha { set; get; }

        [Required(ErrorMessage ="Obrigatorio informar o Email")]
        [StringLength(100,ErrorMessage ="O Email deve possuir no maximo 100 caracteres")]
        public string Email { set; get; }


    }
}
