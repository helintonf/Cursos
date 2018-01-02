using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] marcas = { "Ferrari", "Google", "Coca-Cola" };

            string[] nomes = new string[2];//instanciar um array de string
            nomes[0] = "Helinton";
            nomes[1] = "Josy";


            //multidimensional

            string[,] brands = new string[3,4];

            brands[0,0] = "FIAT";
            brands[0,1] = "Volkswagen";
            brands[0,2] = "Ford";
            brands[0,3] = "Jeep";
            brands[1,0] = "Dell";
            brands[1,1] = "HP";
            brands[1,2] = "Asus";
            brands[1,3] = "Acer";
            brands[2,0] = "LG";
            brands[2,1] = "Samsung";
            brands[2,2] = "Motorola";
            brands[2,3] = "Nokia";

            string[,] names = new string[,] { { "FIAT","Volkswagen" }, {"Dell","Asus" }, {"LG","Samsung" } };

        }
    }
}
