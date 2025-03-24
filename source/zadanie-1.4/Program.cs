using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public string GetAccountNumber()
    {
        return accountNumber;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            throw new ArgumentException("Deposit amount must be positive");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds");
            }
        }
        else
        {
            throw new ArgumentException("Withdrawal amount must be positive");
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        // Tworzenie nowego konta bankowego
        BankAccount myAccount = new BankAccount("1234567890", 1000.00m);

        // Wyświetlanie numeru konta
        Console.WriteLine("Numer konta: " + myAccount.GetAccountNumber());

        // Wyświetlanie początkowego salda
        Console.WriteLine("Początkowe saldo: " + myAccount.GetBalance());

        // Dokonywanie wpłaty
        myAccount.Deposit(500.00m);
        Console.WriteLine("Saldo po wpłacie 500: " + myAccount.GetBalance());

        // Dokonywanie wypłaty
        myAccount.Withdraw(200.00m);
        Console.WriteLine("Saldo po wypłacie 200: " + myAccount.GetBalance());

        // Próba wypłaty większej niż saldo
        try
        {
            myAccount.Withdraw(1500.00m);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Błąd: " + ex.Message);
        }

        // Wyświetlanie końcowego salda
        Console.WriteLine("Końcowe saldo: " + myAccount.GetBalance());
    }
}