using System;
using System.Collections.Generic;
using System.Text;

namespace ThisBase
{
    class Carro : Veiculo
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(int i) : base(i)//acionar o construtor da classe base
        {
            Console.WriteLine("Construindo Carro");
        }

        public void SetMarca(string Marca)
        {
            this.Marca = Marca;
            this.SetModelo();
        }

        public void SetModelo()
        {

        }

        public override void Andar()
        {
            base.Andar();
        }

    }
}
