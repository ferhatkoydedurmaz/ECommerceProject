using Dapper;
using OrdersAPI.Entities;
using System.Data;

namespace OrdersAPI.Repositories;
public class OrderRepository: IOrderRepository
{
    private readonly IDbConnection _dbConnection;

    public OrderRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<OrderDto>> GetOrdersAsync(OrderFilterSearchKeys model)
    {
        string query = "GetOrdersByFilter";

        var result = await _dbConnection.QueryAsync<OrderDto>(sql: query, param: model, commandType: CommandType.StoredProcedure);

        return result;
    }

}
