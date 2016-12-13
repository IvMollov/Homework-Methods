using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diameter__circumference_and_area
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double findedDiameter = FindDiameter(radius);
            Console.WriteLine("Diameter of a circle is: {0}.", findedDiameter);
            double findedCircumference = FindCircumference(radius);
            Console.WriteLine("Circumference of a circle is: {0:f2}.", findedCircumference);
            double findedArea = FindArea(radius);
            Console.WriteLine("Area of a circle is: {0:f2}.", findedArea);
        }

        public static double FindDiameter(double radius)
        {
            double diameter = radius * 2;
            return diameter;
        }

        public static double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public static double FindArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

    }
}
