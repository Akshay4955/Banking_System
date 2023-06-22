namespace Banking_System;

public class Customer
{
    public string Name { get; set; }
    public DBOperation dBOperation;

    public Customer() 
    {
        dBOperation = new DBOperation();
    }
    public Customer(string name)
    {
        Name = name;
        new Customer();
    }

    public void AddAccount(Account account)
    {
        dBOperation.AddAccount(account);
    }

    public void DepositMoney(string account, double depositAmount)
    {
        dBOperation.DepositMoney(account, depositAmount);
    }

    public void WithdrawMoney(string account, double withdrawAmount)
    {
        dBOperation.WithdrawMoney(account, withdrawAmount);
    }

    public void GetTotalBalanceCustomer(string name)
    {
        dBOperation.GetTotaLBalanceCustomer(name);
    }
}
