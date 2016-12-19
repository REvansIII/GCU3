using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5Ex20
{
    class Warehouse {

      static ArrayList inventory = new ArrayList();

        private String tv = "SuperScreen 1000";
        private String radio = "Sound 1000";
        private String computer = "Compute 1000";

        public Warehouse() { }

        public Warehouse(int t, int r, int c)
        {
            while (t > 0)
            {
                addTV();
                t--;
            }
            while (r > 0)
            {
                addRadio();
                r--;
            }
            while (c > 0)
            {
                addComputer();
                c--;
            }

        }

        public void addTV() {
            inventory.Add(tv);

        }

        public void addRadio() {
            inventory.Add(radio);         


        }

        public void addComputer() {
            inventory.Add(computer);
        }

        public override string ToString()
        {
            return "Available appliances " + inventory;
                
        }





        static void Main(string[] args)
        {
            Warehouse wh1 = new Warehouse();
            wh1.addTV();
            wh1.addRadio();
            wh1.addComputer();
            wh1.addTV();

            Warehouse wh2 = new Warehouse(4, 2, 1);

            Console.WriteLine("The appliances available are:");

            foreach (string str in inventory)

            {

                Console.WriteLine(str);

            }


        }

       
    }
}
