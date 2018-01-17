using System;

namespace Excecao
{
    class Program
    {
        static void Main(string[] args)
        {

            string gerarCodigo;

            try
            {
                //codigo que pode gerar erro
                Pessoa pessoa = new Pessoa();
                pessoa.SetCEP("ABC10");
            }
            catch (FormatException forExc)
            {
                Console.WriteLine("Formato Invalido: " + forExc.Message);
            }
            catch (MinhaException ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
            finally
            {
                //bloco que sempre sera executado.
            }



            Console.ReadKey();
        }

        static void LancarException()
        {
            Console.WriteLine("Digite o numero 1: ");
            string digitado = Console.ReadLine();


            if (digitado == "1")
            {
                Console.WriteLine("Correto");
            }
            else
            {
                throw new Exception("Valor não é valido");
                Console.WriteLine("Errado");
            }
        }
    }
}
