using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salidas{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom = "Santiago";
            int ed = 21;

            Console.WriteLine("Nombre: " + nom);
            Console.WriteLine("Edad: " + ed);//primero

            Console.WriteLine();

            Console.WriteLine("Nombre: "+nom+"\nEdad: "+ ed);//mejor que antes

            Console.WriteLine();

            Console.WriteLine($"Nombre: {nom} \nEdad: {ed}");//mejor
            
            Console.WriteLine();

            Console.WriteLine("Nombre: {0}\nEdad: {1}", nom, ed);//otra forma

            Console.ReadLine(); 
        }
    }
}