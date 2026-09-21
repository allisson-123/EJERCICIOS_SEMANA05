using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO05
{
    internal class Program
    {
        static int Cantidad00(double[] notas)
        {
            int cantidad = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == 0)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static int Cantidad20(double[] notas)
        {
            int cantidad = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == 20)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static int Aprobados(double[] notas)
        {
            int cantidad = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 13)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static int Desaprobados(double[] notas)
        {
            int cantidad = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 13)
                {
                    cantidad++;
                }
            }
            return cantidad;
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
            Console.WriteLine("\nCantidad de alumnos con 00: " + Cantidad00(notas));
            Console.WriteLine("Cantidad de alumnos con 20: " + Cantidad20(notas));
            Console.WriteLine("Cantidad de aprobados: " + Aprobados(notas));
            Console.WriteLine("Cantidad de desaprobados: " + Desaprobados(notas));
            Console.ReadKey();
        }
    }
}
