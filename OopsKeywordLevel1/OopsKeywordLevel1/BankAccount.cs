using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopsKeywordLevel1
{
    internal class BankAccount
    {
       
        private static string bankName = "state Bank";
        private int totalAccounts = 0;

        public readonly int AccountNumber;
        public string AccountHolderName;
        public double Balance;

        public BankAccount()
        {
        }

        public BankAccount(int accountNumber, string accountHolderName, double initialBalance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            this.Balance = initialBalance;
            totalAccounts++;
        }
        public static void GetTotalAccounts()
        {
            BankAccount b = new BankAccount();
            int result=b.totalAccounts;
           
            Console.WriteLine($"Total Account number is{ result}");

        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} deposited successfully! New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"₹{amount} withdrawn successfully! New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }

        }
        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: {Balance}");
        }

        public void DisplayAccountDetails()
        {
            if (this is BankAccount)
            {
                Console.WriteLine($"Bank: {bankName}");
                Console.WriteLine($"Account Number: {AccountNumber}");
                Console.WriteLine($"Account Holder: {AccountHolderName}");
                Console.WriteLine($"Balance: {Balance}");
                Console.WriteLine("-----------------------------");
            }
        }


        public static void BankOperations(BankAccount acc)
        {
            while (true)
            {
                Console.WriteLine("\n--- Welcome to ABC Bank ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Total Accounts");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double depositAmount;
                        if (double.TryParse(Console.ReadLine(), out depositAmount))
                            acc.Deposit(depositAmount);
                        else
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                        break;

                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        double withdrawAmount;
                        if (double.TryParse(Console.ReadLine(), out withdrawAmount))
                            acc.Withdraw(withdrawAmount);
                        else
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                        break;

                    case 3:
                        acc.CheckBalance();
                        break;

                    case 4:
                        GetTotalAccounts();
                        break;

                    case 5:
                        acc.DisplayAccountDetails();
                        Console.WriteLine("Thank you for banking with ABC Bank. Have a nice day!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1-4.");
                        break;
                }
            }
        }
    }
}




   
