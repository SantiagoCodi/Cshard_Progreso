using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoEjercicio{ 
    internal class Program
    {
        /*
        Crear e inicializar dos ints
        crear una variable para resto
        mostrar el resto en consola
        cambiar una de las varibales en otro numeros y con ello:
            + recalcular el resto
            + mostrar el nuevo resto
        */
        static void Main(string[] args)
        {
            var x = 10D;
            var t = 3D;
            Console.WriteLine("El primer numero es " + x + " y el segundo es " + t);
            Console.WriteLine("El resto entre las variables la primera vez es "+ (x % t));
            x = 9D;
            Console.WriteLine("El primer numero es "+x+" y el segundo es " + t);
            Console.WriteLine("El resto entre las variables la segunda vez es " + (x % t));

            Console.ReadLine(); 
        }
    }
}
