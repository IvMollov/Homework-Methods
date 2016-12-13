using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Prime__armstrong__perfect_number
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter number (> 0): ");
            int number = int.Parse(Console.ReadLine());
            while (number <= 0)
            {
                Console.Write("Enter number (> 0): ");
                number = int.Parse(Console.ReadLine());
            }

            bool isPerfect = PerfectNumber(number);
            if (isPerfect)
            {
                Console.WriteLine("Number {0} is perfect.", number);
            }
            else
            {
                Console.WriteLine("Number {0} is not perfect.", number);
            }

            bool isArmstrong = FindArmstrongNumber(number);
            if (isArmstrong)
            {
                Console.WriteLine("Number {0} is armstrong number.", number);
            }
            else
            {
                Console.WriteLine("Number {0} is not armstrong number.", number);
            }

            bool isPrime = PrimeNumber(number);
            if (isPrime)
            {
                Console.WriteLine("Number {0} is not prime.", number);
            }
            else
            {
                Console.WriteLine("Number {0} is prime.", number);
            }
            Console.ReadLine();

        }

        public static bool PerfectNumber(int number)
        {
            bool isPerfect;
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                return isPerfect = true;
            }
            else
            {
                return isPerfect = false; ;
            }
        }
        public static bool FindArmstrongNumber(int number)
        {
            bool isArmstrong = false;
            double sum = 0;
            double singleNumber;
            string stringNumber = number.ToString();
            double doubleLength = stringNumber.Length;
            for (int i = 0; i < stringNumber.Length; i++)
            {
                singleNumber = Math.Pow((int)Char.GetNumericValue(stringNumber[i]), doubleLength);
                sum += singleNumber;

            }
            if (sum == number)
            {
                isArmstrong = true;
            }
            return isArmstrong;
        }

        public static bool PrimeNumber(int number)
        {
            bool isPrime = false;

            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    isPrime = true;
                    break;
                }
            }

            return isPrime;
        }

    }
}
