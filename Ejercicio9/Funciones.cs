using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Funciones
    {
        // public static int sumar(int a, int b)
        public static int multiplicar(int a, int b)
        {
            return a * b;
        }

        // public static int dividir(int a, int b)
        public static int restar(int a, int b)
        {
            return a - b;
        }

        public static void menu()
        {
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Multiplicar");
            Console.WriteLine("3. Dividir");
            Console.WriteLine("4. Restar");
        }
       
    }
}
