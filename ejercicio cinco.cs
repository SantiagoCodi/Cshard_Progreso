using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5{ 
    internal class Program
    {
        /*
         Pregunta al usuario de ingresar un mensaje
         Que se imprima en orden
         Que se imprima en reversa
         */
        static void Main(string[] args)
        {
            //Mi respuesta:
            string mensaje;
            int largo_mensaje;
            Console.Write("Ingrese un mensaje: ");
            mensaje = Console.ReadLine();
            Console.Write("El mensaje es: ");
            Console.WriteLine(mensaje);
            largo_mensaje = mensaje.Length;
            Console.Write("El mensaje al reves es: ");
            for (int i = 0; i < mensaje.Length; i++)//hola son 4, pero los arreglos son 0-3
            {
                Console.Write(mensaje[largo_mensaje-i-1]);
                /*
                El largo del mensaje los cuenta de 1 al maximo de caracteres
                El problema es que eso deja de lado el primer caracter ya que los 
                arreglos empiezan por 0 a maximo
                Asi que deben ser reducidos menos 1 ya que no hay suficientes caracteres 
                y da error en el largo.
                 */
            }
            Console.WriteLine();
            //Respuesta mejorada luego de ver la respuesta del curso:

            Console.Write("Ingrese un mensaje: ");
            mensaje = Console.ReadLine();
            Console.Write($"El mensaje es: {mensaje}");
            Console.Write("El mensaje al reves es: ");
            for (int i = mensaje.Length-1; i >=0 ; i--)
            {
                Console.Write(mensaje[i]);            
            }

            Console.WriteLine();
            
            //Respuesta mejorada por chatgpt
            Console.Write("Ingrese un mensaje: ");
            mensaje = Console.ReadLine();

            // Imprime el mensaje original
            Console.WriteLine("El mensaje es: " + mensaje);

            // Imprime el mensaje en reversa utilizando LINQ
            string mensajeReverso = new string(mensaje.Reverse().ToArray());
            Console.WriteLine("El mensaje al revés es: " + mensajeReverso);

            // Espera la entrada del usuario para terminar

            //Mi mejora al resultado de ChatGPT:
            Console.Write("Ingrese un mensaje: ");
            mensaje = Console.ReadLine();

            // Imprime el mensaje original
            Console.WriteLine($"El mensaje es: {mensaje}");//Más prolijo y mas comodo de lectura

            // Imprime el mensaje en reversa utilizando LINQ
            mensajeReverso = new string(mensaje.Reverse().ToArray());
            Console.WriteLine($"El mensaje al revés es: {mensajeReverso}" );
            //Igual que el anterior punto
            Console.ReadLine(); 
        }
    }
}