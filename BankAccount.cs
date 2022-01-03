
// Note:PracAss 2 for 2nd semester

// Purpose: A class to manipulate BankAccount information

using System;


namespace PracAss3
{
    public class BankAccount
    {
        //  stores an accumulative total of the balances of all BankAccount objects
        public static double overallBalance; 
        string accountHolder; // name of account holder
        string accountType; // name of account type
        double balance; // amount of money in the account
        double creditLimit; // maximum amount that the balance can be in debt


        // Non-default constructor
        public BankAccount(string accHolder, string accType, double creditLimit)
        {
            accountHolder = accHolder;
            accountType = accType;
            this.creditLimit = creditLimit;
            balance = 0;
        }

        // To subtract the balance and OverallBalance with the parameter if account has sufficient funds
        public string WithDraw(double withdrawalAmt)
        {
            string results = "Successful withdrawal";

            double newBalance = balance - withdrawalAmt;

            if (newBalance < creditLimit)
            {
                results = "Insufficent funds";
            }
            else
            {
                balance -= withdrawalAmt;
                overallBalance -= withdrawalAmt;
            }

            return results;
        }

        // Add balance and OverallBalance with the parameter
        public void Deposit(double depositAmt)
        {
            balance += depositAmt;
            overallBalance += depositAmt;
        }

        // Display's the details of the bank account
        public string Details
        {
            get
            {
                return $"Account Holder: {accountHolder}\n" +
                  $"Type: {accountType}\n" +
                  $"Credit Limit: {String.Format("{0:C}", creditLimit)}\n" +
                  $"Balance: {String.Format("{0:C}", Balance)}\n";
            }
        }

        public double Balance { get { return balance; } }
        public static double OverallBalance { get { return overallBalance; } }
        public string AccountHolder { set { accountHolder = value; } }
        public string AccountType { set { accountType = value; } }
        public double CreditLimit
        {
            set
            {
                if (value < Balance)
                    creditLimit = value;
            }
        }
    }
}
