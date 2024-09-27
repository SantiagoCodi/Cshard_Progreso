using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salidas{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //se requieren 2 \ uno para definir que lo siquiente funcione bien
            string comidob = "\"Normalmenete\" usar comillas dobles no es posible, pero asi se pueden usar";
            string path = "C:\\Users\\Santiago\\Desktop\\ITI\\2do año\\C# Curso";
            Console.WriteLine(comidob);
            Console.WriteLine(path);
            //esto se puede mejorar con:
            //reasigno el valor de path
            path = @"C:\Users\Santiago\Desktop\ITI\2do año\C# Curso";
            //esto es mejor cuando no necesitas hacer comandos, pero debido a que toma todo literal
            //puede afectar a momentos como si necesitase el "\n" o el "\t" por ejemplo 
            path = @"C:\Users\Santiago\Desktop\ITI\2do año\C# Curso\n";//pero
            path = @"C:\Users\Santiago\Desktop\ITI\2do año\C# Curso"+ "\n Nueva linea";
            // \n es más popular ya que evita usar muchos Console.WriteLine si es solo por texto
            comidob = @"Pero con ahora ""comida deliciosa""";
            //el literal aun acepecta otros ingresos como ""de cada lado para entender una sola
            //aunque pierde utilidad normalmente
            Console.WriteLine(path);
            Console.WriteLine(comidob);
            //ultima cosa, el uso de '' comillas simples no afecta dentro de los strings
            //el compilador no reacciona a ellas como con las comillas dobles por su definicion


            Console.ReadLine(); 
        }
    }
}