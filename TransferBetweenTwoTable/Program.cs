using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using TransferBetweenTwoTable.Models;


string connectionString = "Server=localhost;Database=ShopiVerseAppDB;TrustServerCertificate=True;Trusted_Connection=True;";

using (SqlConnection dbConnection = new(connectionString))

    try
    {
        if (dbConnection.State == ConnectionState.Closed)
            dbConnection.Open();

        string query = "INSERT INTO BTables (Test1, Test2, Test3) SELECT Test1, Test2, Test3 FROM ATables";
        var addBTables = dbConnection.Execute(query);
        if (addBTables < 0)
            Console.WriteLine("Failed to add");

        Console.WriteLine("Successfully added");
    }
    catch
    {
        Console.WriteLine("An error occurred while adding");
    }
    finally
    {
        dbConnection.Close();
    }


