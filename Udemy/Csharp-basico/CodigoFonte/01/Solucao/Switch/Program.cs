using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu estado civil?");
            string valor = Console.ReadLine();

            switch (valor.ToUpper().FirstOrDefault())//variavel valor
            {
                case 'S':
                    //codigo
                    Console.WriteLine("Você é Solteiro!");
                    break;
                case 'C':
                    Console.WriteLine("Você é Casado!");
                    break;
                case 'V':
                    Console.WriteLine("Você é Viovo!");
                    break;
                case 'D':
                    Console.WriteLine("Você é Divorciado!");
                    break;
                default:
                    Console.WriteLine("Opção não definida");
                    break;
            }

            Console.ReadKey();
        }
    }
}
