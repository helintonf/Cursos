using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversão implicita - comporta uma maior capacidade
            
            short  meuShort = 10; //16
            int  meuInt = meuShort; //32
            long meuLong = meuInt; //64


            long meuLong2 = 10;
            int meuInt2 = Convert.ToInt32(meuLong2);
            short meuShort2 =System.Convert.ToInt16(meuInt2);

            Console.Write(meuShort2);
        }
    }
}
