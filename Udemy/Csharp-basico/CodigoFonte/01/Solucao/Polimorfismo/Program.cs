using Polimorfismo.Lib;
using Polimorfismo.Lib.Derivada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();

            Moto moto = new Moto();

            MoverVeiculo(car);
            MoverVeiculo(moto);


            Console.ReadKey();

        }

        //public static void MoverVeiculo(Carro veiculo)
        //{
        //    veiculo.Mover();
        //}
        //public static void MoverVeiculo(Moto veiculo)
        //{
        //    veiculo.Mover();
        //}

        //public static void MoverVeiculo(Onibus veiculo)
        //{
        //    veiculo.Mover();
        //}

        public static void MoverVeiculo(Veiculo veiculo)
        {
            veiculo.Mover();
        }
    }
}
