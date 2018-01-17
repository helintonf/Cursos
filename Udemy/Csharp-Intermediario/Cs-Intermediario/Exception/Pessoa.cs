using System;
using System.Collections.Generic;
using System.Text;

namespace Excecao
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        private string CEP;

        public void SetCEP(string value)
        {
            //int.Parse(value);
            if(int.TryParse(value,out int result))
            {
                CEP = value;
            }
            else
            {
                throw new MinhaException("CEP Inválido");
            }
        }

    }
}
