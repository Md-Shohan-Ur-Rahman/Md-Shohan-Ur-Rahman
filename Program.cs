using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Trust Bank", 12);
            Address addr1 = new Address("02", "6/j", "Khulna", "Bangladesh");
            Account acc1 = new Account("Aaron", "Aaronpaul@gmail.com", "1258", addr1);
            ourBank.AddAccount(acc1);
            Console.WriteLine("Account Info:");
            ourBank.ViewAccountDetails(1);

        }
    }
}
