using OrdersAPI.Entities;
using OrdersAPI.Repositories;
using Shared.Results;

namespace OrdersAPI.Services;
public class OrderService: IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<BaseDataResponse<IEnumerable<OrderDto>>> GetOrdersFilterAsync(OrderFilterSearchKeys model)
    {
        try
        {
            var result = await _orderRepository.GetOrdersAsync(model);

            return new BaseDataResponse<IEnumerable<OrderDto>>(result, true);
        }
        catch
        {
            return new BaseDataResponse<IEnumerable<OrderDto>>(Enumerable.Empty<OrderDto>(), false, message: "Error");
        }
    }
}
