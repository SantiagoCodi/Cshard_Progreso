
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInput{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar un nombre: ");
            //Con solo Write te permite seguir en la misma linea
            string nom = Console.ReadLine(); //Se guarda dentro del tipeo que realices
            Console.Write("¿Cual es tu edad? ");
            string edainput= Console.ReadLine();
            //Esto no es bueno, ya que lo guarda como un string y debe ser un numero, para
            //que se convierta se debe hacer:
            int eda = Convert.ToInt32(edainput);
            //Esto se puede acortar con:
            int edad = Convert.ToInt32(Console.Read());
            //Convierte todo directamente en una sola linea de texto, parece complejo 
            //no lo es, solo hay que entender que se requiere cierta funcion para la conversión
            Console.WriteLine();
            Console.WriteLine($"Gracias {nom}, por decirnos que tu edad es {edad}");
            // con $ antes de "" se puede agregar variables dentro de las {}
            
            Console.ReadLine(); 


        }
    }
}
