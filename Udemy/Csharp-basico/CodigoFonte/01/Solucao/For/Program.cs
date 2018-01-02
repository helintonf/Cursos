using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");

            for (int i = 1; i <= 10; i ++)//(declarar variavel; expressão; estrutura de incremento ou decremento)
            {
                Console.WriteLine("Numero da Linha: "+i);
            }


            Console.ReadKey();
        }
    }
}
