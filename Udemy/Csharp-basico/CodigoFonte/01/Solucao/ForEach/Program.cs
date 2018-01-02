using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Helinton", "Helielton", "Josy", "Graça", "Claudio", "Terezinha" };



            Console.WriteLine("-------------Repetição com FOR-------------");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nomes: "+nomes[i]);
            }

            Console.WriteLine("-------------Repetição com FOREACH-------------");

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: "+nome);
            }




            Console.ReadKey();

        }
    }
}
