using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiated Client,Checking,Saving
            Client JerrySeinfeld = new Client();
            Checking SeinfeldChecking1 = new Checking();
            Savings SeinfeldSavings1 = new Savings();


            //Accounts
            string choice1;
            string choice2;
            double deposit;
            double withdraw;
            //do
            {

                Console.WriteLine("Welocme to Kramerica Bank");
                Console.WriteLine("Please make a selection");

                Console.WriteLine("1. View Client Informtion\n 2. View Account Balance\n 3. Deposit Funds \n 4. Withdraw Funds\n 5. Exit");
                Console.WriteLine("Please Enter a selection");
                choice1 = Console.ReadLine();
                Console.Clear();

                // Display User info

                if (choice1 == "1")
                {
                    JerrySeinfeld.CustomerInfo();

                    Console.Write("Please hit the enter key after selection");
                    Console.ReadLine();
                    Console.Clear();

                }
                //Check Account Balances
                if (choice1 == "2")
                {
                    
                    //do
                    //{
                        {
                        Console.WriteLine("1.Checking Balance\n2. Savings Balance\n3. Back to Menu\n4.Exit ");
                    }
                    choice2 = Console.ReadLine();
                    Console.Clear();

                    if (choice2 == "1")

                    {
                        Console.WriteLine("Your Checking balance is  {0}",SeinfeldChecking1);
                    }


                    if (choice2 == "2")
                    {
                        Console.WriteLine("Your Savings balance is {0}", SeinfeldSavings1);
                    }

                    if (choice2 != "2")

                    {


                    }
                    while (choice2 != "1" || choice2 != "2" || choice2 != "3" || choice2 != "4" || choice2 != "5") ;








                }


            }
        }
    }
}
