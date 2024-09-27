using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                for (int i = 0; i < 10; i++) //Vos sabes cuantas veces necesitas iterar
            { 
                Console.WriteLine(i);
            }
            var i = 0;
            while (i<10) 
            {
                i++;
                Console.WriteLine(i);
            }

            */
            //con el while permite iterar hasta que algo sea falso
            Console.Write("Ingrese un numero: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            var resultado = num1 * num2;
            Console.Write($"¿Cual es resultado de la multiplicacion entre {num1} y {num2}?");
            Console.WriteLine();
            /*
            var i = 0;
            while (i == 0)
            {
                Console.Write("Tu respuesta es: ");
                var pres = Convert.ToInt32(Console.ReadLine());

                if (pres == resultado)
                {
                    i++;
                    Console.WriteLine("Correcto!");
                }
                else
                {
                    Console.WriteLine("Incorrecto, prueba otra vez!");
                    Console.WriteLine();
                }             
            }
            */
            // Si se desea que el codigo se realice una vez y evitar el crear una varibale extra
            // podemos usar el do while, una funcion que realiza una accion obligatoriamente
            // y luego si la condicion del bucle se converita en falsa la declaracion
            var pres = 0;
            do
            {
                Console.Write("Tu respuesta es: ");
                pres = Convert.ToInt32(Console.ReadLine());

                if (pres == resultado)
                {
                    Console.WriteLine("Correcto!");
                }
                else
                {
                    Console.WriteLine("Incorrecto, prueba otra vez!");
                    Console.WriteLine();
                }
            } while (resultado != pres);

            Console.ReadLine(); 
        }
    }
}
