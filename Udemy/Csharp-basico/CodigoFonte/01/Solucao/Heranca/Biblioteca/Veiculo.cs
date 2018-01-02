using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Biblioteca
{
    class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int QtdPassageiros;
        public int Ano;

        public virtual void Mover()
        {
            Console.WriteLine("Veiculo.Mover");
        }
    }
}
