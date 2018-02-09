using Reflections.Modelo;
using System;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Usuario user = new Usuario() { Nome = "Helinton", Email = "Heliton@hfweb.com.br", Senha = "123456" };

            Log.Gravar(user.Clone());

            user.Nome = "Helinton Fioramonte";

            Log.Gravar(user.Clone());


            Carro car = new Carro() { Marca = "WV", Modelo = "Gol" };

            Log.Gravar(car);

            Log.Apresentar();

            Console.WriteLine("");



            Console.ReadKey();
        }
    }
}
