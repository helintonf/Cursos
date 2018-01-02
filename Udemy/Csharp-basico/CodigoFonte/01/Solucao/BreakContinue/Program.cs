using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Continue--------------");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;//pula ou interrompe a interação o laço de repetição porem pula para a proxima interação
                }

                Console.WriteLine("Linhas: " + i);

               
            }


            Console.WriteLine("--------------Break--------------");


            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; //para a execução do laço de repetição
                }

                Console.WriteLine("Linhas: " + i);


            }

            Console.ReadKey();
        }
    }
}
