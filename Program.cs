
using System;

namespace PracAss3
{
    class Program
    {
        static void Main()
        {
            BankAccount acount1 = new BankAccount("Nel", "Current", -5000);
            BankAccount acount2 = new BankAccount("Nel", "Savings", 0);
            BankAccount acount3 = new BankAccount("Nel", "Credit", -5000);
            Console.WriteLine(acount1.Details);
            Console.WriteLine(acount2.Details);
            Console.WriteLine(acount3.Details);
            acount1.Deposit(3000);
            acount2.Deposit(2000);
            acount3.Deposit(3000);
            acount1.AccountHolder = "Nel G";
            acount1.AccountType = "Current (Tjek)";
            acount2.CreditLimit = -5000;

            Console.WriteLine("Overall Balance: "
            + BankAccount.OverallBalance.ToString("C"));
            Console.WriteLine(acount3.WithDraw(2000));

            Console.WriteLine("Account 3 Balance: "
            + acount3.Balance.ToString("C"));
            Console.WriteLine("Overall Balance: "
            + BankAccount.OverallBalance.ToString("C"));
        }
    }
}