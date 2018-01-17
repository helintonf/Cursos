using System;
using System.Collections.Generic;
using System.Text;

namespace TpClasses.Lib
{
    sealed class Carro : Veiculo, ITransporte
    {
        public override string Marca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Modelo => throw new NotImplementedException();

        public void Mover(byte velocidade)
        {
            throw new NotImplementedException();
        }

        public override void MudarMarcha(byte Numero)
        {
            Console.WriteLine("Mover");
        }
    }
}
