using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO08
{
    internal class Program
    {
        static int SUMADIG(int numero)
        {
            int suma = 0;

            while (numero > 0)
            {
                suma = suma + numero % 10;
                numero = numero / 10;
            }
            return suma;
        }
        static bool EsDivisible(int numero)
        {
            int suma = SUMADIG(numero);

            if (suma % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void GenerarNumeros(int[] numeros)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = aleatorio.Next(1, 200);
            }
        }
        static void Mostrar(int[] numeros)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numeros[i] + " ");
            }
        }
        static void Main()
        {
            int cantidad = 0;
            int[] numeros = new int[10];
            GenerarNumeros(numeros);
            Console.WriteLine("Números generados:");
            Mostrar(numeros);
            for (int i = 0; i < 10; i++)
            {
                if (EsDivisible(numeros[i]))
                {
                    cantidad++;
                }
            }
            Console.WriteLine("\n\nCantidad de números divisibles entre 3: " + cantidad);
            Console.ReadKey();
        }
    }
}
