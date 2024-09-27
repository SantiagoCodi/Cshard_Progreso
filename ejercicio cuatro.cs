using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4{ 
    internal class Program
    {
        /*  Crear un bucle for de 1 a X(15)
            Si el número es divisible entre 3, imprime "Fizz".
            Si el número es divisible entre 5, imprime "Buzz".
            Si el número es divisible entre ambos (3 y 5), imprime "FizzBuzz".
            Si no es divisible entre ninguno, imprime el número.     
         */
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 15; i++) 
            { 
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if (i % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine(i);
                }                
            }
            esto se puede mejorar levemente para mejor lectura
            */
            bool DivTres;
            bool DivCinco;
            for (int i = 1; i <= 15; i++)
            {
                DivTres = i % 3 == 0;
                DivCinco = i % 5 == 0;
                if (DivTres && DivCinco)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (DivTres)
                {
                    Console.WriteLine("Fizz");
                }
                else if (DivCinco)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine(); 
        }
    }
}