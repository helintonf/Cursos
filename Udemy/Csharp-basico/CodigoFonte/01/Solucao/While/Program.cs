using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            while (i < 10)//expressão
            {
                //codigo;
                Console.WriteLine("Valor da variável: " + i);
                i += 1;
            }

            int x = 0;
            bool rep = true;

            while (rep)
            {
                Console.WriteLine("Valor da variável: " + x);
                if (x > 20)
                {
                    Console.WriteLine("Saindo do Programa");
                    rep = false;
                }

                x += 2;
            }

            Console.ReadKey();
        }
    }
}
