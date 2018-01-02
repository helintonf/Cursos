using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //constante não muda valor - deve vr valor na declaração - criada na compilação
            const bool Aberto = true;

            Console.WriteLine(Aberto);
            Console.ReadKey();
             
        }
    }
}
