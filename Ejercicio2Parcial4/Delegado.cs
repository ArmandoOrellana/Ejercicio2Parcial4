using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial4Ejercicio2
{

    delegate double Pago(double a);

    class Delegado
    {

        public double Pago(double x)
        {
            if (x <= 10000)
            {

                return x;
            }
            else if (x <= 20000)
            {

                return x - (x * 0.1);
            }
            else if (x <= 50000)
            {
                return x - (x * 0.3);
            }
            else
            {
                return x - (x * 0.5);
            }
        }
    }
}
