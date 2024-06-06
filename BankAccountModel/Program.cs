



using System;

namespace BankAccountExercise
{
    class BankAccount
    {
        // Attributes
        private string accountNumber;
        private string accountHolder;
        private decimal balance;

        // Constructor
        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = initialBalance;
        }

        // Methods
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }
        }
        public String Getaccnum()
        {
            return accountNumber;
        }
        public String Getaccname()
        {
            return accountHolder;
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a bank account instance
            Decimal temp;
            Console.Write("Enter your Account number: ");
            String accnum=Console.ReadLine();
            Console.Write("Enter the Account Holders Name: ");
            String accname=Console.ReadLine();
            Console.Write("Enter the Balance: ");
            Decimal bal=Convert.ToInt32(Console.ReadLine());
            BankAccount account = new BankAccount(accnum, accname, bal);

            // Perform some operations
            
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("What operation would you like to perform\n1.Deposit\n2.Withdraw\n3.GetBalance\n4.End Program");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter amount to be deposited: ");
                    temp = Convert.ToInt32(Console.ReadLine());
                    account.Deposit(temp);
                }
                if (choice == 2)
                {
                    Console.Write("Enter the amount to be withdrawn: ");
                    temp = Convert.ToInt32(Console.ReadLine());
                    if (bal > temp)
                    {
                        account.Withdraw(temp);
                    }
                    else
                    {
                        Console.Write("Insufficient Balance");
                    }
                }
                if (choice == 3)
                {
                    decimal currentBalance = account.GetBalance();
                    Console.WriteLine($"Account Holder: {account.Getaccname()}");
                    Console.WriteLine($"Account Number: {account.Getaccnum()}");
                    Console.WriteLine($"Current Balance: ${currentBalance}");
                }

            }
            



            Console.ReadLine();
        }
    }
}
