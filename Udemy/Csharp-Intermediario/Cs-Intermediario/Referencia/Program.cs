using Biblioteca;
using System;

namespace Referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CalculoJuros calculo = new CalculoJuros();

            double result = calculo.Soma(10.5, 23.9);

            Console.WriteLine("Resultado soma: "+result);

            Console.ReadKey();
        }
    }
}
