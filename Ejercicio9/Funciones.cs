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

        //public static void menu()

        public static void opciones()
        {
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("Opcion 1. Sumar");
            Console.WriteLine("Opcion 2. Multiplicar");
            Console.WriteLine("Opcion 3. Dividir");
            Console.WriteLine("Opcion 4. Restar");
            Console.WriteLine("Salir");
        }

    }
}
