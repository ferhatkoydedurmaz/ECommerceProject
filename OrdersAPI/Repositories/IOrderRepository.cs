using OrdersAPI.Entities;

namespace OrdersAPI.Repositories;

public interface IOrderRepository
{
    Task<IEnumerable<OrderDto>> GetOrdersAsync(OrderFilterSearchKeys model);
}
