using System;

namespace areaofcircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Area of a Circle - 2.6.1
            Console.WriteLine("Enter a radius: ");
            string radiusInput = Console.ReadLine();
            double radius = double.Parse(radiusInput);
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of circle with {radius} radius is {area}.");

            // More calculations - 2.6.2
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The circumference of a circle with a radius of {radius} is {circumference}");
            Console.WriteLine($"The diameter of a circle with a radius of {radius} is {radius * 2}");
                
            //Road Trip
            Console.WriteLine("What is the MPG of your car?");
            double mpg = double.Parse(Console.ReadLine());
            double gallons = circumference / mpg;
            Console.WriteLine($"Your vehicle has a fuel efficency rate of {mpg}mpg ");




        }
    }
}
