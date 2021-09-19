 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name;
            name = Console.ReadLine();

            Console.Write("Please enter your location: ");
            string location;
            location = Console.ReadLine();

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"You are from {location}");

            //date
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is {currentDate.ToShortDateString()}");

            //Days 'til Christmas
            var christmasDate = new DateTime(2021, 12, 21).Date;
            var totalDays = (christmasDate - currentDate).Days;
            Console.WriteLine($"Days until Christmas: {totalDays}");

            //Example 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.ReadKey();
            
        }
    }
}
