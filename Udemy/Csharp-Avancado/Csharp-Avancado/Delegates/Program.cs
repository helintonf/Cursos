using Delegates.Lib;
using System;

namespace Delegates
{
    class Program
    {
        /// <summary>
        /// Delegate para calcular
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Delegates!");



            //Tela - Cadastro de Usuaio: Thumb (Foto de Perfil)
            Foto foto = new Foto() { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;

            FotoProcessador.Processar(foto);

            //Tela - Cadastro de Produtos: Colorir + Tamanho Medio
            Foto foto2 = new Foto() { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().Remimensionar;
            FotoProcessador.Processar(foto2);


            //Tela - Cadastro de ALbuns do Usuario - Retro: Preto e Branco
            Foto foto3 = new Foto() { Nome = "album.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().PretoBraco;            
            FotoProcessador.Processar(foto3);


           


            ///FotoProcessador.Processar(foto);

            Console.ReadKey();
        }

 
        


        static void ExemploBasico()
        {
            //metodos tradicionais
            //var so = Soma(10, 20);
            //var su = Subtrair(20, 10);

            //delegates
            Calcula cal = new Calcula(Soma);
            int so = cal(10, 20);


            Calcula cal1 = new Calcula(Subtrair);
            int su = cal1(30, 15);



            Console.WriteLine($"Soma: {so}");
            Console.WriteLine($"Subtração: {su}");
        }

        /// <summary>
        /// faz a soma
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
