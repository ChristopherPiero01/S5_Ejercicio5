using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Ingrese el número límite: ");
            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine("Escoje una opción: ");
            Console.WriteLine("1) Números pares ");
            Console.WriteLine("2) Números impares");
            Console.WriteLine("3) Factorial");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= limite; i++)
            {
                if  (num == 1 &&  i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                if ( num == 2 && i % 2 == 1)
                {
                    Console.Write(i + ", ");
                }
                if (num == 3)
                {
                    fact = fact * i;
                }
            }
            Console.WriteLine("El factorial es " + fact);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
