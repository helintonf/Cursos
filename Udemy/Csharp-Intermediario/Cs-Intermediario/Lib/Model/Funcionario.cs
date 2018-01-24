using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Model
{
    public sealed class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public DateTime DtAdimissao { get; set; }

    }
}
