using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.All_prime_numbers
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter start number (> 0): ");
            int start = int.Parse(Console.ReadLine());
            while (start <= 0)
            {
                Console.Write("Enter start number (> 0): ");
                start = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter end number (> start number): ");
            int end = int.Parse(Console.ReadLine());
            while (end <= start)
            {
                Console.Write("Enter end number (> start number): ");
                end = int.Parse(Console.ReadLine());
            }

            int[] array = PrimeNumber(start, end);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
            Console.ReadLine();
        }


        public static int[] PrimeNumber(int start, int end)
        {
            int[] array = new int[end - start];
            bool isPrime = false;
            int count = 0;
            for (int i = start + 1; i < end; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        isPrime = true;
                    }

                }
                if (!isPrime)
                {
                    array[count] = i;

                }
                count++;
                isPrime = false;
            }
            return array;
        }

    }
}
