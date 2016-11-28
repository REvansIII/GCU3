using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Ex14
{
    class Chap3Ex14
    {
      static  double foot = 3.28;
      static  double inches = 39.37;

        static void Main(string[] args){
            
            Console.WriteLine("Please enter a measurement in meters");
            double length = double.Parse(Console.ReadLine());

            if (length < .304)
            {
                Console.WriteLine("Length in inches is {0:f2} ", Convert2(length));

            }
            else
                Console.WriteLine("Length in feet is {0:f2}", Convert1(length));

        }

        static double Convert1(double length) {
            double result1 = length * foot;
            return result1;

        }

        static double Convert2(double length) {
            double result2 = length * inches ;
            return result2;
        }
       

        }
    }

