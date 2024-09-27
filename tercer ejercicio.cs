using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3{ 
    internal class Program
    {
        /*
         pedirle al usuario un número para la tabla
         escribir un bucle for para imprimir la tabla de multiplicación de X
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero y se mostrará la table de dicho numero.");
            Console.Write("Ingrese el numero a usar: ");
            var inp = Console.ReadLine();
            var t = 0;
            var suceso = false;
            
            //Con solo un if, el ejercicio funciona perfectamente, pero se puede mejorar con un while
            do {
                if (int.TryParse(inp, out t))
                {
                    suceso = true;
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{t}x{i}= " + t * i);
                    }
                }
                else
                {
                    Console.WriteLine("Error al ingresar el numero, pruebe nuevamente");
                    Console.Write("Ingrese un nuevo numero: ");
                    inp = Console.ReadLine();
                }
            } while (suceso == false);
            //Con ChatGPT, el ejercicio me lo mejoró a: 
            int t2;
            bool esNumeroValido;
            do
            {
                Console.WriteLine("Ingrese un número para mostrar la tabla de multiplicación.");
                Console.Write("Número: ");
                string input = Console.ReadLine();

                esNumeroValido = int.TryParse(input, out t2);

                if (!esNumeroValido)
                {
                    Console.WriteLine("Error: por favor, ingrese un número válido.");
                }

            } while (!esNumeroValido);

            Console.WriteLine($"\nTabla de multiplicar del {t2}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{t2} x {i} = {t2 * i}");
            }
            //Lo veo mejor organizado, pero son casi la misma cantidad de lineas de codigo
            Console.ReadLine(); 
        }
    }
}