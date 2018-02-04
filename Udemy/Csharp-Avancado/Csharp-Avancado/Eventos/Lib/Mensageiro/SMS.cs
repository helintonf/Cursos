using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Lib.Mensageiro
{
    public class SMS
    {
        public void Enviar(object sender, VideoEventArgs args)
        {
            Console.WriteLine("SMS enviado para o video: " + args.Video.Nome);
        }
    }
}
