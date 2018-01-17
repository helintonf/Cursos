using System;
using TpClasses.Lib;

namespace TpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de Classes!");

            Enumeradores();

            Console.ReadKey();
        }

        /// <summary>
        /// enumeradores
        /// </summary>
        static void Enumeradores()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;

            //pegar descrição
            Console.WriteLine("Estado Civil: " + EstadoCivil.Solteiro);
            //pegar valor numerico
            Console.WriteLine("Estado Civil Numerico: " + (int)EstadoCivil.Solteiro);


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Blue;

            //pegar descrição
            Console.WriteLine("Estado Civil: " + EstadoCivil.Casado);
            //pegar valor numerico
            Console.WriteLine("Estado Civil Numerico: " + (int)EstadoCivil.Casado);

        }

        /// <summary>
        /// Classe dentro de outra classe
        /// </summary>
        static void ClasseInterna()
        {

            //precisa indicar o caminho completo.
            new Pessoa.Olho();

        }

        /// <summary>
        /// não pode isntanciar uma classe abstrata.
        /// </summary>
        static void ClasseAbstrata()
        {
            Carro car = new Carro();

            //não executa
            ///Veiculo v = new Veiculo();
        }
    }
}
