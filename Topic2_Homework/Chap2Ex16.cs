using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2Ex16
{
    class Chap2Ex16
    {
        static void Main(string[] args){
            Console.WriteLine("Please enter a temperature in fahrenheit");
            double f = double.Parse(Console.ReadLine());
           
           double c = 5 * (f - 32) / 9;
            Console.WriteLine("Temperature in centigrade is {0}", c);

        
           
        }
    }
}
