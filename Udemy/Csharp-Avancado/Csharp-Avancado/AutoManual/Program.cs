using System;
using System.Threading;

namespace AutoManual
{
    class Program
    {

        static AutoResetEvent auto01;

        static ManualResetEvent manual01;

        static void Main(string[] args)
        {
            Console.WriteLine("Sincronizar Threads!");

            manual01 = new ManualResetEvent(false);//false é vermelho
            auto01 = new AutoResetEvent(false);

            Thread t1 = new Thread(Executa01);
            //t1.Start();


            Thread t2 = new Thread(Executa02);
            t2.Start();

            Thread.Sleep(5000);
            auto01.Set();
            manual01.Set();//sinal verde
            manual01.Reset();//converter para um possivel sinal vermelho

            Thread.Sleep(2000);
            auto01.Set();
            manual01.Set();

            Console.ReadKey();
        }

        static void Executa01()
        {
            Console.WriteLine("01 - Iniado Executa01.");
            manual01.WaitOne();
            Console.WriteLine("03 - em execução 01 -  Executa01.");
            Console.WriteLine("04 - em execução 02 -  Executa01.");
            Console.WriteLine("05 - em execução 03 -  Executa01.");
            Console.WriteLine("06 - em execução 04 -  Executa01.");
            manual01.WaitOne();
            Console.WriteLine("07 - Finalizado Executa01.");
        }

        static void Executa02()
        {
            Console.WriteLine("01 - Iniado Executa02.");
            auto01.WaitOne();
            Console.WriteLine("03 - em execução 01 -  Executa02.");
            Console.WriteLine("04 - em execução 02 -  Executa02.");
            Console.WriteLine("05 - em execução 03 -  Executa02.");
            auto01.WaitOne();
            Console.WriteLine("06 - em execução 04 -  Executa02.");
            Console.WriteLine("07 - Finalizado Executa02.");
        }
    }
}
