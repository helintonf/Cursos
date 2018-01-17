using System;
using System.Collections.Generic;
using System.Text;

namespace TpClasses
{
    partial class Parcial
    {
        void Par()
        {
            nome = "sst";
        }

        /// <summary>
        /// implementação
        /// </summary>
        /// <param name="velocidade"></param>
        partial void Correr(int velocidade)
        {
            throw new NotImplementedException();
        }
    }
}
