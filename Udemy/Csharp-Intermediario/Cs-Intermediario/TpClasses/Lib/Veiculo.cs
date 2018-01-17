using System;
using System.Collections.Generic;
using System.Text;

namespace TpClasses.Lib
{
    abstract class Veiculo
    {
        /// <summary>
        /// Propriedade abstrata
        /// </summary>
        abstract public string Marca { get; set; }
        abstract public string Modelo { get;}
        public int Ano { get; set; }

        /// <summary>
        /// não tem a implementação
        /// </summary>
        /// <param name="Numero"></param>
        abstract public void MudarMarcha(byte Numero);


    }
}
