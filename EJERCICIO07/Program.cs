using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO07
{
    internal class Program
    {
        static void MostrarFrecuencias(int[] frecuencia)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Nota " + i + ": "
                    + frecuencia[i] + " veces");
            }
        }
        static int NotaMasRepetida(int[] frecuencia)
        {
            int mayor = frecuencia[0];
            int nota = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (frecuencia[i] > mayor)
                {
                    mayor = frecuencia[i];
                    nota = i;
                }
            }
            return nota;
        }
        static void Main()
        {
            int N;
            Console.Write("Ingrese el número de alumnos: ");
            N = int.Parse(Console.ReadLine());
            int[] notas = new int[N];
            int[] frecuencia = new int[21];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = int.Parse(Console.ReadLine());
                frecuencia[notas[i]]++;
            }
            Console.WriteLine("\nFrecuencia de las notas:");
            MostrarFrecuencias(frecuencia);
            int nota = NotaMasRepetida(frecuencia);
            Console.WriteLine("\nLa nota que más se repitió fue: " + nota);
            Console.WriteLine("Se repitió " + frecuencia[nota] + " veces.");
            Console.ReadKey();
        }
    }
}
