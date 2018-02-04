using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eventos.Lib;
using Eventos.Lib.Mensageiro;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
            btnVideoEncode.Click += EventoCLick;
        }

        public void EventoCLick(object sender, EventArgs e)
        {
            Video video = new Video() { Nome = "Olavo Tem Razão.mp4" };

            VideoEncode videoEncode = new VideoEncode();

            videoEncode.Encoded += new Email().Enviar;
            videoEncode.Encoded += new SMS().Enviar;

            videoEncode.Encode(video);
        }
    }
}
