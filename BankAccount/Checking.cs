using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        //Fields, need this information for menu
        
        private string accountType = "checking";
        private double accountBalance = 50000;
        private int accountCheckingNumber = 000001;

        //Properties
       

        public double AccountBalance
        {
            get { return this.accountBalance; }

            set { this.accountBalance = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public int AccountCheckingNumber
        {
            get { return this.accountCheckingNumber; }
            set { this.accountCheckingNumber = value;}
        }

        // default constructor
        public Checking()



        {

        }

        public Checking(double accountBalance, int accountCheckingNumber)
        {
            this.accountBalance = AccountBalance;
            this.accountCheckingNumber = AccountCheckingNumber;

        }
        //Method
        public override double Deposit(double deposit)

        {
            return deposit +=accountBalance;

            
        }
        public override double Withdraw(double withdraw) 
        {

            return accountBalance -= withdraw;

        }

               
        
        
        
        
        
        
        
       

        }
    }

