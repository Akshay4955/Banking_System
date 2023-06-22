namespace Banking_System;

public class Branch
{
    public string Name { get; set; }
    public DBOperation dBOperation;
    public Bank bank;

    public Branch() 
    {
        dBOperation = new DBOperation();
    }

    public Branch(string name, string bankName)
    {
        Name = name;
        bank = new Bank(bankName);
        new Branch();
    }

    public void AddCustomer(Customer customer)
    {
        dBOperation.AddCustomer(customer);
    }

    public void GetTotalBalanceBranch(string branchName, string bankName)
    {
        dBOperation.GetTotaLBalanceBranch(branchName, bankName);
    }
}
