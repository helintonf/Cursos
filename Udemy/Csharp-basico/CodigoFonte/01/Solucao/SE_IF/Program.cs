using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorCPTxt;
            float valorCP;
            Console.WriteLine("Digite o valor da sua poupança?");
            valorCPTxt = Console.ReadLine();

            valorCP = float.Parse(valorCPTxt);

            if (valorCP > 100000)//expressão
            {
                //codigo;
                Console.WriteLine("Você possui uma taxa de juros maior de 2%.");
            }else if (valorCP > 50000)//outra verificação
            {
                Console.WriteLine("Você possu uma taxa de juros de 1.2%.");
            }
            else
            {
                Console.WriteLine("Você possui uma taxa de juros padrão de 0.5%.");
            }

            Console.ReadKey();
        }
    }
}
