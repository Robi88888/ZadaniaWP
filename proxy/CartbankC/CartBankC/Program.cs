using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartBankC
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = int.Parse(Console.ReadLine());

            CartBank cartbank = new CartBank();
            cartbank.getPIN(pin);

            if (cartbank.IfPinIsValid)
            {
                Console.WriteLine("The correct pin has been entered, what do you want to do?");
                Console.WriteLine("Withdraw 4,000 USD from the bank");
                cartbank.PayOutMoneyFromAccount(400);
                Console.WriteLine("You have: " + cartbank.CheckStateAccount() + " USD left in your account");
            }
            else
            {
                Console.WriteLine("Incorrect pin entered, try again");
            }

            Console.ReadKey();
        }
    }
}
