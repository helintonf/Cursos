using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pessoa pessoa = new Pessoa("Helinton", 'M', new DateTime(1989, 10, 3), 1.5, 45.8);

            //pessoa.SetPosicao(1.5, 45.8);

            string texto = pessoa.GetPosicao();
            Console.WriteLine(texto);
            Console.WriteLine(pessoa.Resumo());

            Console.ReadKey();
        }
    }
}
