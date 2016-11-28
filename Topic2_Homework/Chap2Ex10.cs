using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2Ex10
{
    class Chap2Ex10
    {
        static void Main(string[] args){
            Console.Write("Please Enter an integer ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second integer ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter a third integer ");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            int product = a * b * c;

            Console.WriteLine("The sum of three integers is {0}", sum);
            Console.WriteLine("The product of three integers is {0}" , product);
        }

       
    }

}
