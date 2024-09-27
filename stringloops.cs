using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLoop{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string m = "c# es una herramienta";
            //Console.WriteLine(m);
            //Un string es un array de caracteres, asi que si quieramos podria sucedecer algo como:
           // Console.WriteLine(m[0]);//solo muestra el primer caracter del string

            //Ahora se puede hacer algo, usando el bucle for

            for (int i = 0; i < m.Length; i++) //interesante para mostrar mensajes
            {
                Console.Write(m[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine();
            for (int i = 0; i < m.Length; i++) 
            {
                if (m[i] == 'C' || m[i]=='c')
                {
                    Console.WriteLine(true);
                }
            }

            Console.ReadLine(); 
        }
    }
}