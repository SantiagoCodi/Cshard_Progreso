using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6{ 
    internal class Program
    {
        /*
         * Pregunta a un usuario una contraseña, y guardala
         * Pregunta nuevamente la contraseña y guardala
         * Revisar si ambas tienen algo dentro:
            *Si ambas contienen algo, revisar si ambas continen lo mismo
                *Si ambas son iguales, imprimir "Constraseñas Iguales"
                *Si ambas son no son iguales, imprimir "Constraseñas Desiguales"
            *Si alguna está vacía, imprimir "Por favor, ingrese nuevamente las contraseñas"
         */
        static void Main(string[] args)
        {
            //Mi respuesta:
            string contraseña1;
            string contraseña2;
            bool contraseñas_iguales= false;
            do
            {
                Console.Write("Ingrese una contraseña: ");
                contraseña1 = Console.ReadLine();
                Console.Write("Ingrese la misma contraseña: ");
                contraseña2 = Console.ReadLine();
                if (string.IsNullOrEmpty(contraseña2) || string.IsNullOrEmpty(contraseña1))
                {
                    Console.WriteLine("Por favor, ingrese nuevamente las contraseñas");
                }
                else
                {
                    if (contraseña1 != contraseña2)
                    {
                        Console.WriteLine("Contraseñas Desiguales");
                    }
                    else
                    {
                        Console.WriteLine("Contraseñas Iguales");
                        contraseñas_iguales = true;
                    }
                }
            } while (contraseñas_iguales==false);

            //Mi respuesta mejorada por ChatGPT:

            do
            {
                Console.Write("Ingrese una contraseña: ");
                contraseña1 = Console.ReadLine();

                Console.Write("Ingrese la misma contraseña nuevamente: ");
                contraseña2 = Console.ReadLine();

                if (string.IsNullOrEmpty(contraseña1) || string.IsNullOrEmpty(contraseña2))
                {
                    Console.WriteLine("Por favor, ingrese nuevamente las contraseñas.");
                }
                else if (contraseña1 != contraseña2)
                {
                    Console.WriteLine("Contraseñas Desiguales.");
                }
                else
                {
                    Console.WriteLine("Contraseñas Iguales.");
                    break;  // Sale del ciclo cuando las contraseñas son iguales
                }
            } while (true);
            Console.ReadLine(); 
        }
    }
}