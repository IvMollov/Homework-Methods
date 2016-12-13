using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Max_Min
{
    class Program
    {
        public static void Main()
        {
            Console.Write("How many numbers do you want to input? ");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int maximalNumber = FindMaximal(array);
            Console.WriteLine("Maximal number is: {0}", maximalNumber);

            int minimalNumber = FindMinimal(array);
            Console.WriteLine("Minimal number is: {0}", minimalNumber);

        }

        public static int FindMaximal(int[] array)
        {
            int max = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int FindMinimal(int[] array)
        {
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

    }
}
