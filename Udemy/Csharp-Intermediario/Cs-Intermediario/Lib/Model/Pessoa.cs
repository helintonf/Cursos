using System;

namespace Lib.Model
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

        public DateTime DtNascimento { get; set; }
        public string Telefone { get; set; }

        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string  UF { get; set; }
        public string Endereco { get; set; }

    }
}
