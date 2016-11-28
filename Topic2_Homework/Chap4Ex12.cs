using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chap4Ex12
{
    class Chap4Ex12
    {
        static void Main(string[] args){
            Console.WriteLine("Enter a test score or -1 to quit");
            int score = int.Parse(Console.ReadLine());



            if ((score >= 0)) {

                

            switch (score/10){

                    case 0: Console.WriteLine("F");
                        break;
                    case 1: Console.WriteLine("F");
                        break;
                    case 2: Console.WriteLine("F");
                        break;
                    case 3: Console.WriteLine("F");
                        break;
                    case 4: Console.WriteLine("F");
                        break;
                    case 5: Console.WriteLine("F");
                        break;
                    case 6: Console.WriteLine("D");
                        break;
                    case 7: Console.WriteLine("C");
                        break;
                    case 8: Console.WriteLine("B");
                        break;
                    case 9:
                    case 10: Console.WriteLine("A");
                        break;
                    default: Console.WriteLine("Incorrect score");
                        break; 





                }






            }




        }
    }
}
