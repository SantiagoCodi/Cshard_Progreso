using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constantes{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vata = 20;
            int balance = 1000;
            //Las variables pueden cambiar, pero si necesitas que no cambie se puede hacer
            double resultadoprocentaje = (vata)/100D;
            Console.WriteLine(resultadoprocentaje);
            Console.WriteLine( balance *  (vata / 100D ));
            //no solo sirve para numeros, si necesitas que no cambie algo como version o datos
            const string version = "v1.2";
            Console.WriteLine(version);
            const string nomCreador = "FreeCodeCamp.org";
            Console.WriteLine(nomCreador);
            Console.ReadLine();
        }
    }
}