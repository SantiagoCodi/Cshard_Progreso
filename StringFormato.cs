using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formato{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            double v = 1000D / 12.34D;
            
            Console.WriteLine(v);
            //esto da un numero con demasiados decimales que normalmente no interesan

            //mejor si es algo visual como probabilidad sería algo como

            // definis string.FuncionFormato{"{valor(0):como se verá el valor}(0/#) + , variable, variable2"}
            Console.WriteLine(string.Format("{0:0} ", v));
            Console.WriteLine(string.Format("{0:0.0} ", v));
            Console.WriteLine(string.Format("{0:0.00} ", v));
            //Se ve mucho mas limpio, aunque debido al redondeo puede afectar negativamente
            //Aunque no afecta al valor de la variable, AFECTA en factor humano

            double mon = 10D / 3D; 

            Console.WriteLine(mon);
            Console.WriteLine(string.Format("{0:0.00}", mon));
            Console.WriteLine(mon.ToString("C",
                CultureInfo.CurrentCulture));
            //Debería detectar mi moneda, aunque no funciona porque no tengo el caracter de libras
            Console.WriteLine(mon.ToString("C1"));//Es más rapido que string format, pero
            Console.WriteLine(mon.ToString("C2"));//string format tambien puede ser util

            Console.WriteLine(mon.ToString("C",
                CultureInfo.CreateSpecificCulture("en-US")));
            //parece que arg no tiene moneda en mi sistema, pero si se puede elegir cualquier otra
            //aunque se debe hacer manualmente
            Console.WriteLine(mon.ToString("C",
                CultureInfo.CreateSpecificCulture("en-BG")));
            // Parece que la libra no se puede utilizar en mi maquina
            Console.WriteLine(mon.ToString("C",
                CultureInfo.CreateSpecificCulture("en-AU"))); 
            
            
            Console.ReadLine(); 
        }
    }
}
