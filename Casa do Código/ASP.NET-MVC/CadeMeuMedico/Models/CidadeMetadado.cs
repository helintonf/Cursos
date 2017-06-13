using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(CidadeMetadado))]
    public partial class Cidades
    {

    }

    public class CidadeMetadado
    {
        [Required(ErrorMessage ="Obrigatorio informar o Nome")]
        [StringLength(100,ErrorMessage ="O Nome deve possuir no maximo 100 caracteres")]
        public string Nome { set; get; }


    }
}