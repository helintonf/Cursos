using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga
{
    class Pessoa
    {
        public int Andar()
        {
            return 1;
        }

        public int Andar(int lvl)
        {
            return Andar() * lvl;
        }

        public int Andar(string txt)
        {
            return Andar(int.Parse(txt));
        }










        public int Correr()
        {
            return Andar() * 2;
        }
        public int Pedalar()
        {
            return Andar() * 4;
        }
    }
}
