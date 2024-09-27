using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalidasStringConcatenadas{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom = "Santiago";
            int ed = 21;

            Console.WriteLine("Nombre: " + nom);
            Console.WriteLine("Edad: " + ed);//primero

            Console.WriteLine("Nombre: "+nom+"\nEdad: "+ ed);//mejor que antes

            Console.WriteLine($"Nombre: {nom} \nEdad: {ed}");//el que mas me gusta
            //el signo de dolar funciona como una forma de permitir a la llamada de objetos
            //es mas facil de entender, y mas limpio que los otros dos anteriores
            Console.WriteLine("Nombre: {0}\nEdad: {1}", nom, ed);//otra forma

            var prueba = string.Concat("Nombre: ",nom, "\nEdad: ", ed);
            //poco uso, aunque puede servir saberlo 

            Console.ReadLine(); 
        }
    }
}