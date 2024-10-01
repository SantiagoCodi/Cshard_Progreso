using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isnulloremptyFuncion{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            /*Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine();



            if (!string.IsNullOrEmpty(nombre))
                //Funcion de string, que permite revisar si se lleno o si no hay nada dentro
            {
                Console.WriteLine($"Tu nombre es {nombre}");
            }
            else
            {
                Console.WriteLine("No ha ingresado ningun nombre");
            }
            */
            
            //Mejora:

            do
            {
                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                if (!string.IsNullOrEmpty(nombre))
                //Funcion de string, que permite revisar si se lleno o si no hay nada dentro
                {
                    Console.WriteLine($"Tu nombre es {nombre}");
                }
                else
                {
                    Console.WriteLine("No ha ingresado ningun nombre, pruebe de nuevo");
                    Console.WriteLine();
                }
            } while (string.IsNullOrEmpty(nombre));

                Console.ReadLine(); 
        }
    }
}