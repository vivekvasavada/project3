using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings:Account 

    {
        //Fields
        private double accountBalance = 50000;
        private string accountType = "savings";
        private int accountSavingsNumber = 000002;

        //Properties
        public int AccountSavingsNumber
        {
            get { return this.accountSavingsNumber; }
        }

        public double AccountBalance
        {
            get { return this.accountBalance; }

            set { this.accountBalance = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            //set { this.accountType = value; }
        }

        // default constructor
        public Savings()



        {

        }

        public Savings (double accountBalance)
        {
            this.accountBalance = AccountBalance;


        }
        //Method
        public virtual double Deposit(double deposit)

        {
            return deposit +=accountBalance;

            
        }
        public virtual double Withdraw(double withdraw) 
        {

            return accountBalance -= withdraw;

        }


        }
}
