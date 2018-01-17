using System;

namespace ThisBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Carro car = new Carro(1);





            Console.ReadKey();


        }

        static void Converter()
        {
            double preco = 3125.04;

            //por classe
            int a = Convert.ToInt32(preco);

            //por casting
            int b = (int)preco;

        }
    }
}
