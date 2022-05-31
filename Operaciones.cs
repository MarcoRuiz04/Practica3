using System;

namespace Practica3
{
    internal class Operaciones
    {

        
        internal double Calcular(int n1, int n2, int op)
        {
            switch (op)
            {
                case 1:
                    return n1 * n2;
                case 2:
                    return n1 * n2;
                case 3:
                    return n1 * n2 / 2;
                default:
                    return n2 == 0 ? 0 : (double)n1 / n2;
            }
        }


        internal double CalcularRadio(int n1)
        {
            return Math.PI * Math.Pow(n1, 2);
        }
        }


}