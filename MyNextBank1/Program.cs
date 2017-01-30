using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNextBank1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Welcome to my Bank**");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("Please select one of the options above");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Please enter your email address");
                        var emailAddress = Console.ReadLine();
                        var myAccount = new Account(emailAddress);
                        Console.WriteLine($"The balance in my account - {myAccount.AccountNumber} is {myAccount.Balance:C} ");
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Sorry option not available");
                        break;
                }
            }

        }
    }
}
