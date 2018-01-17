using System;
using System.Collections.Generic;
using System.Text;

namespace Excecao
{
    class MinhaException : Exception
    {
        string erro;

        public MinhaException(string v) : base("Minha Exception: " + v)
        {

        }
    }
}
