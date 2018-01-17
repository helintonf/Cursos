using Biblioteca.RH;
using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pessoa pessoa = new Pessoa();

            pessoa.Sexo = 'M';

            Console.WriteLine(pessoa.Sexo);


            Console.ReadKey();

        }
    }
}
