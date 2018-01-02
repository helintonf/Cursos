using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erros
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite um numero: ");

            try
            {
                int numero = int.Parse(Console.ReadLine());
                int num = int.Parse(null);
            }
            catch (FormatException ex)//
            {
                Console.WriteLine("Não foi localizado números");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Valor nulo");
            }
            catch(Exception e)
            {
                Console.WriteLine("Classe raiz");
            }
            finally
            {
                Console.WriteLine("Finalmente");
                //é bom para fechar conecções
            }




            Console.ReadKey();





        }
    }
}
