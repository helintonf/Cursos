using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    //tipos de dados de numeros inteiros
    class ShortIntLong
    {
        //short Int16 -32K = +32K
        public short meuShort { get; set; }
        //int Int32  -2B = +2B
        public int meuInt { get; set; }
        //long Int64  -92Q = +92Q
        public long meuLong { get; set; }

        //U = unsigned só aceita numeros positivos

        //ushort Int16 +65K
        public ushort meuUshort { get; set; }
        //uint Int32 +4B
        public uint meyUint { get; set; }
        //ulong Int64 +200Q
        public ulong meuUlong { get; set; }

    }
}
