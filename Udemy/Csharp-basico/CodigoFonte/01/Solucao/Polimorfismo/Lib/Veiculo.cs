using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Lib
{
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int  Ano { get; set; }


        public virtual void Mover()
        {
            Console.WriteLine("Mover.Veiculo");
        }
    }
}
