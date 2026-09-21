using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO03
{
    internal class Program
    {
        static void GenerarEdades(int[] edades)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < edades.Length; i++)
            {
                edades[i] = aleatorio.Next(1, 101);
            }
        }
        static void Mostrar(int[] edades)
        {
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Posición " + i + ": " + edades[i]);
            }
        }
        static int Menor(int[] edades)
        {
            int menor = edades[0];
            for (int i = 1; i < edades.Length; i++)
            {
                if (edades[i] < menor)
                {
                    menor = edades[i];
                }
            }
            return menor;
        }
        static int PosicionMenor(int[] edades)
        {
            int posicion = 0;
            for (int i = 1; i < edades.Length; i++)
            {
                if (edades[i] < edades[posicion])
                {
                    posicion = i;
                }
            }
            return posicion;
        }
        static int Entre30y50(int[] edades)
        {
            int cantidad = 0;

            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] >= 30 && edades[i] <= 50)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        static bool Buscar(int[] edades, int edad)
        {
            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] == edad)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main()
        {
            int N;
            Console.Write("Ingrese el número de personas: ");
            N = int.Parse(Console.ReadLine());
            int[] edades = new int[N];
            GenerarEdades(edades);
            Console.WriteLine("\nEdades generadas:");
            Mostrar(edades);
            Console.WriteLine("\nMenor edad: " + Menor(edades));
            Console.WriteLine("Posición de la menor edad: " + PosicionMenor(edades));
            Console.WriteLine("Personas entre 30 y 50 años: " + Entre30y50(edades));
            Console.Write("\nIngrese una edad a buscar: ");
            int edad = int.Parse(Console.ReadLine());
            if (Buscar(edades, edad))
            {
                Console.WriteLine("La edad se encuentra en el arreglo.");
            }
            else
            {
                Console.WriteLine("La edad no se encuentra en el arreglo.");
            }
            Console.ReadKey();
        }
    }
}
