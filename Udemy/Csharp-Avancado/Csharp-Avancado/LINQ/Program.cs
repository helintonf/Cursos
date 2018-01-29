using Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ e LAMBDA");


            ///SinxtaxeMetodos();

            /// SintaxeLiteral();
            /// LINQByObject();
            ///  Join();
            GroupDistinct();

            Console.ReadKey();
        }

        /// <summary>
        /// LINGQ com as expressóes Group by e Distinct não er repetições
        /// </summary>
        static void GroupDistinct()
        {
            int[] listaNumero = { 1, 1, 1, 1, 2, 5, 7, 8, 8, 9, 40, 9, 5, 4, 6, 6, 6, 3, 10, 10 };

            //Distinct
            var listaFilter = listaNumero.OrderBy(a => a).Distinct();

            //Group BY
            var listafiltrada = listaNumero.OrderBy(a => a).GroupBy(a => a).Select(a => a.Key); //SQL HAVING

            foreach (var item in listafiltrada)
            {
                Console.WriteLine(item);
            }

        }

        /// <summary>
        /// LINQ com Join
        /// </summary>
        static void Join()
        {
            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "Amor" });
            listaLivro.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Novela" });
            listaLivro.Add(new Livro() { Id = 3, AutorId = 1, Titulo = "Segredo de Casa" });
            listaLivro.Add(new Livro() { Id = 4, AutorId = 3, Titulo = "Pinga em Mim" });

            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add(new Autor() { Id = 1, Nome = "Helinton" });
            listaAutor.Add(new Autor() { Id = 2, Nome = "Josy" });
            listaAutor.Add(new Autor() { Id = 3, Nome = "Graça" });

            var listaJoin = from livros in listaLivro join autor in listaAutor on livros.AutorId equals autor.Id select new { livros.Titulo, autor.Nome };

            foreach (var item in listaJoin)
            {
                Console.WriteLine($"Livro: {item.Titulo} - Autor: {item.Nome}");
            }

        }

        /// <summary>
        /// Trabalhando LINQ com Objetos
        /// </summary>
        static void LINQByObject()
        {
            List<Usuario> lista = new List<Usuario>();

            lista.Add(new Usuario() { Nome = "Josy", Email = "josiellyjf@gmail.com" });
            lista.Add(new Usuario() { Nome = "Helinton", Email = "helintonf@bol.com" });
            lista.Add(new Usuario() { Nome = "Graça", Email = "mae@ig.com" });
            lista.Add(new Usuario() { Nome = "Claudio", Email = "pai@gmail.com" });
            lista.Add(new Usuario() { Nome = "Tereza", Email = "sogra@bol.com" });

            var filtro = lista.Where(a => a.Email.Contains("@gmail.com")).OrderBy(a => a.Nome).Select(a => a);

            foreach (var item in filtro)
            {
                Console.WriteLine($"Usuario: {item.Nome} - {item.Email}");
            }
        }


        /// <summary>
        /// LINQ atraves de metodos
        /// </summary>
        static void SinxtaxeMetodos()
        {

            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //() entrada vazia porque faz parte do objeto
            //ou utilizar variavel
            var filtro = lista.Where(a => a > 10).OrderBy(a => a);

            foreach (var item in filtro)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// LINQ atraves da forma literal
        /// </summary>
        static void SintaxeLiteral()
        {

            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //() entrada vazia porque faz parte do objeto
            //ou utilizar variavel
            var filtro = from a in lista where a > 10 orderby a select a;


            foreach (var item in filtro)
            {
                Console.WriteLine("--" + item);
            }


        }
    }
}
