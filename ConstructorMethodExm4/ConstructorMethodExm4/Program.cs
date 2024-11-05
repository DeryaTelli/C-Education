using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethodExm4
{
    internal class Program
    {
        public class BankAccount
        {
            public string account;
            public double balance;
            public static int totalaccount;

            public BankAccount(string account, double balance)
            {
                this.account=account;
                this.balance=balance;
                totalaccount++;

            }
            public void BankAccountInfo()
            {
                Console.WriteLine("Account: "+account+ " Balance: "+balance+ "Total Account: "+totalaccount);
            }
        }
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("abc1234", 230.1);
            b1.BankAccountInfo();
            BankAccount b2 = new BankAccount("2354sdfg", 100);
            b2.BankAccountInfo();
            Console.ReadLine();
        }
    }
}
