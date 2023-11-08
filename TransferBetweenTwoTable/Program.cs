using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using TransferBetweenTwoTable.Models;


string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ECommerceAppDB;Trusted_Connection=True;MultipleActiveResultSets=true";

using (SqlConnection dbConnection = new(connectionString))

    try
    {
        if (dbConnection.State == ConnectionState.Closed)
            dbConnection.Open();

        List<BTable> bTables = new();

        var aTables = dbConnection.Query<ATable>("SELECT * FROM ATables");

        var addBTables = dbConnection.Execute(sql: "INSERT INTO BTables (Id, Test1, Test2, Test3) VALUES (@Id, @Test1, @Test2, @Test3)", param: bTables, commandType: CommandType.Text);

        if (addBTables < 0)
            Console.WriteLine("Failed to add");

        Console.WriteLine("Successfully added");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Bağlantı hatası: " + ex.Message);
    }
    finally
    {
        dbConnection.Close();
    }


