using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Funciones
    {
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

        public static void opciones()
        {
            Console.WriteLine("1 - sumar");
            Console.WriteLine("2 - restar");
            Console.WriteLine("3 - multimplicar");
            Console.WriteLine("4 - dividir");
            Console.WrietLine("0 - salir");

        }
       
    }
}
