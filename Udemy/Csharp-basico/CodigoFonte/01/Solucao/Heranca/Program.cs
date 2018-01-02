using Heranca.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            Moto mot = new Moto();
            Veiculo veiculo = new Veiculo();

            car.Mover();
            mot.Mover();
            veiculo.Mover();

            Console.ReadKey();

        }
    }
}
