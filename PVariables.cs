using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // visual de declarar variables
            //int x = 10;
            // practica forma de declarar variables
            int x = 10,
                y = 20,
                z = 30;
            //si se pasa del tamaño se puede ver mejor con ENTER

            int age = 23 ;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            long bigNumber = 9000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double neg= -55.22D;
            Console.WriteLine(neg); 
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float pres = 5.0001F;
            Console.WriteLine(pres);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal mon = 11.99M;
            Console.WriteLine(mon);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.ReadLine();
        }
    }
}