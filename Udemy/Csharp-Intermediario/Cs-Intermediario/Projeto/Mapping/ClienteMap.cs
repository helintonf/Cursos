using Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Mapping
{
    public class ClienteMap
    {
        public static string ParseToText(Cliente cliente)
        {
            string text = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}",
                cliente.Nome,
                cliente.DtNascimento,
                cliente.Telefone,
                cliente.CPF,
                cliente.RG,
                cliente.CEP,
                cliente.UF,
                cliente.Cidade,
                cliente.Endereco);
            return text;
        }

        public static Cliente ParseToCliente(string linha)
        {
            string[] elementos = linha.Split(',');

            Cliente cliente = new Cliente();
            cliente.Nome = elementos[0];
            cliente.DtNascimento = DateTime.Parse(elementos[1]);
            cliente.Telefone = elementos[2];
            cliente.CPF = elementos[3];
            cliente.RG = elementos[4];
            cliente.CEP = int.Parse(elementos[5]);
            cliente.UF = elementos[6];
            cliente.Cidade = elementos[7];
            cliente.Endereco = elementos[8];

            return cliente;

        }
    }
}
