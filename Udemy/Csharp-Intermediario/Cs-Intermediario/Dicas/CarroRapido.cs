using System;
using System.Collections.Generic;
using System.Text;

namespace Dicas
{
    /// <summary>
    /// Construtor Rapido
    /// </summary>
    public class CarroRapido
    {
        public string Marca { get; set; }
        //>= C# 6.0 pode atribuir valor a propridade
        public string Modelo { get; set; } = "Gol";
        public int Rodas { get; set; }
        public DateTime Ano { get; set; }
      
    }
}
