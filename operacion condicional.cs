using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorCondicional{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int ed = 10;
            /*
            if (ed >=0)
            {
                Console.WriteLine("valido");
            }
            else
            {
                
                Console.WriteLine("invalido");
                
            }
            //Demasiado largo toma mucho tiempo, pero ahora esto se puede cambiar con
            */
            // variable = condicion ? caso true : caso false
            string resultado = ed >= 0 ? "valido" : "invalido";
            //es mejor guardarlo en una variable, pero se puede hacer
            //Console.WriteLine(ed >= 0 ? "valido" : "invalido";);
            Console.WriteLine(resultado);
            Console.ReadLine(); 
        }
    }
}
