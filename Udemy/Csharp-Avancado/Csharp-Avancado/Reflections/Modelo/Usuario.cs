using System;
using System.Collections.Generic;
using System.Text;

namespace Reflections.Modelo
{
    public class Usuario : ICloneable
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public object Clone()
        {
            return new Usuario() { Nome = this.Nome, Email = this.Email, Senha = this.Senha };
        }
    }
}
