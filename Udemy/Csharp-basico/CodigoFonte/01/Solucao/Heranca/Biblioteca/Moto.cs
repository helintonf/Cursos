using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Biblioteca
{
    class Moto : Veiculo
    {
        public int rodas = 2;

        public override void Mover()
        {
            Console.WriteLine("Moto.Mover");
            base.Mover();
        }
    }
}
