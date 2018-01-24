using Lib.Model;
using Projeto.Data;
using Projeto.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Controller
{
    class ClienteController
    {
        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.Clear();

            Console.WriteLine("CADASTRAR CLIENTE");

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            cliente.DtNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();


            Console.Write("CPF: ");
            cliente.CPF = Console.ReadLine();


            Console.Write("RG: ");
            cliente.RG = Console.ReadLine();


            Console.Write("CEP(*Apenas Numeros): ");
            cliente.CEP = int.Parse(Console.ReadLine());


            Console.Write("Estato: ");
            cliente.UF = Console.ReadLine();


            Console.Write("Cidade: ");
            cliente.Cidade = Console.ReadLine();


            Console.Write("Endereço: ");
            cliente.Endereco = Console.ReadLine();

            GerenciadorArquivo.GravarArquivo("Cliente", ClienteMap.ParseToText(cliente));
        }

        public void ListarClientes()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE CLIENTES");

            string[] linhas = GerenciadorArquivo.LerArquivo("Cliente");

            foreach (string linha in linhas)
            {
                Cliente cliente = ClienteMap.ParseToCliente(linha);

                Console.WriteLine("Nome: " + cliente.Nome);
            }

        }
    }
}
