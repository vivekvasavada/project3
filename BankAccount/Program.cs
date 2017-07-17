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
                //Welcome User
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

                    do
                    {

                        Console.WriteLine("1.Checking Balance\n2. Savings Balance\n3. Back to Menu\n4.Exit ");
                        choice2 = Console.ReadLine();
                        Console.Clear();

                        if (choice2 == "1")

                        {
                            Console.WriteLine("Your Checking balance is  {0}", SeinfeldChecking1.AccountBalance);
                        }


                        if (choice2 == "2")
                        {
                            Console.WriteLine("Your Savings balance is {0}", SeinfeldSavings1.AccountBalance);
                        }

                        if (choice2 == "3")
                        {
                            break;
                        }

                        if (choice2 == "4")

                            if (choice1 == "5")
                            {
                                break;

                            }


                    } while (choice2 != "1" || choice2 != "2" || choice2 != "3" || choice2 != "4");
                }



                //Deposit Funds

                if (choice1 == "3")
                {
                    do
                    {
                        Console.WriteLine("Which Account would like to deposit?\n 1.Checking\n 2. Savings \n 3.back\n 4. Exit ");
                        choice1 = Console.ReadLine();
                        Console.Clear();




                        {


                            Console.WriteLine("How much to deposit");
                            deposit = double.Parse(Console.ReadLine());
                            SeinfeldChecking1.AccountBalance = SeinfeldChecking1.Deposit(deposit);

                            Console.WriteLine("Your balance is now {0}", SeinfeldChecking1.AccountBalance);
                            Console.WriteLine("Enter to continue");
                            Console.ReadLine();
                            Console.Clear();



                            {
                                Console.WriteLine("How much to deposit?");
                                deposit = double.Parse(Console.ReadLine());
                                SeinfeldChecking1.AccountBalance = SeinfeldSavings1.Deposit(deposit);
                                Console.WriteLine("Your balance is now {0}", SeinfeldSavings1.AccountBalance);
                                Console.WriteLine("Enter to continue");
                                Console.ReadLine();
                                Console.Clear();
                            }





                            {
                                break;
                            }

                            if (choice2 == "4")
                            {
                                break;

                            }


                        } while (choice2 != "1" || choice2 != "2" || choice2 != "3" || choice2 != "4") ;


                        //Allow for Withdrawals
                        if (choice1 == "4")
                        {
                            do
                            {
                                Console.WriteLine("Which account to withdraw?\n 1. Checking\n 2. Savings\n 3. Back\n 4.Exit ");
                                choice2 = Console.ReadLine();
                                Console.Clear();
                                if (choice2 == "1")
                                {
                                    Console.WriteLine("How much to withdraw?");
                                    withdraw = double.Parse(Console.ReadLine());
                                    SeinfeldChecking1.Withdraw(withdraw);

                                    Console.WriteLine("New balalance is {0}", SeinfeldChecking1.AccountBalance);
                                    Console.WriteLine("enter to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                if (choice2 == "2")
                                {
                                    Console.WriteLine("How much to withdraw?");
                                    withdraw = double.Parse(Console.ReadLine());
                                    if (withdraw > SeinfeldSavings1.AccountBalance)
                                    {
                                        Console.WriteLine("insufficient funds");
                                        Console.WriteLine("enter");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }


                                    SeinfeldSavings1.AccountBalance = SeinfeldSavings1.Withdraw(withdraw);
                                    Console.WriteLine("new balance is {0}", SeinfeldSavings1.AccountBalance);
                                    Console.ReadLine();
                                    Console.Clear();
                                }


                                if (choice2 == "3")
                                {
                                    break;
                                }

                                if (choice2 == "4")

                                    break;

                                {
                                    if (choice1 == "5") ;
                                }


                            } while (choice2 != "1" || choice2 != "2" || choice2 != "3" || choice2 != "4");

                        }
                    } while (choice1 != "5");


                }
            }
        }
    }
}











                    




                






