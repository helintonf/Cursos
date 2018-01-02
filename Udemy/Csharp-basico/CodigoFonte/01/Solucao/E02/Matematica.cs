using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02
{
    class Matematica
    {

        public static int Expo(int valor, int exp)
        {            
            int result = 1;
            //int i = 1;

            //while ( i <= exp)
            //{
            //    result *= valor;

            //    i += 1;
            //}

            for(int it = 1; it <= exp; it++)
            {
                result *= valor;
            }

            return result;
        }
    }
}
