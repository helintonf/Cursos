using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Transporte
{
    public class Caminhao : Veiculo
    {
        byte QtRodas = 10;

        protected internal void InfoCaminhao()
        {
            Modelo = "1520";
            Console.WriteLine(Modelo);
        }
    }
}
