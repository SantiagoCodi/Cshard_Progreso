using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionIntentar{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Ingrese un numero: ");
            //var num = 0; //Ahora solo hay que definir la variable
            //si se necesita almacenar el valor por caso de falla hacemos
            //var inp= Console.ReadLine();
            // Convert.ToInt32(Console.ReadLine());(lo que antes usaba)
            //si hay un error, por ejemplo poner una letra en un ingreso de un numero, se rompe el 
            //programa causando que se pierda informacion que puede ser importante.
            //para cambiar eso, se usa
            //tipo de variable, try(Leer la consola)
            //int.TryParse(inp, out num); //si no funciona, da 0

            //transforma el string del ReadLine a int
            //Si no se necesita el valor almacenado, se puede hacer:
            //int.TryParse(Console.ReadLine(), out num);



            //bool success = int.TryParse(inp, out num);
            //Con esto, podemos saber por ejemplo si se añade un 0 o un error por ejemplo
            /*if (success) //al ser un booleano, se pasa automaticamente a verdadero o falso
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("No se pudo convertir el numero");
            }
           */
            //Incluso, de ser necesesario, se puede realizar un bucle hasta que funcione
            bool success = false;
            var num = 0;
            var inp = "";
            Console.Write("Ingrese un numero: ");
            inp = Console.ReadLine();
            do
            {
                /*
                success = int.TryParse(inp, out num);
                if (success) 
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("No se pudo convertir el numero, prueba nuevamente.");
                    Console.Write("Ingrese el numero: ");
                    inp = Console.ReadLine();
                }
                //esto se puede mejorar aun más, ya que si tryparse es el if, se mueve como debe

                */
                if (int.TryParse(inp, out num))
                { 
                    success = true;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("No se pudo convertir el numero, prueba nuevamente.");
                    Console.Write("Ingrese el numero: ");
                    inp = Console.ReadLine();
                }
            } while (success==false);
            //Console.WriteLine(num);

            Console.ReadLine(); 
        }
    }
}
