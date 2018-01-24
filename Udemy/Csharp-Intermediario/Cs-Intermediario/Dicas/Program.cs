using System;
using static System.Math;


namespace Dicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nome = "Helinton", ano = "2018";

            string texto = string.Format("Olá {0}! feliz {1}!", nome, ano);


            Console.WriteLine(texto);

            Console.WriteLine("Olá {0}! feliz {1}!", nome, ano);

            //recurso para formatar string
            Console.WriteLine($"Olá {nome}! Feliz {ano}!");


            Console.ReadKey();
        }

        static void UsingStatic()
        {
            //using normal
            Math.Pow(2, 3);

            //using static
            Pow(2, 3);
        }


        /// <summary>
        /// Construir o objeto de forma padrao
        /// </summary>
        static void ConstruirPadrao()
        {
            //construtor padrão
            CarroRapido car = new CarroRapido();
        }

        /// <summary>
        /// construção rapida e atribuição de valores
        /// </summary>
        static void ConstruirRapido()
        {
            //construir rapido e incrementar
            CarroRapido car = new CarroRapido() { Marca = "AUDIO", Modelo = "G4", Rodas = 4, Ano = new DateTime(2010, 01, 01) };
        }
    }
}
