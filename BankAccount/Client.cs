using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //Fields
        private string name = "Jerry Seinfeld";
        private string address = "123 Monk Street, Manhattan, New York";
        private int accountCheckingNumber = 000001;
        private int accountSavingsNumber = 000002;





        //Properties (3)

        public string Name { get { return this.name; } }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public int AccountCheckingNumber { get { return this.accountCheckingNumber; } }
        public int AccountSavingsNumber { get { return this.accountSavingsNumber; } }



        // Default Constructor
        public Client()
        {

        }

        public Client(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        //Method
        public void CustomerInfo()
        {
            Console.WriteLine("Name : {0} Address: {1}\n", name, address);

        }
    }
}
