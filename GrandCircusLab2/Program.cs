using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab2
{
    class Program
    {
        static void Main()
        {
            string goAgain;
            do
            {
                Console.Write("Enter Width (in feet): ");
                string width = Console.ReadLine();
                Console.Write("Enter Length (in feet): ");
                string length = Console.ReadLine();
                double perimeter = (2 * double.Parse(width)) + (2 * double.Parse(length));
                double area = double.Parse(width) * double.Parse(length);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("\n");
                Console.WriteLine("Would you like to continue? y/n");
                goAgain = Console.ReadLine().ToLower();
                Console.WriteLine("\n");
            } while (goAgain == "y");
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }   
    }
}
