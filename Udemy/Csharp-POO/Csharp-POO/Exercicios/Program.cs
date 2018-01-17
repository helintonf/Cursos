using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os Valores!");

            //1
            //Volume();

            //2

            string[] notasTxt = Console.ReadLine().Split(' ');

            double notaFinal = 0.0;


            foreach (string notaTxt in notasTxt)
            {
                notaFinal += double.Parse(notaTxt, CultureInfo.InvariantCulture);
            }

            if(notaFinal < 60.00)
            {
                Console.WriteLine(notaFinal.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("DEPENDENCIA");
            }
            else
            {
                Console.WriteLine(notaFinal.ToString("F2",CultureInfo.InvariantCulture));
            }
            
            Console.ReadKey();
        }

        public static void Volume()
        {
            Console.WriteLine("Volume do Frasco.");
            int volume = int.Parse(Console.ReadLine());
            Console.WriteLine("Vazão da Bomba.");
            int vazao = int.Parse(Console.ReadLine());
            Console.WriteLine("Tempo Aberto.");
            int tempo = int.Parse(Console.ReadLine());

            int result = volume - (tempo * vazao);

            if (result < 0)
            {
                Console.WriteLine("Não é possivel");
            }
            else
            {
                Console.WriteLine("Restara no Frasco o volume de: " + result);
            }
        }
    }
}
