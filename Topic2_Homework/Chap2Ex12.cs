using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2Ex12
{
    class Chap2Ex12
    {
        static void Main(string[] args) {
            Console.WriteLine("Please enter a height value");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a width value");
            double width = double.Parse(Console.ReadLine());

            double area = height * width;

            Console.WriteLine("The area of the rectangle is {0}", area);
        }
    }
}
