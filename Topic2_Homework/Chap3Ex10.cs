using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Ex10
{
    class Chap3Ex10
    {
        static void Main(string[] args){

            Console.WriteLine("Please enter your grade point average");
            double GPA = double.Parse(Console.ReadLine());

            if (GPA >= 3.0)
            {
                Console.WriteLine("You are an Honor Student");
            }
                else if (GPA > 2.0 && GPA < 3.0)
            {
                    Console.WriteLine("You are an average student");
            }
                    else
                        Console.WriteLine("You are on probation");

            }
        }
    }

