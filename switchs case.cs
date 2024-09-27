using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el n° del día de la semana y te devuelve el nombre: ");
            var dia = Convert.ToInt32(Console.ReadLine());
            //Se puede usar 7 if o empezar a usar switch el cual ayuda a no usar tanto el else if
            switch (dia) 
            {
                case 1://caso "valor" y luego codigo, se necesita el break
                    Console.WriteLine("Es Lunes");
                    break;
                case 2://Si no se agrega break, es lo mismo que un condicional or hasta el break
                    Console.WriteLine("Es Martes");
                    break;
                case 3:
                    Console.WriteLine("Es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Es Jueves");
                    break;
                case 5:
                    Console.WriteLine("Es Viernes");
                    break;
                case 6:
                    Console.WriteLine("Es Sabado");
                    break;
                case 7:
                    Console.WriteLine("Es Domingo");
                    break;
                default://Si no se cumple ninguna de las anteriores, pasa por default
                    Console.WriteLine("No es un numero de la semana! Ingrese un valor entre 1 y 7");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}
