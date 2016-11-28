using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2Ex14
{
    class Chap2Ex14
    {
        static void Main(string[] args){
            int x = 73;
            int y = 16;

            Console.WriteLine("The remainder of 73 divided by 7 is {0} ", FindRemainder(x));
            Console.WriteLine("The remainder of 16 divided by 7 is {0}", FindRemainder(y));
            Console.WriteLine("The remainder of 73 + 16 divided by 7 is {0}", FindRemainder(x + y));
        }

        public static int FindRemainder(int r) {
            int rem = r % 7;
            return rem;
        }
    }
}
