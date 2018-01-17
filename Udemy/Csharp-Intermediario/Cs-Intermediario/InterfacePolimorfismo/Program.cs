using System;

namespace InterfacePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Carro car = new Carro();
            Moto moto = new Moto();

            Andar(car);
            Andar(moto);

            Console.ReadKey();

        }

        static void Andar(ITransporte veiculo)
        {
            veiculo.Andar();
        }
    }
}
