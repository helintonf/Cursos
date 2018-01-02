using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //contruir em qualquer tipo de dado. - [] na frente do tipo de dado
            string[] nomes = { "Helinton", "Josy", "Helielton", "Claudio", "Graça", "Terezinha" };

            nomes[0] = "Teste teste";

            Console.Write("Nome de Numero 3: " + nomes[0]);
            Console.ReadKey();

        }
    }
}
