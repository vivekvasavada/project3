using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account //base so therefore can be abstact also not instantized 
    {
        private double accountBalance;

        public virtual double Deposit(double deposit)

        {
            return deposit += accountBalance;


        }
        public virtual double Withdraw(double withdraw)
        {

            return accountBalance -= withdraw;

        }


    }











}



