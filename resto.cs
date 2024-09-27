using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto { 
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 10;
            int g = 3;

            double h = f / g;
            Console.WriteLine(h);
            // solo va a mostrar 3 porque las variables iniciales son enteros(rta real: 3.3333)

            Console.WriteLine(f%g); 
            // esta operacion te permite ver si hay o no una solucion con resto o no en la division.
            // te aparece el numero multiplo mas cercano del divisor para darte el divisible
            Console.ReadLine();
        }
    }
}
