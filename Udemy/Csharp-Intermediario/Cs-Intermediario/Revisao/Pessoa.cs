using System;
using System.Globalization;

namespace Revisao
{
    /// <summary>
    /// Classe Pessoa
    /// </summary>
    class Pessoa
    {
        private string Nome { get; set; }
        private char Sexo;
        private DateTime DtNascimento;
        private double PosX, PosY;

        public Pessoa(string nome, char sexo, DateTime dtNascimento, double x, double y)
        {
            Nome = nome;
            Sexo = sexo;
            DtNascimento = dtNascimento;
            PosX = x;
            PosY = y;
        }

        /// <summary>
        /// Pegar posição da pessoa
        /// </summary>
        /// <returns>Texto da Posição</returns>
        public string GetPosicao()
        {
            return $@"{PosX.ToString("F2",CultureInfo.InvariantCulture)}, {PosY.ToString("F2",CultureInfo.InvariantCulture)}";
        }

        /// <summary>
        /// Setar posição da pessoa.
        /// </summary>
        /// <param name="x">Posição X</param>
        /// <param name="y">Posição Y</param>
        public void SetPosicao(double x, double y)
        {
            PosX = x;
            PosY = y;
        }

        /// <summary>
        /// Pegar um resumo da pessoa
        /// </summary>
        /// <returns>string</returns>
        public string Resumo()
        {
            return string.Format("Nome: {0} \nSexo: {1} \nData de Nascimento: {2}", Nome, Sexo, DtNascimento);
        }
    }
}
