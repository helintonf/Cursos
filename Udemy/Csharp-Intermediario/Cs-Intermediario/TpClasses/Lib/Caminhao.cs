using System;
using System.Collections.Generic;
using System.Text;

namespace TpClasses.Lib
{
    sealed class Caminhao : Veiculo
    {
        public override string Marca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Modelo => throw new NotImplementedException();

        public override void MudarMarcha(byte Numero)
        {
            throw new NotImplementedException();
        }
    }
}
