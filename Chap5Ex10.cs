using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5Ex10
{
    class BankAccount
    {

        private double balance;

        public BankAccount()
        {
            balance = 0;
        }

        public BankAccount(double initialAmount)
        {
            balance = initialAmount;

        }

        public double GetBalance()
        {

            return balance;
        }

        public void Deposit(double amount)
        {
            balance += amount;

        }

        public double Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return balance;
            }
            else
                return -1.0;

        }

        public double Withdraw()
        {

            if
                (balance >= 40)
            {
                balance -= 40;
                return balance;
            }
            else
                Console.WriteLine("Insuffient Funds");
            return balance;
        }





        static void Main(string[] args){
            BankAccount myAccount = new BankAccount(25.00);
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());
            myAccount.Deposit(700.00);
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            if (myAccount.Withdraw(300.00) < 0)
                Console.WriteLine("Insufficient funds");

            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            if (myAccount.Withdraw(450.00) < 0)
                Console.WriteLine("Insufficient funds");

            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());           

            BankAccount yourAccount = new BankAccount();
            yourAccount.Deposit(1234.56);
            Console.WriteLine("Your balance = {0:C}", yourAccount.GetBalance());

            BankAccount test1 = new BankAccount(5.00);
            Console.WriteLine("Alternate withdraw method: beginning {0:c}, ending {1:c}", myAccount.GetBalance(), myAccount.Withdraw());
            Console.WriteLine("Alternate withdraw method account w/ low balance beginning {0:c}, ending {1:c}", test1.GetBalance(), test1.Withdraw());
        }
    }

}