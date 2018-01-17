using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePolimorfismo
{
    class Moto : ITransporte
    {
        public void Andar()
        {
            Console.WriteLine("Moto andando");
        }
    }
}
