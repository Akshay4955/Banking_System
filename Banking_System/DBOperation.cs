using System.Data.SqlClient;

namespace Banking_System;

public class DBOperation
{
    private string connectionString;
    private SqlConnection connection;

    public DBOperation(string connectionString)
    {
        this.connectionString = connectionString;
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
}
