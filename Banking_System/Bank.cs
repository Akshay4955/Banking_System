namespace Banking_System;

public class Bank
{
    public string Name { get; set; }
    public DBOperation dBOperation;

    public Bank()
    {
        dBOperation = new DBOperation();
    }
    public Bank(string name)
    {
        Name = name;
        new Bank();
    }

    public void AddBranch(Branch branch)
    {
        dBOperation.AddBranch(branch);
    }

    internal void GetTotalBalanceBank(string bankName)
    {
        dBOperation.GetTotaLBalanceBank(bankName);
    }
}
