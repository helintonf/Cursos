using System;
using System.Threading;

namespace ThreadSafe
{
    class Program
    {
        static int Rede = 1;
        static object variavelDeControle = 0;

        /// <summary>
        /// IO - Input/Output - Lento(Tela, Rede, Armazenamento, Impressora-Rede)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Thread Safe!");

            Sleep();

            Join();

            Console.ReadKey();
        }



        static void MultiplosFluxos()
        {
            for (int i = 1; i <= 5; i++)
            {

                //Thread t1 = new Thread(MultiThread);
                Thread t1 = new Thread(IdThread);
                //Cria dependencia entre threads
                //t1.IsBackground = true;
                //t1.Start();
                t1.Start(i);

            }

            Console.WriteLine("Programa Finalizado!");
        }


        /// <summary>
        /// Multiplas threads
        /// </summary>
        static void MultiThread()
        {
            var id = 0;
            lock (variavelDeControle)
            {
               id =  Rede++;
            }
            for (int i = 1; i <= 10; i++)
            {
                ///recursos compartilhados somente uma thread por vez pode utilizar o recurso
                //FIFO - First In e First Out
                //lock (variavelDeControle) {
                Console.WriteLine($"Thread-{id}: " + i);
                //Rede++;
                //}
            }
        }

        /// <summary>
        /// Identificar a thread
        /// </summary>
        static void IdThread(object id)
        {
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine($"Thread:{(int)id} - " + i +" | ID Interno da Thread: "+ Thread.CurrentThread.ManagedThreadId);

            }
        }

        /// <summary>
        /// Tempo que a thread deve esperar para prosseguir
        /// </summary>
        static void Sleep()
        {
            Console.WriteLine("Inicio Programa");
            Thread.Sleep(3000);
            Console.WriteLine("Fim Programa");
            
        }

        /// <summary>
        /// Quando vc quer que seu programa só execute depois que uma thread foi finalizada
        /// Thread principal espere a execução
        /// Juntar a thread com o fluxo principal
        /// </summary>
        static void Join()
        {

            Thread t1 = new Thread(IdThread);

            t1.Start(1);
            t1.Join();

            Console.WriteLine("Fim Programa");
            Console.WriteLine("Fim Programa");
            Console.WriteLine("Fim Programa");
            Console.WriteLine("Fim Programa");


        }

    }
}
