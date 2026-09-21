using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO06
{
    internal class Program
    {
        static void GenerarMontos(int[] montos)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < montos.Length; i++)
            {
                montos[i] = aleatorio.Next(25, 501);
            }
        }
        static void Mostrar(int[] montos)
        {
            for (int i = 0; i < montos.Length; i++)
            {
                Console.Write(montos[i] + " ");
            }
        }
        static void Ordenar(int[] montos)
        {
            for (int i = 0; i < montos.Length - 1; i++)
            {
                for (int j = i + 1; j < montos.Length; j++)
                {
                    if (montos[i] > montos[j])
                    {
                        int aux = montos[i];
                        montos[i] = montos[j];
                        montos[j] = aux;
                    }
                }
            }
        }
        static int Entre100y300(int[] montos)
        {
            int cantidad = 0;
            for (int i = 0; i < montos.Length; i++)
            {
                if (montos[i] >= 100 && montos[i] <= 300)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static int Impares(int[] montos)
        {
            int cantidad = 0;

            for (int i = 0; i < montos.Length; i++)
            {
                if (montos[i] % 2 != 0)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static void Main()
        {
            int N;
            Console.Write("Ingrese el número de personas: ");
            N = int.Parse(Console.ReadLine());
            int[] montos = new int[N];
            GenerarMontos(montos);
            Console.WriteLine("\nMontos generados:");
            Mostrar(montos);
            Console.WriteLine("\n\nMontos ordenados:");
            Ordenar(montos);
            Mostrar(montos);
            Console.WriteLine("\n\nPersonas que gastaron entre 100 y 300 soles: " + Entre100y300(montos));
            Console.WriteLine("Cantidad de montos impares: " + Impares(montos));
            Console.ReadKey();
        }
    }
}
