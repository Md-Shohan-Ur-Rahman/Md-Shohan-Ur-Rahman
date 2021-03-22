using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcc
{
    public class Account
    {
        private static int count = 0;
        private int accountNumber = 0;
        private string accountName;
        private string email;
        private double balance;
        private Address address;
        
        public Account()
        {
            count++;
            accountNumber = count;
        }

        public Account(string accountName, string email, double balance, Address address):this()
        {
            this.accountName = accountName;
            this.email = email;
            this.balance = balance;
            this.address = address;
        }

        public Account(string accountName, string email, double balance, Address address, int debitCardNo) : this(accountName, email, balance, address)
        {
            
        }

        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public string Emaiil
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public Address Address
        {
            set { this.address = value; }
            get { return address; }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount < this.balance)
            {
                this.balance = this.balance - amount;
                Console.WriteLine("Successfully Withdraw ! New Balance Is: " + this.balance);
            }
            else
                Console.WriteLine("The Amount Is Invalid!");

        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance = this.balance + amount;
                Console.WriteLine("Deposit Successfully! New Balance : " + this.balance);
            }
            else
                Console.WriteLine("The Amount is Invalid!");

        }

        public void Transfer (double amount, Account receiver)
        {
            if (amount > 0 && amount < this.balance)
            {
                this.balance = this.balance - amount;
                receiver.balance = receiver.balance + amount;
                Console.WriteLine("Transfer Is Successful! New Balance: " + this.balance);
                     
            }
            else
                Console.WriteLine("The Amount IS Invalid!");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Number Is : {0}\nAccount Name Is : {1}\nEmail Address Is : {2}\nBAlance Is: {3}",
        this.accountNumber, this.accountName, this.email, this.balance);
            Console.WriteLine(address.Getaddress());
        }
    }
}
