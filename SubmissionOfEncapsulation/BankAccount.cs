using System;

namespace SubmissionOfEncapsulation
{
    // Interface for Loan System
    interface ILoanable
    {
        void ApplyForLoan(double amount);
        bool CalculateLoanEligibility();
    }

    // Abstract Class for Bank Accounts
    abstract class BankAccount : ILoanable
    {
        private int accountNumber;
        private string holderName;
        private double balance;

        // Constructor
        public BankAccount(int accNumber, string name, double initialBalance)
        {
            this.accountNumber = accNumber;
            this.holderName = name;
            this.balance = initialBalance;
        }

        // Encapsulation - Properties
        public int AccountNumber { get { return accountNumber; } }
        public string HolderName { get { return holderName; } }
        public double Balance { get { return balance; } protected set { balance = value; } }

        // Deposit Method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount!");
            }
        }

        // Withdraw Method
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance!");
            }
        }

        // Abstract Method for Interest Calculation
        public abstract double CalculateInterest();

        // Interface Methods for Loan
        public void ApplyForLoan(double amount)
        {
            if (CalculateLoanEligibility())
                Console.WriteLine($"Loan of {amount:C} approved for {HolderName}");
            else
                Console.WriteLine($"Loan of {amount:C} denied for {HolderName}");
        }

        public bool CalculateLoanEligibility()
        {
            return Balance > 1000;  // Loan Eligibility Condition
        }

        // Display Account Details
        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Holder: {HolderName}, Balance: {Balance:C}, Interest: {CalculateInterest():C}");
        }
    }

    // Savings Account Class
    class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(int accNumber, string name, double balance, double rate) : base(accNumber, name, balance)
        {
            this.interestRate = rate;
        }

        public override double CalculateInterest()
        {
            return Balance * (interestRate / 100);
        }
    }

    // Current Account Class
    class CurrentAccount : BankAccount
    {
        public CurrentAccount(int accNumber, string name, double balance) : base(accNumber, name, balance) { }

        public override double CalculateInterest()
        {
            return Balance * 0.02;  // Fixed 2% Interest for Current Accounts
        }
    }
}
