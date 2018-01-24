using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Projeto.Data
{
    public class GerenciadorArquivo
    {
        public static void GravarArquivo(string nome, string texto)
        {
            Console.Clear();

            string caminho = "C:\\home\\"+nome+".txt";

            if (File.Exists(caminho))
            {
                using (StreamWriter wr = File.AppendText(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(caminho))
                {

                    wr.WriteLine(texto);

                }
            }

            Console.WriteLine(nome.ToUpper() + " foi salvo com sucesso!");
        }

        public static string[] LerArquivo(string nome)
        {
            string caminho = "C:\\home\\" + nome + ".txt";
            return File.ReadAllLines(caminho);
        }
    }
}
