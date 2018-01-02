using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            bool repetir = false;

            while (repetir)
            {
                Console.WriteLine("Entrou no \"fluxo\" 'While'");//importante
            }


            do //faça isso equanto a expressao for verdadeira
            {

                Console.WriteLine("Entrou no \"fluxo\" 'Do-While'");



            } while (repetir);


            Console.ReadKey();



        }
    }
}
