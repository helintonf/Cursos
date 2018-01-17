using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Transporte
{
    public class Veiculo
    {
        public string Marca { get; set; }
        protected string Modelo { get; set; }
        private int Ano { get; set; }
        //somente esse projeto ve essa proproidade
        internal int AnoModelo { get; set; }
        //somente para o proprio projeto e para derivados.
        internal protected string Cor { get; set; }


        public void InfoVeiculo()
        {
            Marca = "Fiat";
            Console.WriteLine(Marca);

            Modelo = "Palio";
            Console.WriteLine(Modelo);

            Ano = 2010;
            Console.WriteLine(Ano);

            AnoModelo = 2011;
        }

    }
}
