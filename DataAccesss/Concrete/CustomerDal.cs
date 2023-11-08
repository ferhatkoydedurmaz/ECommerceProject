using Dapper;
using Dapper.Contrib.Extensions;
using DataAccesss.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System.Data;

namespace DataAccesss.Concrete;
public class CustomerDal : ICustomerDal
{
    private readonly IDbConnection _dbConnection;

    public CustomerDal(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<bool> AddCustomerAsync(Customer model)
    {
        var result = await _dbConnection.InsertAsync(model);
        return result > 0;
    }

    public async Task<IEnumerable<CustomerDto>> GetCustomersAsync()
    {
        string query = "SELECT * FROM Customers WHERE IsActive=1 AND IsDeleted=0";

        var result = await _dbConnection.QueryAsync<CustomerDto>(query);

        return result;
    }
}
