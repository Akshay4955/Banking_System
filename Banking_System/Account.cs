namespace Banking_System;

public class Account
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
    public DBOperation dBOperation;
    public Branch branch;
    public Bank bank;
    public Customer customer;

    public Account(string accountNumber, double balance, string custName, string branchName, string bankName)
    {
        branch = new Branch(branchName);
        bank = new Bank(bankName);
        customer = new Customer(custName);
        AccountNumber = accountNumber;
        Balance = balance;
    }
}
