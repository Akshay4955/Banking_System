namespace Banking_System;

public class Customer
{
    public string Name { get; set; }
    public DBOperation dBOperation;

    public Customer() 
    {
        dBOperation = new DBOperation(@"Data Source = LAPTOP-9639UT7T; Database = Banking_System; Integrated Security = True;");
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
}
