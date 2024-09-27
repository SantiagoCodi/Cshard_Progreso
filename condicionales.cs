using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("¿Cual es tu edad? ");
            int edad = Convert.ToInt32(Console.ReadLine());
            // ==, <=, <, >=, >, !=, ||'or' &&'and' Diferentes condicionales
            if (edad < 0 || edad > 140)// uno solo tiene que ser verdad
            {
                Console.WriteLine("Edad Invalida");
            }
            else if (edad >=18 && edad <37) //ambos tienen que ser verdad
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else if ( edad >= 37 )// debe cumplir la condicion
            {
                Console.WriteLine("Eres mayor a 36, felicidades");
            }
            else if(edad < 18)
            {
                Console.WriteLine("Eres menor de edad");
            }*/
            // con $ antes de "" se puede agregar variables dentro de las {}

            Console.Write("Ingrese un numero: "); 
            var num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro numero: "); 
            var num2= Convert.ToInt32(Console.ReadLine());

            var resultado = num1*num2;
            Console.Write($"El resultado de la multiplicacion entre {num1} y {num2} es: ");
           
            var pres = Convert.ToInt32(Console.ReadLine());

            if (pres == resultado)
            {
                Console.WriteLine("Correcto");
            }
            else 
            {
                Console.WriteLine("Incorrecto");
            }

            Console.ReadLine(); 
        }
    }
}
