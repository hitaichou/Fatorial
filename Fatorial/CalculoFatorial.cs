using System;
using System.Collections.Generic;
using System.Text;

namespace Fatorial
{
    class CalculoFatorial
    {
        public int fatorial = 1;
        public int contador;

        public int ContadorFatorial(int cf)
        {
            contador = cf;
            for (int i = 0; i < cf; i++)
            {
                if (contador != 0)
                {
                    fatorial = fatorial * contador;
                    contador--;
                }
                else
                {
                    fatorial = 1;
                }
            }
            return fatorial;

        }
    }
}
