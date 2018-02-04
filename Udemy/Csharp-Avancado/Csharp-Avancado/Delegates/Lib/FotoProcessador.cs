using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Lib
{
    class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        /// <summary>
        /// propriedade statica que é um delegate
        /// </summary>
        public static FotoFiltroHandler filtros;

        public static void Processar(Foto foto)
        {
            filtros(foto);

            ////recurso tradicional
            //var filtros = new FotoFiltro();
            //filtros.Colorir(foto);
            //filtros.PretoBraco(foto);
            //filtros.GerarThumb(foto);
            //filtros.Remimensionar(foto);

        }
    }
}
