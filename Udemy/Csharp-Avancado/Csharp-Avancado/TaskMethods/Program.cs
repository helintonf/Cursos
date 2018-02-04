using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Linq;

namespace TaskMethods
{
    class Program
    {
        /// <summary>
        /// executar metodos assincronos
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Metodos Asyncronos!");


            MultiplasTasks();


            Console.ReadKey();

        }

        /// <summary>
        /// Formas de executar metodos assincronos com Task
        /// </summary>
        static void AxecutarMEthodsAsync()
        {
            //primeira forma
            Task.Run(() => Metodo01());
            Task.Run(() => Metodo01());

            //segunda forma
            Task.Factory.StartNew(Metodo01);
        }

        /// <summary>
        /// exemplo de um metodo
        /// </summary>
        static void Metodo01()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Valor: " + i + " | ID: " + Task.CurrentId);
            }

        }

        /// <summary>
        /// multiplas tasks executadas ao mesmo tempo.
        /// </summary>
        static void MultiplasTasks()
        {
            List<Task> lista = new List<Task>();

            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));

            //vai executar toda a lsita de task e esperar todas elas finalizarem
            Task.WaitAll(lista.ToArray());
            //Task.WaitAny(lista.ToArray());
            //Task.WhenAll(lista.ToArray());



            string[] end = new string[] { "http://www.google.com.br", "http://www.microsoft.com.br", "http://www.globo.com" };

            var listaEnd = from e in end select DownloadPage(e);

            Task.WaitAll(listaEnd.ToArray());

            Console.WriteLine("Programa Finalizado!!!");
        }


        public static async Task DownloadPage(string end)
        {
            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(end);

            Console.WriteLine("Download realizado da pagina: " + end);

        }
    }
}
