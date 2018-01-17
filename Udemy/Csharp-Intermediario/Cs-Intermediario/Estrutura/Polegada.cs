using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura
{
    public struct Polegada
    {
        public double centimetro;
        double polegada;

        public Polegada(double polegadas)
        {
            centimetro = 2.54;
            polegada = centimetro * polegadas;
        }

        //public double Centimetro { get => centimetro; set => centimetro = value; }

        public double GetPolegada(double polegada)
        {
            return 2.54 * polegada;
        }

    }
}
