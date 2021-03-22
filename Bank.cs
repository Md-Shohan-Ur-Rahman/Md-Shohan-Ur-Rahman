using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcc
{
    public class Bank
    {
        private string bankName;
        Account[] accounts;

        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.accounts = new Account[size];
        }
        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }

        public void Transaction(char mode, double amount, params int[] accountNo)
        {
            Account account = null, receiver = null;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    if (accounts[i].AccountNumber == accountNo[0])
                    {
                        account = accounts[i];
                        break;
                    }
                }

            }
            if (accountNo.Length == 2)
            {
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i] != null)
                    {
                        if (accounts[i].AccountNumber == accountNo[1])
                        {
                            receiver = accounts[i];
                            break;
                        }
                    }
                }
                if (account != null)
                {
                    if (mode == 'd')
                    {
                        account.Deposit(amount);
                    }
                    else if (mode == 'w')
                    {
                        account.Withdraw(amount);
                    }
                    else if (mode == 't')
                    {
                        if (receiver != null)
                        {
                            account.Transfer(amount, receiver);
                        }
                        else
                            Console.WriteLine("Receiver Account Not Found!");
                    }
                    else
                        Console.WriteLine("Invalid Attempt!");
                }


            }

        }
        public void DeleteAccount(int accountNo)
        {
            int index = -1;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    if (accounts[i].AccountNumber == accountNo)
                    {
                        index = i;
                            break;
                    }
                }
            }
            if (index != -1)
            {
                for (int i = index; i < accounts.Length - 1; i++)
                {
                    if (accounts[i + 1] == null)
                    {
                        accounts[i] = null;
                    }
                    else
                    {
                        accounts[i] = accounts[i + 1];
                    }
                }
                accounts[accounts.Length - 1] = null;
            }
            else
                Console.WriteLine("Account Does Not Exist!");
        }
        public void ViewAccDetails(int accountNo)
        {
            Account account = null;

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    if (accounts[i].AccountNumber == accountNo)
                    {
                        account = accounts[i];
                        break;
                    }
                }
            }
            if (account != null)
            {
                account.ShowInfo();

            }
            else
                Console.WriteLine("Account Does Not Exist!");
        }


    }
   
        

    

}
