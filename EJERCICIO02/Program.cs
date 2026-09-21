using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO02
{
    internal class Program
    {
        static double Promedio(double[] pesos)
        {
            double suma = 0;
            for (int i = 0; i < 10; i++)
            {
                suma = suma + pesos[i];
            }
            return suma / 10;
        }
        static double Mayor(double[] pesos)
        {
            double mayor = pesos[0];
            for (int i = 1; i < 10; i++)
            {
                if (pesos[i] > mayor)
                {
                    mayor = pesos[i];
                }
            }
            return mayor;
        }
        static int Delgados(double[] pesos)
        {
            int cantidad = 0;
            for (int i = 0; i < 10; i++)
            {
                if (pesos[i] < 53)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static int Medianos(double[] pesos)
        {
            int cantidad = 0;
            for (int i = 0; i < 10; i++)
            {
                if (pesos[i] >= 53 && pesos[i] <= 60)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static int Gruesos(double[] pesos)
        {
            int cantidad = 0;
            for (int i = 0; i < 10; i++)
            {
                if (pesos[i] > 60)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static void Main()
        {
            double[] pesos = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el peso del cliente " + (i + 1) + ": ");
                pesos[i] = double.Parse(Console.ReadLine());
            }
            double promedio = Promedio(pesos);
            double mayor = Mayor(pesos);
            Console.WriteLine("\nPeso promedio: " + promedio);
            Console.WriteLine("Peso de la persona que pesa más: " + mayor);
            Console.WriteLine("Personas delgadas: " + Delgados(pesos));
            Console.WriteLine("Personas medianas: " + Medianos(pesos));
            Console.WriteLine("Personas gruesas: " + Gruesos(pesos));
            Console.ReadKey();
        }
    }
}
