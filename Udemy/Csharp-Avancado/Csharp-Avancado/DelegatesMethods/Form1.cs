using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //btnCLick.Click += delegate (object sender, EventArgs e) {
            btnCLick.Click += delegate {
                MessageBox.Show("Ola Tudo bem");
            };

            btnCLick.Click += Metodo1;
            btnCLick.Click += Metodo2;
        }

        //private void Metodo1(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Metodo1");

        }

        private void Metodo2(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Metodo2");
        }
    }
}
