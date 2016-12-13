using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Solve_tasks
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello.\n1. Choose number \"1\" to Reverses the digits of a number." +
                          "\n2. Choose number \"2\" to Calculates the average of a sequence of integers." +
                          "\n3. Choose number \"3\" to Solves a linear equation a * x + b = 0. ");
            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                string reverse = ReverseNumber();
                Console.WriteLine("Reversed number is {0}", reverse);
            }
            if (number == 2)
            {
                double average = GetAverage();
                Console.WriteLine("Average is {0:f2}", average);
            }
            if (number == 3)
            {
                double a, b;
                double x = SolveLinearEquation(out a, out b);

                Console.WriteLine("{0}*x + {1} = 0. x = {2:f2}", a, b, x);
            }
            Console.ReadLine();
        }


        public static string ReverseNumber()
        {
            Console.Write("You have chosen \"Reverses the digits of a number.\" option. ");
            Console.Write("\nEnter positive number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            while (number <= 0)
            {
                Console.Write("Enter positive number: ");
                number = decimal.Parse(Console.ReadLine());
            }

            string numberToString = number.ToString();
            StringBuilder reverseDigit = new StringBuilder();
            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                reverseDigit.Append(numberToString[i]);
            }

            return reverseDigit.ToString();
        }

        public static double GetAverage()
        {
            Console.Write("You have chosen \"Calculates the average of a sequence of integers.\" option. ");
            Console.Write("\nEnter length of sequence (> 0): ");
            int length = int.Parse(Console.ReadLine());
            while (length <= 0)
            {
                Console.Write("Sequence must be bigger than 0. Enter length of sequence (> 0): ");
                length = int.Parse(Console.ReadLine());
            }
            int[] array = new int[length];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter integer [{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            double average = (double)sum / (double)array.Length;
            return average;
        }
        public static double SolveLinearEquation(out double a, out double b)
        {
            Console.Write("You have chosen \"Calculates the average of a sequence of integers.\" option. ");
            Console.Write("\nEnter \"a\"(!= 0): ");
            double A = double.Parse(Console.ReadLine());
            while (A == 0)
            {
                Console.Write("\"a\" must not be equal to 0. Enter \"a\"(!= 0): ");
                A = double.Parse(Console.ReadLine());
            }
            Console.Write("\nEnter \"b\"(!= 0): ");
            double B = double.Parse(Console.ReadLine());
            a = A;
            b = B;
            double x = -B / A;
            return x;
        }

    }
}
