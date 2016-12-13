using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Last_digit_English_word
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            string digit = GetLastDigit(number);
            Console.WriteLine("Last digit of {0} is \"{1}\".", number, digit);
            Console.ReadLine();
        }


        public static string GetLastDigit(int number)
        {
            int lastDigit = number % 10;
            string digit = " ";
            string[] digits = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            digit = digits[lastDigit];

            return digit;
        }

    }
}
