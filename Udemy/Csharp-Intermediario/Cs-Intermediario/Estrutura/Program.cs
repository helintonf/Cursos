using System;

namespace Estrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estrutura e passagem de valores");

            double valor = 25;

            //AlterarValor(valor);
            //AlterarValorRef(ref valor);

            //Console.WriteLine("Main > valor: " + valor);

            //AlterarValorOut(out valor);

            //Console.WriteLine("Main > valor: " + valor);


            //varias entradas com numero de parametros definidos
            VariasEntradas01("Helinton", "Josy", "Helielton");


            //varias entradas com a passagem de array
            string[] nomes = { "Helinton", "Josy", "Helielton" };
            VariasEntradas02(nomes);


            //varias entradas atravez de um parametro reservado pelo C# o params
            VariasEntradas03("Helinton", "Josy", "Helielton","Graça");





            Console.ReadKey();
        }

        /// <summary>
        /// Varias entradas com parametros definidos
        /// </summary>
        /// <param name="nome01"></param>
        /// <param name="nome02"></param>
        /// <param name="nome03"></param>
        static void VariasEntradas01(string nome01, string nome02, string nome03)
        {

        }

        /// <summary>
        /// varias entradas atraves de arrays
        /// </summary>
        /// <param name="nomes">array de nomes</param>
        static void VariasEntradas02(string[] nomes)
        {

        }

        /// <summary>
        /// varias entradas atraves de params, entrando com diversos párametros sem a necessidade de array
        /// </summary>
        /// <param name="nomes"></param>
        static void VariasEntradas03(params string[] nomes)
        {

        }


        /// <summary>
        /// passagem de valor por referencia utilizando a palavra reservada out
        /// </summary>
        /// <param name="valor">valor real</param>
        static void AlterarValorOut(out double valor)
        {
            valor = 10;
        }

        /// <summary>
        /// passagem de valores por referencia.
        /// </summary>
        /// <param name="valor">referencia do valor</param>
        static void AlterarValorRef(ref double valor)
        {
            Console.WriteLine("AlterarValor > valor: " + valor);

            valor += 10;

            Console.WriteLine("AlterarValor > valor: " + valor);
        }

        /// <summary>
        /// Criar uma Estrutura
        /// </summary>
        static void CriarStruct()
        {
            Polegada polegada = new Polegada(10);

            Polegada ppl;

            ppl.centimetro = 10;


            polegada.centimetro = 1;

            Console.WriteLine(polegada.GetPolegada(1));
        }

        /// <summary>
        /// passagem de parametro por valor
        /// </summary>
        /// <param name="valor">valor para ser duplicado</param>
        static void AlterarValor(double valor)
        {
            Console.WriteLine("AlterarValor > valor: " + valor);

            valor += 10;

            Console.WriteLine("AlterarValor > valor: " + valor);
        }
    }
}
