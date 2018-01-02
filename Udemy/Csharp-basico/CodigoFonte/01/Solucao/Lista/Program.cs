using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> marcas = new List<string>();

            marcas.Add("FIAT");
            marcas.Add("Ford");
            marcas.Add("Jeep");
            marcas.Add("Volkswagen");

            foreach (string marca in marcas)
            {
                Console.WriteLine("Primeira marca: " + marca);
            }


            Console.WriteLine("Primeira marca: "+marcas.FirstOrDefault());


            Console.ReadKey();
        }
    }
}
