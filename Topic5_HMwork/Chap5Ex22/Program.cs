using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5Ex22
{
    class Vending {
        private double cupsAvailable;
        private double cost;
        private double payment;

        Vending() {
            cupsAvailable = 10;
            cost = .50;
        }

        Vending(double cupsAvailable, double cost){
            this.cupsAvailable = cupsAvailable;
            this.cost = cost;


        }

        public void Menu() {
            Console.WriteLine("The cost of a cup of coffee is {0:c} and there are {1} cups available", cost, cupsAvailable);

        }

        public void Insert(double quarter, double dime, double nickel) {
            quarter = quarter *.25;
            dime = dime *.10;
            nickel = nickel *.05;

            payment = quarter + dime + nickel;

            Console.WriteLine("You have entered {0:c}", payment);

        }

        public void Select() {
            if ((cupsAvailable >= 1))
            {
                cupsAvailable = payment / cost;
                Console.WriteLine("You have purchased {0} cups of coffee at {1:c} a cup", cupsAvailable, cost);
                
            }
            else if (cupsAvailable < 0)
            {
                Console.WriteLine("Coffee sold out");

            }
            else if (payment < cost)
            {
                Console.WriteLine("Funds are insufficient for this transaction");

            }
            else
                Console.WriteLine("Out of order");            


        }

        public void Refund() {
            Console.WriteLine("You have been refunded {0:c}", payment);
        }
    
        static void Main(string[] args)
        {
            Vending vend1 = new Vending();
            vend1.Menu();
            vend1.Insert(3, 2, 1);
            vend1.Select();

            Vending vend2 = new Vending(2 , .75);
            vend2.Menu();
            vend2.Insert(4, 4, 2);
            vend2.Select();

            Vending vend3 = new Vending(0, .50);
            vend3.Menu();
            vend3.Insert(4, 0, 0);
            vend3.Select();
            vend3.Refund();



        }
    }
}
