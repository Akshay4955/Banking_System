namespace Banking_System;

public class Bank
{
    public string Name { get; set; }
    public DBOperation dBOperation;

    public Bank()
    {
        dBOperation = new DBOperation(@"Data Source = LAPTOP-9639UT7T; Database = Banking_System; Integrated Security = True;");
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
}
