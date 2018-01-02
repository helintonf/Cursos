using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor: ");
            string valorTxt = Console.ReadLine();

            Console.WriteLine("Exponente: ");
            string expTxt = Console.ReadLine();

            int result  = Matematica.Expo(int.Parse(valorTxt), int.Parse(expTxt));

            Console.WriteLine("Resultado: " + result);

            Console.ReadKey();
        }
    }
}
