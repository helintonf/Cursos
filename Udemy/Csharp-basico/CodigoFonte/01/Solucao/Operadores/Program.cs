using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {          
            //Operadores Aritimeticos
              
            //não isolar
            Console.WriteLine("Soma: " + 2 + 2);

            //isolar a expressão aritimetica.
            Console.WriteLine("Soma: " + (2 + 2));

            Console.WriteLine("Subtração: " + (5 - 2));

            Console.WriteLine("Multiplicação: " + (3 * 9));

            Console.WriteLine("Divisão: " + (6 / 2));

            Console.WriteLine("Módulo/Resto: " + (8 % 3));


            //Operadores de atribuição

            int valorA = 10;
            valorA += 10; // valorA = ValorA + 10;
            valorA -= 10; // valorA = ValorA - 10;
            valorA *= 3; // valorA = valorA * 3;
            valorA /= 3; // valorA = valorA / 3;
            valorA %= 4; // valorA = valorA % 4;


            //Operadores relacionais

            Console.WriteLine(!(10 == 10));

            if (10 == 10)
            {
                Console.WriteLine("é 10");
            }
            

            Console.WriteLine(10 == 11);

            Console.WriteLine(10 > 9); //maior
            Console.WriteLine(10 < 9); //menor

            Console.WriteLine(10 >= 9); //maior igual
            Console.WriteLine(10 <= 9); //menor igual

            Console.WriteLine(10 != 10); //diferente

            //Operadores Logicos

            string sexo = "M";
            int idade = 18;

            if(sexo == "M" & idade == 18)
            {
                Console.WriteLine("Deve se alistar");
            }

            //isolamento
            if(sexo == "M" || (sexo =="F" && idade >= 18))
            {
                Console.WriteLine("Verdadeiro");
            }


            if(10 == 10 & 10 > 9)
            {
                Console.Write("Verdade");
            }

            if(10 == 10 | 10 == 9)
            {
                Console.Write("Verdade");
            }

            Console.ReadKey();
        }
    }
}
