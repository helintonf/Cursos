using Lib.Model;
using Projeto.Data;
using Projeto.Mapping;
using System;

namespace Projeto.Controller
{
    class FuncionarioController
    {
        public void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Clear();

            Console.WriteLine("CADASTRAR FUNCIONARIO");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            funcionario.DtNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            funcionario.Telefone = Console.ReadLine();


            Console.Write("CPF: ");
            funcionario.CPF = Console.ReadLine();


            Console.Write("RG: ");
            funcionario.RG = Console.ReadLine();


            Console.Write("CEP(*Apenas Numeros): ");
            funcionario.CEP = int.Parse(Console.ReadLine());


            Console.Write("Estato: ");
            funcionario.UF = Console.ReadLine();


            Console.Write("Cidade: ");
            funcionario.Cidade = Console.ReadLine();


            Console.Write("Endereço: ");
            funcionario.Endereco = Console.ReadLine();

            Console.Write("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.Write("Data Admissão: ");
            funcionario.DtAdimissao = DateTime.Parse(Console.ReadLine());

            GerenciadorArquivo.GravarArquivo("Funcionario", FuncionarioMap.ParseToText(funcionario));
        }

        public void ListarFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE FUNCIONARIOS");

            string[] linhas = GerenciadorArquivo.LerArquivo("Funcionario");

            foreach (string linha in linhas)
            {
                Funcionario funcionario = FuncionarioMap.ParseToFuncionario(linha);

                Console.WriteLine("Nome: " + funcionario.Nome + ", Cargo: " + funcionario.Cargo + ", Salario: " + funcionario.Salario);

            }
        }
    }
}
