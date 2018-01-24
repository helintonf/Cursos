using Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Mapping
{
    class FuncionarioMap
    {
        public static string ParseToText(Funcionario funcionario)
        {
            string text = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}",
                funcionario.Nome,
                funcionario.DtNascimento,
                funcionario.Telefone,
                funcionario.CPF,
                funcionario.RG,
                funcionario.CEP,
                funcionario.UF,
                funcionario.Cidade,
                funcionario.Endereco,
                funcionario.Cargo,
                funcionario.Salario,
                funcionario.DtAdimissao);

            return text;
        }

        public static Funcionario ParseToFuncionario(string linha)
        {
            string[] elementos = linha.Split(',');

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = elementos[0];
            funcionario.DtNascimento = DateTime.Parse(elementos[1]);
            funcionario.Telefone = elementos[2];
            funcionario.CPF = elementos[3];
            funcionario.RG = elementos[4];
            funcionario.CEP = int.Parse(elementos[5]);
            funcionario.UF = elementos[6];
            funcionario.Cidade = elementos[7];
            funcionario.Endereco = elementos[8];
            funcionario.Cargo = elementos[9];
            funcionario.Salario = double.Parse(elementos[10]);
            funcionario.DtAdimissao = DateTime.Parse(elementos[11]);

            return funcionario;
        }
    }
}
