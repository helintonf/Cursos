using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá amigos, estou muito feliz de estar aqui com voces. Desejo a todos um feliz ano novo.";
            String palavra = "feliz";
            string nome = "Helinton Fioramonte";
            string nomes = "Helinton, Josy, Helielton, Cláudio, Graça e Terezinha.";


            //LOCALIZAR TEXTO
            //Localizar(texto, palavra);

            //CONTEM EXISTENCIA
            //Existe(texto, palavra);

            //SUBISTITUIR STRING       
            //Console.WriteLine(texto.Replace("amigos", "Helinton"));

            //FORMATAR STRING       
            //Formatar(nome);

            //MAIUSCULO E MINUSCULO.
            //Console.WriteLine(texto.ToUpper());
            //Console.WriteLine(texto.ToLower());

            //REMOVER ESPAÇOS
            //RemoverEspacos(texto);

            //DIVIDIR TEXTO
            //string[] separador = { ", ", " e ", "." };
            //Dividir(nomes, separador);

            //SUBTEXTO
            SubTexto(texto, 55, 6);


            Console.ReadKey();


        }

        /// <summary>
        /// Extrair informação do Texto
        /// </summary>
        /// <param name="texto">Texto Base</param>
        /// <param name="posInicial">Posição Inicial</param>
        /// <param name="tamanho">tamanho da subString</param>
        public static void SubTexto(string texto, int posInicial, int tamanho)
        {
            string frase = texto.Substring(posInicial);
            string pl = texto.Substring(posInicial, tamanho);


            Console.WriteLine("2 frase: " + frase);
            Console.WriteLine("Palavra: " + pl);
        }

        /// <summary>
        /// Dividir string passando os caracteres que vai ocorrer a divisão
        /// </summary>
        /// <param name="nomes">texto base</param>
        /// <param name="separador">separadores</param>
        public static void Dividir(string nomes, string[] separador)
        {
            
            string[] nomesArray = nomes.Split(separador, StringSplitOptions.None);//parans aceita varios parametros para dividir

            foreach (string n in nomesArray)
            {
                Console.WriteLine(n);
            }
        }


        /// <summary>
        /// remove os espaços:
        /// -Inicio = TrimStart()
        /// -Fim = TrimEnd()
        /// -Inicio e Fim = Trim()
        /// </summary>
        /// <param name="texto">texto base com espaço</param>
        public static void RemoverEspacos(string texto)
        {
            Console.WriteLine("Inicio:" + texto.TrimStart()); //REMOVER DO COMEÇO
            Console.WriteLine("Final:" + texto.TrimEnd()); //REMOVER DO FINAL
            Console.WriteLine("Todos:" + texto.Trim()); //REMOVE DO INICIO E FINAL
        }


        /// <summary>
        /// Localiza caracter ou franse em uma string.
        /// Retorno a posição quando localizado.
        /// Retorno -1 quando não encontra.
        /// </summary>
        /// <param name="texto">texto base</param>
        /// <param name="palavra">texto para localizar a posição</param>
        public static void Localizar(string texto, string palavra)
        {
            Console.WriteLine("Tamanho do texto: " + texto.Length);
            Console.WriteLine("Localizar: " + texto.IndexOf(palavra));
            Console.WriteLine("Localizar Ultimo: " + texto.LastIndexOf(palavra));
        }

        /// <summary>
        /// Verifica a existencia de um caracter ou frase em uma string.
        /// Retorno Bolleano.
        /// </summary>
        /// <param name="texto">texto base</param>
        /// <param name="palavra">palavra para localizar</param>
        public static void Existe(string texto, string palavra)
        {
            Console.WriteLine("Contem o texto? " + (texto.Contains(palavra) ? "Sim" : "Não"));

            Console.WriteLine("Verificar no inicio: " + texto.StartsWith("Olá"));

            Console.WriteLine("Verificar no final: " + texto.EndsWith("novo."));

            Console.WriteLine("Verificar existencia: " + texto.Contains("amigos"));
        }

        /// <summary>
        /// Formatar a string concatenando de forma mais facil
        /// </summary>
        /// <param name="nome">texto para ser concatenando na frase</param>
        public static void Formatar(string nome)
        {
            string bv = "Bem Vindo " + nome + "! Feliz natal!";

            string newFormat = $@"Feliz ano novo {nome}";

            string txtFormat = String.Format("Bem vindo {0}! {1} Natal! - ", nome, "Feliz");

            Console.WriteLine(txtFormat + newFormat);
        }


    }
}
