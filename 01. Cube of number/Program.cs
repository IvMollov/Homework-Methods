using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cube_of_number
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Cube of {0} is {1}.", number, FindCube(number));
        }

        public static double FindCube(double n)
        {
            double cubedNumber = Math.Pow(n, 3);
            return cubedNumber;
        }

    }
}
