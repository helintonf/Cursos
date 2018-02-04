using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace TaskAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
            //Task - Asunchrono (Thread)
            string url = txtSite.Text;

            WebClient web = new WebClient(); //baixar qualquer coisa da internet

            //string html = web.DownloadString(url);

             string html = await web.DownloadStringTaskAsync(new Uri(url));



            txtResult.Text = html;
        }

    }
}
