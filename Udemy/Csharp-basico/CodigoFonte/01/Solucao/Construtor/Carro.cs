using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano;

        public Carro()
        {
            //implementações set os atributo
            Marca = "Fiat";
            Modelo = "Palio";
            Ano = 2008;
        }
        //sobrecarga de metodos contrutores.
        public Carro(string Marca, string Modelo, int ano)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            Ano = ano;
        }

        public override string ToString()
        {
            return Marca + " - " + Modelo + " - "+ Ano;
        }
    }
}
