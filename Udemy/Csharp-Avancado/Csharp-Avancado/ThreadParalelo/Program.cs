using System;
using System.Threading;

namespace ThreadParalelo
{
    class Program
    {
        public static int n = 1;

        /// <summary>
        /// Fluxo Principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            MainMultiplosFluxos();


            Console.ReadKey();
        }

        /// <summary>
        /// Thread principal
        /// </summary>
        public void ThreadMain()
        {
            Thread t1 = new Thread(ThreadRepeticao);

            t1.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main: " + i);
            }
        }

        /// <summary>
        /// Fluxo alternativo a ser executado.
        /// </summary>
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Rep: " + i);
            }
        }

        /// <summary>
        /// Multiplos fluxos
        /// </summary>
        static void MainMultiplosFluxos()
        {
            for (int i = 1; i <= 5; i++)
            {
                n = i;
                Thread t1 = new Thread(MultiThread);
                //Cria dependencia entre threads
                t1.IsBackground = true;
                t1.Start();

            }

            Console.WriteLine("Programa Finalizado!");
        }

        /// <summary>
        /// Multiplas threads
        /// </summary>
        static void MultiThread()
        {
            var ind = n;
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine($"Rep-{ind}: " + i);
            }
        }
    }
}
