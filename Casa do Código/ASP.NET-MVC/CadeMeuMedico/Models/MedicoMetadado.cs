using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(MedicoMetadado))]
    public partial class Medicos
    {

    }

    public class MedicoMetadado
    {
        [Required(ErrorMessage="Obrigatório informar CRM")]
        [StringLength(30,ErrorMessage ="O CRM deve possuir no máximo 30 caracteres")]
        public string CRM { get; set; }

        [Required(ErrorMessage="Obrigatorio informar o Nome")]
        [StringLength(80,ErrorMessage ="O Nome deve possuir no maximo 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar o Endereço")]
        [StringLength(100,ErrorMessage ="O Endereco deve possuir no maximo 100 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage ="Obrigadorio informar o Bairro")]
        [StringLength(60,ErrorMessage ="o Bairro deve possuir no maximo 60 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar o E-mail")]
        [StringLength(100,ErrorMessage ="O E-mail deve possuir no maximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar se Atende por Convenio")]
        public bool AtendePorConvenio { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar se Tem Clinica")]
        public bool TemClinica { get; set; }

        [StringLength(80,ErrorMessage ="O WebSite deve possuir no maximo 80 caracteres")]
        public string WebsiteBlog { set; get; }

        [Required(ErrorMessage ="Obrigatorio informar Cidade")]
        public int IDCidade { set; get; }

        [Required(ErrorMessage ="Obrigatorio informar a Especialidade")]
        public int IDEspecialidade { get; set; }


    }
}