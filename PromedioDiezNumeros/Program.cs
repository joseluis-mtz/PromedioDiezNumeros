using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromedioDiezNumeros
{
    class Program
    {
        public static void guardarCalificacion(ref int calificacion, int valor)
        {
            calificacion += valor;
        }
        static void Main(string[] args)
        {
            int calificacion = 0, promedio = 0, valor = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Escribe la calificación {0}: ", i);
                valor = int.Parse(Console.ReadLine());
                guardarCalificacion(ref calificacion, valor);
            }
            Console.WriteLine("\nEl promedio es: " + (promedio = calificacion / 10));
            Console.ReadKey();
        }
    }
}
