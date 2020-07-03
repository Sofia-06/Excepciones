using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_Operaciones
{
    class Program
    {
        static int a = 0, b = 0;
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Bienvenido, seleccione la opción que desee: ");
                Console.WriteLine(" 1. Suma: ");
                Console.WriteLine(" 2. Resta: ");
                Console.WriteLine(" 3. Multiplicación: ");
                Console.WriteLine(" 4. División: ");
                Console.WriteLine(" 5. Salir");
                Console.WriteLine("Ingrese la opción deseada:");
                num = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (num == 1)
                {
                    try
                    {
                        Console.Write("Ingrese un valor a : ");
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dato no válido ");
                        Console.Write("Ingrese un valor a : ");
                        a = int.Parse(Console.ReadLine());
                    }
                    try
                    {
                        Console.Write("Ingrese un valor b : ");
                        b = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dato no válido ");
                        Console.Write("Ingrese un valor b : ");
                        b = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("La Suma es: " + (a + b));
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (num==2)
                {
                    try
                    {
                        Console.Write("Ingrese un valor a : ");
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dato no válido ");
                        Console.Write("ingrese un valor a : ");
                        a = int.Parse(Console.ReadLine());
                    }
                    try
                    {
                        Console.Write("Ingrese un valor b : ");
                        b = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dato no válido ");
                        Console.Write("Ingrese un valor b : ");
                        b = int.Parse(Console.ReadLine());
                    }
                    num = 1;
                    Console.WriteLine("La Resta es: " + (a - b));
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (num==3)
                {
                    try
                    {
                        Console.Write("Ingrese un valor a : ");
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dato no válido ");
                        Console.Write("Ingrese un valor a : ");
                        a = int.Parse(Console.ReadLine());
                    }
                    try
                    {
                        Console.Write("Ingrese un valor b : ");
                        b = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dato no válido ");
                        Console.Write("Ingrese un valor b : ");
                        b = int.Parse(Console.ReadLine());
                    }
                    num = 1;
                    Console.WriteLine("La Multiplicación es: " + (a * b));
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (num==4)
                {
                    try
                    {
                        Console.Write("Ingrese un valor a : ");
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dato no válido ");
                        Console.Write("Ingrese un valor a : ");
                        a = int.Parse(Console.ReadLine());
                    }
                    try
                    {
                        Console.Write("Ingrese un valor a : ");
                        b = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dato no válido ");
                        Console.Write("Ingrese un valor a : ");
                        b = int.Parse(Console.ReadLine());
                    }
                    num = 1;
                    Console.WriteLine("La División es: " + (a / b));
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (num == 5)
                {
                    Environment.Exit(0);
                }
            } while (num == 1);
            Console.ReadKey();
        }
    }
}
