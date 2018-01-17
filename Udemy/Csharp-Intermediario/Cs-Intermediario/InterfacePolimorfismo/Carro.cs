using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePolimorfismo
{
    class Carro : ITransporte
    {
        public void Andar()
        {
            Console.WriteLine("Carro andando");
        }
    }
}
