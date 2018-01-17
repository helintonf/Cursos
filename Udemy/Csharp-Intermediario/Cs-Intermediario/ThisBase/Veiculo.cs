using System;
using System.Collections.Generic;
using System.Text;

namespace ThisBase
{
    class Veiculo
    {

        public virtual void Andar()
        {
            Console.WriteLine("Veiculo Andando");
        }

        public Veiculo()
        {
            Console.WriteLine("Construindo Veiculo");
        }

        public Veiculo(int i)
        {
            Console.WriteLine("Construindo Veiculo N: " + i);
        }
    }
}
