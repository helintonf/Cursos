using Projeto.Controller;
using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Sistema!");
           
            int op = 0;

            ClienteController cliente = new ClienteController();
            FuncionarioController funcionario = new FuncionarioController();

            while (op != 5)
            {
                Console.WriteLine("Oque deseja fazer? \n(1 = Cadastrar Cliente, 2 = Listar Cliente, 3 = Cadastrar Funcionario, 4 = Listar Funcionario, 5 = Fechar Programa)");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:                       
                        cliente.CadastrarCliente();
                        break;
                    case 2:
                        cliente.ListarClientes();
                        break;
                    case 3:
                        funcionario.CadastrarFuncionario();
                        break;
                    case 4:
                        funcionario.ListarFuncionarios();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Comando Invalido");
                        break;
                }
            }
        
           // Console.ReadKey();
        }
    }
}
