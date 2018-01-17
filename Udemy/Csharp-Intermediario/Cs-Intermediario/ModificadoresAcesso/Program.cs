using System;
using Biblioteca.Transporte;

namespace ModificadoresAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Veiculo v = new Veiculo();

            Carro car = new Carro();

            Caminhao cam = new Caminhao();

            car.Marca = "Ford";
            cam.Marca = "Volvo";
            
            

            car.InfoVeiculo();

            Truk t = new Truk();

            
            

            Console.ReadKey();
        }
    }
}
