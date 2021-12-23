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

            #region Código alternativo NO RECOMENDADO (Comentar el código anterior para usar este)
            //int calif1 = 0;
            //int calif2 = 0;
            //int calif3 = 0;
            //int calif4 = 0;
            //int calif5 = 0;
            //int calif6 = 0;
            //int calif7 = 0;
            //int calif8 = 0;
            //int calif9 = 0;
            //int calif10 = 0;
            //int Promedio = 0;
            //int suma = 0;

            //Console.Write("Escribe la calificación 1: ");
            //calif1 = int.Parse(Console.ReadLine());

            //Console.Write("Escribe la calificación 2: ");
            //calif2 = int.Parse(Console.ReadLine());

            //Console.Write("Escribe la calificación 3: ");
            //calif3 = int.Parse(Console.ReadLine());

            //Console.Write("Escribe la calificación 4: ");
            //calif4 = int.Parse(Console.ReadLine());

            //Console.Write("Escribe la calificación 5: ");
            //calif5 = int.Parse(Console.ReadLine());

            //Console.Write("Escribe la calificación 6: ");
            //calif6 = int.Parse(Console.ReadLine());

            //Console.Write("Escribe la calificación 7: ");
            //calif7 = int.Parse(Console.ReadLine());

            //Console.Write("Escribe la calificación 8: ");
            //calif8 = int.Parse(Console.ReadLine());

            //Console.Write("Escribe la calificación 9: ");
            //calif9 = int.Parse(Console.ReadLine());

            //Console.Write("Escribe la calificación 10: ");
            //calif10 = int.Parse(Console.ReadLine());

            //suma = calif1 + calif2 + calif3 + calif4 + calif5 + calif6 + calif7 + calif8 + calif9 + calif10;
            //Promedio = suma / 10;

            //Console.WriteLine();
            //Console.WriteLine("El promedio es: " + Promedio);
            //Console.ReadKey();
            #endregion
        }
    }
}
