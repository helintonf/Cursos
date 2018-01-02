using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            Carro car2 = new Carro("Fiat", "Uno", 2010);

            Console.WriteLine(car.ToString());
            Console.WriteLine(car2.ToString());


            Console.ReadKey();
        }
    }
}
