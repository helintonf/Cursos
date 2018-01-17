using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            //estrutura herda de System.ValueType = para object
            int a = 10;

            object b = a; //Boxing


            Console.WriteLine(b);

            Console.ReadKey();

        }


        static void Boxing()
        {
            //estrutura herda de System.ValueType = para object
            int a = 10;

            object b = a; //Boxing
        }

        static void UnBoxing()
        {
            //estrutura herda de System.ValueType = para object
            int a = 10;
            object b = a;   //Boxing

            int c = (int)b; //Unboxing
        }
    }
}
