using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Byte SByte
            var bt = new ByeteSByte();

            bt.mBt = 10;
            bt.mySByte = -10;

            var it = new ShortIntLong();

            it.meuInt = 10;
            it.meuLong = 5;

            var fl = new FloatDoubleDecimal();

            fl.meuFloat = 1.5f;//f para converter para float
            fl.meuDouble = 25.8;
            fl.meuDecimal = 12.6m;//m para converter para decimal
            fl.meuDecimal = 2;//não precisa converter de int para decimal

            var st = new CharString();

            //todo caractere char tem que estar em aspas simples
            st.myChar = '3';
            //todo texto string tem que estar em aspas duplas - sequencia de caracteres
            st.myString = "Olá Mundo!";

            var ob = new BoolObj();

            ob.meuBool = true;
            //aceita todos os tipos - ele é a origem de todos os dados
            ob.meuObj = 3;


            //Console.Write()
            Console.Write(it.meuInt + it.meuLong);
            Console.ReadKey();
        }
    }
}
