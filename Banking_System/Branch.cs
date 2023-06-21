namespace Banking_System;

public class Branch
{
    public string Name { get; set; }
    public DBOperation dBOperation;

    public Branch() 
    {
        dBOperation = new DBOperation(@"Data Source = LAPTOP-9639UT7T; Database = Banking_System; Integrated Security = True;");
    }

    public Branch(string name)
    {
        Name = name;
        new Branch();
    }

    public void AddCustomer(Customer customer)
    {
        dBOperation.AddCustomer(customer);
    }
}
