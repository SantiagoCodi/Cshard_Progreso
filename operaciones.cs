using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones { 
    internal class Program
    {
        static void Main(string[] args)
        {

            int edad = 23;
            Console.WriteLine(edad);
            edad++;
            // +1
            Console.WriteLine(edad);
            edad += 12;
            // elegir cuanto sumar
            Console.WriteLine(edad);

            string nom = "San";
            nom += "está aprendiendo";
            // agregar texto, aunque no se puede quitar despues a menos que hagas una nueva definicion
            Console.WriteLine(nom);

            Console.ReadLine();
        }
    }
}
