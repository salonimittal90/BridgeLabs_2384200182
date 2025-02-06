using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OopsObjectModeling.Customer;

namespace OopsObjectModeling
{
    public class Bank
    {

        public string name;
        public List<Customer> customers;

        public Bank(string name)
        {
            this.name = name; 
            customers = new List<Customer>();
        }

        public void OpenAccount(Customer customer , string accountType, double initialBalanace)
        {
            BankAccount newAccount = new BankAccount(this , accountType, initialBalanace);
            customer.accounts.Add(newAccount);
            customers.Add(customer);
            Console.WriteLine($"{customer.name} opened a {accountType} account in {name} Bank with balance: {initialBalanace}");
        }

    }

    public class Customer
    {
        public string name;
        public List<BankAccount> accounts = new List<BankAccount>();
      
       public Customer(string name )
        {
            this.name=name;
        }

        public void ViewBalance()
        {

            Console.WriteLine($"{name}'s Accounts");
            foreach (var acc in accounts)
            {
                Console.WriteLine($"- {acc.accountType} Account in {acc.bank.name} Bank: Balance = {acc.initialBalance}");
            }
        }
        public class BankAccount
        {
            public Bank bank;
            public string accountType;
            public double initialBalance;
           

            public BankAccount( Bank bank, string accountType, double initialBalance)
            {
                this.bank = bank;
                this.accountType = accountType;
                this.initialBalance = initialBalance;
            }



        }


    }
}
