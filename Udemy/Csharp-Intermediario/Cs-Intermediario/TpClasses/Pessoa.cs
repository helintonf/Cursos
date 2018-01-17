using System;
using System.Collections.Generic;
using System.Text;

namespace TpClasses
{
    class Pessoa
    {
        public EstadoCivil EstadoCivil { get; set; }

        void GetOlhos()
        {
            new Olho();
        }

        /// <summary>
        /// Classe Interna
        /// Somente acessivel na classe pessoa
        /// </summary>
        public class Olho
        {
            public static string Iris = "xyz";
            public Olho()
            {
                Pessoa pessoa = new Pessoa();
            }
        }
    }
}
