namespace Banking_System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Banking System...!!!");
        Customer customer = new Customer();
        Account account = new Account("A00001", 10000, "Akshay", "Pirangut", "BOB");
        customer.AddAccount(account);

        Branch branch = new Branch();
        branch.AddCustomer(new Customer("Akshay"));
        branch.AddCustomer(new Customer("Rahul"));
        customer.AddAccount(new Account("A00002", 30000, "Rahul", "Hinjewadi", "BOM"));
    }
}