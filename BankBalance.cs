using System;

class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Parameterized Constructor
    public BankAccount(string accNum, double bal)
    {
        accountNumber = accNum;
        balance = bal;
    }

    // Copy Constructor
    public BankAccount(BankAccount obj)
    {
        accountNumber = obj.accountNumber;
        balance = obj.balance;
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance = balance + amount;
            Console.WriteLine($"Amount {amount} deposited successfully!");
        }
        else
        {
            Console.WriteLine("Invalid amount! Please enter a positive value.");
        }
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds! Withdrawal failed.");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Invalid amount! Please enter a positive value.");
        }
        else
        {
            balance = balance - amount;
            Console.WriteLine($"Amount {amount} withdrawn successfully!");
        }
    }

    // DisplayDetails Method
    public void DisplayDetails()
    {
        Console.WriteLine($"Account Number : {accountNumber}");
        Console.WriteLine($"Balance        : {balance}");
        Console.WriteLine("--------------------------------");
    }
}