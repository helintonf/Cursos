using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Transporte
{
    public class Carro : Veiculo
    {
        byte QTRodas = 4;

        internal void InfoCarro()
        {
            Marca = "VW";
            Modelo = "Gol";

            AnoModelo = 2012;
            
            Console.WriteLine(Modelo);
        }
    }
}
