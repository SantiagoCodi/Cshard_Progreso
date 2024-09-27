using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFor{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola");
            // for variable y valor incial, rango, que sucede en cada iteracion
            /*    for (int i = 0; i<5; i++) 
            { 
                Console.WriteLine("Hola");
            }
                for (int i =0; i<=10; i+=2) 
            { 
                Console.WriteLine(i);
            }
            */
            Console.Write("¿Qué quieres palabra quieres repetir? ");
            var mensaje= Console.ReadLine();
            Console.Write("¿Cuantas veces quieres que se repita? ");
            var a= Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine(mensaje);
                }
            }
            else
            {
                Console.WriteLine("Solo se aceptan valores mayores a 0");
            }

            Console.ReadLine(); 
        }
    }
}
