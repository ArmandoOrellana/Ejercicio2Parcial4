using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial4Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegado dlg = new Parcial4Ejercicio2.Delegado();
            Console.WriteLine("Resultado");
            Console.WriteLine("Digite la cantidad el monto a comprar");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total a pagar es de:");
            Console.WriteLine(dlg.Pago(a));
            Console.ReadKey();

        }
    }
}
