using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTxtNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumeroTxt = "30";
            int Result = int.Parse(NumeroTxt);
            int Numero = 30;
            //isolar a conversão para não transformar tudo em string
            Console.Write("O resultado é: "+ (Result + Numero));
            Console.ReadKey();
        }
    }
}
