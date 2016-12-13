using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_or_Odd
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            FindOddOrEven(number);

            Console.ReadLine();
        }

        public static void FindOddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.Write("Number {0} is even.", number);
            }
            else
            {
                Console.Write("Number {0} is odd.", number);
            }

        }

    }
}
