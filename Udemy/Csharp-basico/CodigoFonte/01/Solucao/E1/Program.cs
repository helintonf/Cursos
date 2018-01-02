using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            string idade = Console.ReadLine();
        
            int anoNascimento = DateTime.Now.Year - Int32.Parse(idade);

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Olá " + nome);
            Console.WriteLine("Você Nasceu no ano de " + anoNascimento);


            Console.ReadKey();

        }
    }
}
