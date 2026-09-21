using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO04
{
    internal class Program
    {
        static double Promedio(double[] notas)
        {
            double suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }
            return suma / notas.Length;
        }
        static double Maxima(double[] notas)
        {
            double maxima = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }
            }
            return maxima;
        }
        static double Minima(double[] notas)
        {
            double minima = notas[0];
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < minima)
                {
                    minima = notas[i];
                }
            }
            return minima;
        }
        static void Main()
        {
            int N;
            Console.Write("Ingrese el número de alumnos: ");
            N = int.Parse(Console.ReadLine());
            double[] notas = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nPromedio de notas: " + Promedio(notas));
            Console.WriteLine("Máxima nota: " + Maxima(notas));
            Console.WriteLine("Mínima nota: " + Minima(notas));
            Console.ReadKey();
        }
    }
}
