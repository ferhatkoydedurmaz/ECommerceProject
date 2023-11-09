using OrdersAPI.Entities;
using Shared.Results;

namespace OrdersAPI.Services;

public interface IOrderService
{
    Task<BaseDataResponse<IEnumerable<OrderDto>>> GetOrdersFilterAsync(OrderFilterSearchKeys model);
}
