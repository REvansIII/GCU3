using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2Ex18
{
    class Chap2Ex18
    {
        static void Main(string[] args) {
          
            Console.WriteLine("Please enter a value for x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("The value of the polynomial 4 * x ^ 2 + 3 * x - 5 is {0} ", Poly(x));

            Console.WriteLine("Please enter a second value for x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("The second value of the polynomial 4 * x ^ 2 + 3 * x - 5 is {0} ",Poly(x));
        

        }

        static  double Poly(double x) {
            double result = (4 * x*x) + (3 * x) - 5;
            return result;
        }
    }
}
