using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //por valor não recebe nullo.
            int i = null;

            //Classe pode ser nullo.
            object obj = null;

            //banco pode ter informações opcionais
            Nullable<int> idade = null;

            int? Idade2 = null;


            Console.ReadKey();
        }
    }
}
