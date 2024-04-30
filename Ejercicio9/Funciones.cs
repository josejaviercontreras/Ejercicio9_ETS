using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Funciones
    {
<<<<<<< HEAD
         public static int sumar(int a, int b) => a + b;
        // public static int multiplicar(int a, int b)
         public static int dividir(int a, int b) => a / b;
        // public static int restar(int a, int b)
         public static void menu()
        {
            int num, a, b;

            opciones();

            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Inserte un numero");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserte un numero");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a+" + "+b+" = "+sumar(a,b));
                        break;
                    case 2:
                        Console.WriteLine("Inserte un numero");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserte un numero");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a + " - " + b + " = " + restar(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Inserte un numero");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserte un numero");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a + " x " + b + " = " + multiplicar(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Inserte un numero");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserte un numero");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a + " / " + b + " = " + dividir(a, b));
                        break;
                }
                opciones();
                num = Convert.ToInt32(Console.ReadLine());

            }
        }

=======
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
>>>>>>> Git-C#

    }
}
