using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string texto = " \" \" ";//contra para converter de texto o caracterre



            Console.ReadKey();



        }

        /// <summary>
        /// escrever um arquivo com o Using
        /// </summary>
        static void EscreverByUsing()
        {
            using (StreamWriter arquivo = new StreamWriter("C:\\home\\texto.txt"))
            {
                arquivo.WriteLine("Olá meu texto tudo bem?");

                arquivo.WriteLine("Bem Vindo");
            }
                

            Console.WriteLine("Arquivo Gravado!");
        }


        /// <summary>
        /// Ler um arquivo em uma variavel ou em todas as linhas
        /// </summary>
        static void Ler()
        {
            //ler tudo
            string texto = File.ReadAllText("C:\\home\\texto.txt");

            Console.WriteLine(texto);

            //linhas separadas
            string[] linhas = File.ReadAllLines("C:\\home\\texto.txt");

            Console.WriteLine("Quantidade Linhas: " + linhas.Length);

            foreach (string linha in linhas)
            {
                Console.WriteLine("Linha: " + linha);
            }
        }

        /// <summary>
        /// Gravar um arquivo
        /// </summary>
        static void Gravar()
        {
            StreamWriter arquivo = new StreamWriter("C:\\home\\texto.txt");

            arquivo.WriteLine("Olá meu texto tudo bem?");

            arquivo.WriteLine("Bem Vindo");


            arquivo.Close();


            Console.WriteLine("Arquivo Gravado!");
        }
    }
}
