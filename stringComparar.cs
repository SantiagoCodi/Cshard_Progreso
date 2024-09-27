using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsCompararFunciones{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom = "Hola";
            string nombre = "Hola";

            if (nom.Equals(nombre))//Funcion para saber si son iguales
            {
                Console.WriteLine("Si");
            }
            else
            {
                Console.WriteLine("No");
            }
            //Equals funciona bien con comparar diferentes tipos de datos mientras sean igual
            //Mejorar
            Console.ReadLine(); 
        }
    }
}