using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminarSiEsPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un número entero positivo");
            int num = Convert.ToInt32(Console.ReadLine());


            int divisibilidad = 0;

            for (int divisor = 1; divisor <= num; divisor++)
            {
                if (num % divisor == 0)
                {
                    divisibilidad++;
                }
            }
            if (divisibilidad <= 2)
            {
                Console.WriteLine("el número es primo");
            }
            else
            {
                Console.WriteLine("el número ingresado no es primo");
            }

            Console.ReadKey();
        }
    }
}
