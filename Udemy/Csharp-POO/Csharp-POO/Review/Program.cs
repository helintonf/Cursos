using System;
using System.Globalization;

namespace Review
{
    /// <summary>
    /// Tudo roda em uma classe,
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //double x = 10.25784;

            //Console.WriteLine(x);

            ////casas decimais
            //Console.WriteLine(x.ToString("F2"));
            //Console.WriteLine(x.ToString("F4"));

            ////para imprimir com ponto por causa da cultura. separador de ponto
            //Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            //CALCULAR COM A ESTRUTURA IF
            //CalcularEq2();

            //CALCULAR IDADE COM WHILE E MEDIA
            //CalcularIdade();

            //CALCULAR DIVISÃO
            CalcularDivisao();


            Console.ReadKey();
        }

        /// <summary>
        /// Calcular Divisão de N numeros
        /// </summary>
        public static void CalcularDivisao()
        {
            int n;
            double x, y, result;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);

                if (y == 0.0)
                {
                    Console.WriteLine("Não Existe");
                }
                else
                {
                    result = x / y;
                    Console.WriteLine(result.ToString("F3", CultureInfo.InvariantCulture));
                }
            }
        }

        /// <summary>
        /// Calcular Idade
        /// </summary>
        public static void CalcularIdade()
        {
            int idade, soma, cont;
            double media;

            soma = 0;
            cont = 0;

            do
            {
                Console.Write($@"Idade Pessoa {cont + 1}: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 0)
                {
                    soma += idade;
                    cont++;
                }

            }
            while (idade >= 0);

            media = (double)soma / cont;//forçar conversão para double - Casting


            if (cont == 0)
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }


        /// <summary>
        /// Calcular Equação do segundo grau.
        /// </summary>
        public static void CalcularEq2()
        {
            double delta, x1, x2;

            double a, b, c;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = b * b - 4 * a * c;

            if (a == 0.0 || delta < 0.0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);//raiz quadrada = Math.Sqrt()
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("X1 = " + x1.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F4", CultureInfo.InvariantCulture));
            }

        }
    
    }
}
