using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Lib.Mensageiro
{
    public class Email
    {
        public void Enviar(object sender, VideoEventArgs args)
        {
            Console.WriteLine("Email enviado para o video: " + args.Video.Nome);
        }
    }
}
