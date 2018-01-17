using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.RH
{
   public class Pessoa
    {
        //readOnly somente leitura
        public readonly char Sexo;  // == public char Sexo {get; private set;}

        //TODO AutoImplementProperty customizado
        private string _nome; //propriedade protegida.
        public string Nome {
            get {
                return _nome;
            }
            set {
                _nome = value;
            }
        }

        //AutoImplementProperty mesclado
        public string CPF { get; private set; }

        public void SetCPF(string cpf)
        {
            //validações
            CPF = cpf;
        }

        //AutoImplementProperty
        public string Endereco { get; set; }

        //Encapsulamento comum
        private string CEP;
        public void SetCEP(string nome)
        {
            Nome = nome;
            Sexo = 'd'; 
        }

        public string GetCEP()
        {
            return Nome;
        }
    }
}
