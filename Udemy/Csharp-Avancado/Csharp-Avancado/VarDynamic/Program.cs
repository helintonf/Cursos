using System;

namespace VarDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //object é um tipo primitivo.
            //tipo generico.
            //a mesma variavel aceita valores e tipos diferentes
            object t1 = "";

            object t2 = 123;


            //var tipado dinamicamente.
            //obrigado a atribuir um tipo
            //vartipo é atribuido automaticamente na criação da variavel
            //a variavel não aceita tipos diferentes
            var v1 = "texto";
            var v2 = 123;
            //var v3;

            //dynamic
            //trabalha no tempo de execução // RunTime Execption
            //objeto que será resolvido em tempo de execução.
            //sem erros de compilação
            //atribuir valores diferentes

            dynamic d1 = new Usuario { Nome = "Helinton", Idade = 28 };


            Console.WriteLine(d1.Nome);

            d1.Senha = "123";

            Console.WriteLine(d1.Senha);



            Console.ReadKey();
        }
    }

    class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
