using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerejercicio{ 
    internal class Program
    {
        /*
        Definir una variable para tu nombre
        Definir una variable para un numero de telefono
        Definir una variable para tu edad
        Imprime la todas las variables en consola
        Agregar dos variables con var keyword
        */
        static void Main(string[] args)
        {
            var name = "Santiago";
            var numer = "03416904025"; 
            var age = 21;
            Console.Write("Mi nombre es "+ name + ". Mi telefono es " + numer + ". Mentí, pero mi edad es " + age);

            Console.ReadLine();
        }
    }
}
