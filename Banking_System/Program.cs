﻿namespace Banking_System;

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

        Bank bank = new Bank();
        bank.AddBranch(new Branch("Pune", "BOM"));

        customer.DepositMoney("A00001", 1000);
        customer.DepositMoney("A00003", 10000);

        customer.WithdrawMoney("A00001", 5000);
        customer.WithdrawMoney("A00002", 32000);
        customer.WithdrawMoney("A00004", 4000);
    }
}