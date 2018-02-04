using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Eventos.Lib
{
    class VideoEncode
    {
        ////Utilizando os proprios delegates e eventos
        //public delegate void  VideoEncodedHandler(Video video);    
        //public event VideoEncodedHandler Encoded;

        public event EventHandler<VideoEventArgs> Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Convertendo o video...");

            Thread.Sleep(5000);

            Console.WriteLine("Video Convertido!");

            Encoded(this, new VideoEventArgs() { Video = video });
        }


    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
