using System.Data.SqlClient;

namespace Banking_System;

public class DBOperation
{
    private string connectionString;
    private SqlConnection connection;

    public DBOperation()
    {
        this.connectionString = @"Data Source = LAPTOP-9639UT7T; Database = Banking_System; Integrated Security = True;";
    }

    public void AddAccount(Account account)
    {
        connection = new SqlConnection(connectionString);
        connection.Open();

        SqlCommand insertAccount = new SqlCommand("spAddAccount", connection);
        insertAccount.CommandType = System.Data.CommandType.StoredProcedure;
        insertAccount.Parameters.AddWithValue("@BankName", account.branch.bank.Name);
        insertAccount.Parameters.AddWithValue("@BranchName", account.branch.Name);
        insertAccount.Parameters.AddWithValue("@CustName", account.customer.Name);
        insertAccount.Parameters.AddWithValue("@AccNumber", account.AccountNumber);
        insertAccount.Parameters.AddWithValue("@Balance", account.Balance);

        insertAccount.ExecuteNonQuery();
        connection.Close();
    }

    public void AddCustomer(Customer customer)
    {
        connection = new SqlConnection(connectionString);
        connection.Open();

        SqlCommand insertCustomer = new SqlCommand("spAddCustomer", connection);
        insertCustomer.CommandType = System.Data.CommandType.StoredProcedure;
        insertCustomer.Parameters.AddWithValue("@CustName", customer.Name);

        insertCustomer.ExecuteNonQuery();
        connection.Close();
    }

    public void AddBranch(Branch branch)
    {
        connection = new SqlConnection(connectionString);
        connection.Open();

        SqlCommand insertBranch = new SqlCommand("spAddBranch", connection);
        insertBranch.CommandType = System.Data.CommandType.StoredProcedure;
        insertBranch.Parameters.AddWithValue("@BranchName", branch.Name);
        insertBranch.Parameters.AddWithValue("@BankName", branch.bank.Name);

        insertBranch.ExecuteNonQuery();
        connection.Close();
    }

    public void DepositMoney(string account, double depositMoney)
    {
        connection = new SqlConnection(connectionString);
        connection.Open();

        SqlCommand depositCommand = new SqlCommand("spDepositMoney", connection);
        depositCommand.CommandType = System.Data.CommandType.StoredProcedure;
        depositCommand.Parameters.AddWithValue("@AccNumber", account);
        depositCommand.Parameters.AddWithValue("@DepositAmount", depositMoney);

        int rows = depositCommand.ExecuteNonQuery();
        if (rows > 0)
            Console.WriteLine("Money deposited successfully into account :" + account);
        else
            Console.WriteLine("Account not found with given account number ");
        connection.Close();
    }

    public void WithdrawMoney(string account, double withdrawMoney)
    {
        connection = new SqlConnection(connectionString);
        connection.Open();

        SqlCommand depositCommand = new SqlCommand("spWithdrawMoney", connection);
        depositCommand.CommandType = System.Data.CommandType.StoredProcedure;
        depositCommand.Parameters.AddWithValue("@AccNumber", account);
        depositCommand.Parameters.AddWithValue("@WithdrawAmount", withdrawMoney);

        int rows = depositCommand.ExecuteNonQuery();
        if (rows > 0)
            Console.WriteLine("Money withdrawn successfully from account :" + account);
        else
            Console.WriteLine("Account not found with given account number or your balance is insufficient ");
        connection.Close();
    }
}
