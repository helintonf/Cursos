using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Lib
{
    class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            Console.WriteLine($"FotoFiltro > Colorir - Nome: {foto.Nome}, Tamanho: {foto.TamanhoX}x{foto.TamanhoY}");
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine($"FotoFiltro > GerarThumb - Nome: {foto.Nome}, Tamanho: {foto.TamanhoX}x{foto.TamanhoY}");
        }

        public void PretoBraco(Foto foto)
        {
            Console.WriteLine($"FotoFiltro > PretoBraco - Nome: {foto.Nome}, Tamanho: {foto.TamanhoX}x{foto.TamanhoY}");
        }

        public void Remimensionar(Foto foto)
        {
            Console.WriteLine($"FotoFiltro > Remimensionar - Nome: {foto.Nome}, Tamanho: {foto.TamanhoX}x{foto.TamanhoY}");
        }
    }
}
