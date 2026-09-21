using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO01
{
    internal class Program
    {
        static double Menor(double[] notas)
        {
            double menor = notas[0];
            for (int i = 1; i < 6; i++)
            {
                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }
            return menor;
        }
        static double Promedio(double[] notas, double menor)
        {
            double suma = 0;
            for (int i = 0; i < 6; i++)
            {
                suma = suma + notas[i];
            }
            suma = suma - menor;
            return suma / 5;
        }
        static void Main()
        {
            double[] notas = new double[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese la nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }
            double menor = Menor(notas);
            double promedio = Promedio(notas, menor);
            Console.WriteLine("\nMenor nota eliminada: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
