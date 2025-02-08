using System;

namespace SubmissionOfInheritance
{
    // Base Class BankAccount
    public class BankAccount
    {
        private string AccountNumber;
        private double Balance;

        // Constructor
        public BankAccount(string accountNumber, double balance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        // Method to display account information
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: ${Balance}");
        }
    }

    // Subclass (SavingsAccount)
    public class SavingsAccount : BankAccount
    {
        protected double InterestRate;

        // Constructor
        public SavingsAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            this.InterestRate = interestRate;
        }

        // Overriding method
        public void DisplayAccountType()
        {
            Console.WriteLine("\n--- Savings Account ---");
            DisplayAccountInfo();
            Console.WriteLine($"Interest Rate: {InterestRate}% per annum");
        }
    }

    // Subclass (CheckingAccount)
    public class CheckingAccount : BankAccount
    {
        private double WithdrawalLimit;

        // Constructor
        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            this.WithdrawalLimit = withdrawalLimit;
        }

        // Overriding method
        public void DisplayAccountType()
        {
            Console.WriteLine("\n--- Checking Account ---");
            DisplayAccountInfo();
            Console.WriteLine($"Daily Withdrawal Limit: ${WithdrawalLimit}");
        }
    }

    // Subclass (FixedDepositAccount)
    public class FixedDepositAccount : BankAccount
    {
        private int MaturityPeriod;

        // Constructor
        public FixedDepositAccount(string accountNumber, double balance, int maturityPeriod)
            : base(accountNumber, balance)
        {
            this.MaturityPeriod = maturityPeriod;
        }

        // Overriding method 
        public void DisplayAccountType()
        {
            Console.WriteLine("\n--- Fixed Deposit Account ---");
            DisplayAccountInfo();
            Console.WriteLine($"Maturity Period: {MaturityPeriod} months");
        }
    }


}
